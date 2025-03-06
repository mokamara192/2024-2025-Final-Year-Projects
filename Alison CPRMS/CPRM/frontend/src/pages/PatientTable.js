import { useState, useEffect } from "react";
import axios from "axios";

const API_URL = "http://localhost:8000/api/";

const PatientTable = () => {
  const [patients, setPatients] = useState([]);
  const [searchParams, setSearchParams] = useState({});
  const [selectedPatient, setSelectedPatient] = useState(null);
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [isEditMode, setIsEditMode] = useState(false);
  const [formData, setFormData] = useState({});
  const [hasSearched, setHasSearched] = useState(false);

  // Remove initial fetchPatients call
  // useEffect(() => {
  //   fetchPatients();
  // }, []);

  const fetchPatients = async () => {
    const user = JSON.parse(localStorage.getItem('user'));
    const token = user?.accessToken;
    
    // Only fetch if at least one search parameter has a value
    const hasValidSearchParams = Object.values(searchParams).some(value => value && value.trim() !== '');
    
    if (!hasValidSearchParams) {
      setPatients([]);
      setHasSearched(false);
      return;
    }

    try {
      const response = await axios.get(`${API_URL}patients/search/`,
        {
          params: searchParams,
          headers: { Authorization: `Bearer ${token}` }
        }
      );
      setPatients(response.data);
      setHasSearched(true);
    } catch (error) {
      console.error("Error fetching patients:", error);
      setPatients([]);
    }
  };

  const handleSearchChange = (e) => {
    const { name, value } = e.target;
    setSearchParams(prev => ({
      ...prev,
      [name]: value
    }));
  };

  const handleSearchSubmit = (e) => {
    e.preventDefault();
    fetchPatients();
  };

  const openModal = (patient, editMode = false) => {
    setSelectedPatient(patient);
    setIsEditMode(editMode);
    setFormData({
      ...patient,
      blood_type: patient.blood_type || '',
      medical_info: patient.medical_info || ''
    });
    setIsModalOpen(true);
  };

  const closeModal = () => {
    setIsModalOpen(false);
    setSelectedPatient(null);
    setFormData({});
  };

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData(prev => ({
      ...prev,
      [name]: value
    }));
  };

  const handleUpdate = async () => {
    const user = JSON.parse(localStorage.getItem('user'));
    const token = user?.accessToken;
    try {
      await axios.patch(
        `${API_URL}patients/${selectedPatient.id}/update/`, 
        formData, 
        {
          headers: { Authorization: `Bearer ${token}` }
        }
      );
      fetchPatients();
      closeModal();
    } catch (error) {
      console.error("Error updating patient:", error);
    }
  };

  const handleDelete = async (patientToDelete) => {
    const user = JSON.parse(localStorage.getItem('user'));
    const token = user?.accessToken;

    try {
      await axios.delete(`${API_URL}patients/${patientToDelete.id}/delete/`, {
        headers: { Authorization: `Bearer ${token}` },
      });
      fetchPatients();
      if (isModalOpen) closeModal();
    } catch (error) {
      console.error("Error deleting patient:", error);
    }
  };

  return (
    <div className="p-6 bg-gray-100 min-h-screen">
      <form onSubmit={handleSearchSubmit} className="flex flex-wrap gap-2 mb-4 bg-white p-4 rounded shadow">
        <input 
          className="border p-2 rounded w-full md:w-1/4" 
          name="patient_id" 
          placeholder="Patient ID" 
          onChange={handleSearchChange}
          value={searchParams.patient_id || ''} 
        />
        <input 
          className="border p-2 rounded w-full md:w-1/4" 
          name="nin" 
          placeholder="NIN" 
          onChange={handleSearchChange}
          value={searchParams.nin || ''} 
        />
        <input 
          className="border p-2 rounded w-full md:w-1/4" 
          name="phone" 
          placeholder="Phone" 
          onChange={handleSearchChange}
          value={searchParams.phone || ''} 
        />
        <input 
          className="border p-2 rounded w-full md:w-1/4" 
          name="address" 
          placeholder="Address" 
          onChange={handleSearchChange}
          value={searchParams.address || ''} 
        />
        <button type="submit" className="bg-blue-500 text-white px-4 py-2 rounded">
          Search
        </button>
      </form>
      
      <div className="overflow-x-auto bg-white p-4 rounded shadow">
        {!hasSearched ? (
          <p className="text-center text-gray-500 py-4">
            Enter search criteria and click Search to find patients
          </p>
        ) : patients.length === 0 ? (
          <p className="text-center text-gray-500 py-4">
            No patients found matching your search criteria
          </p>
        ) : (
          <table className="w-full border-collapse">
            <thead>
              <tr className="bg-gray-200">
                <th className="p-2 border">Patient ID</th>
                <th className="p-2 border">Full Name</th>
                <th className="p-2 border">Age</th>
                <th className="p-2 border">Gender</th>
                <th className="p-2 border">Phone</th>
                <th className="p-2 border">NIN</th>
                <th className="p-2 border">Actions</th>
              </tr>
            </thead>
            <tbody>
              {patients.map((patient) => (
                <tr key={patient.id} className="hover:bg-gray-100">
                  <td className="p-2 border">{patient.id}</td>
                  <td className="p-2 border">
                    {patient.first_name} {patient.middle_name} {patient.last_name}
                  </td>
                  <td className="p-2 border">{patient.age}</td>
                  <td className="p-2 border">{patient.gender}</td>
                  <td className="p-2 border">{patient.phone_number}</td>
                  <td className="p-2 border">{patient.nin}</td>
                  <td className="p-2 border">
                    <button 
                      onClick={() => openModal(patient)} 
                      className="bg-green-500 text-white px-2 py-1 rounded mr-2"
                    >
                      View
                    </button>
                    <button 
                      onClick={() => openModal(patient, true)} 
                      className="bg-yellow-500 text-white px-2 py-1 rounded mr-2"
                    >
                      Edit
                    </button>
                    <button 
                      onClick={() => {
                        if (window.confirm("Are you sure you want to delete this patient?")) {
                          handleDelete(patient);
                        }
                      }} 
                      className="bg-red-500 text-white px-2 py-1 rounded"
                    >
                      Delete
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        )}
      </div>

      {isModalOpen && (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex justify-center items-center p-4">
          <div className="bg-white p-6 rounded shadow-lg w-full max-w-lg">
            <h2 className="text-xl font-bold mb-4">
              {isEditMode ? "Edit Patient" : "Patient Details"}
            </h2>
            {isEditMode ? (
              <div className="space-y-2">
                <input 
                  className="border p-2 rounded w-full" 
                  name="first_name" 
                  value={formData.first_name || ''} 
                  onChange={handleInputChange} 
                  placeholder="First Name"
                />
                <input 
                  className="border p-2 rounded w-full" 
                  name="middle_name" 
                  value={formData.middle_name || ''} 
                  onChange={handleInputChange} 
                  placeholder="Middle Name"
                />
                <input 
                  className="border p-2 rounded w-full" 
                  name="last_name" 
                  value={formData.last_name || ''} 
                  onChange={handleInputChange} 
                  placeholder="Last Name"
                />
                <input 
                  className="border p-2 rounded w-full" 
                  name="date_of_birth" 
                  type="date" 
                  value={formData.date_of_birth || ''} 
                  onChange={handleInputChange} 
                />
                <input 
                  className="border p-2 rounded w-full" 
                  name="gender" 
                  value={formData.gender || ''} 
                  onChange={handleInputChange} 
                  placeholder="Gender"
                />
                <input 
                  className="border p-2 rounded w-full" 
                  name="phone_number" 
                  value={formData.phone_number || ''} 
                  onChange={handleInputChange} 
                  placeholder="Phone Number"
                />
                <input 
                  className="border p-2 rounded w-full" 
                  name="nin" 
                  value={formData.nin || ''} 
                  onChange={handleInputChange} 
                  placeholder="NIN"
                />
                <input 
                  className="border p-2 rounded w-full" 
                  name="address" 
                  value={formData.address || ''} 
                  onChange={handleInputChange} 
                  placeholder="Address"
                />
                <input 
                  className="border p-2 rounded w-full" 
                  name="blood_type" 
                  value={formData.blood_type || ''} 
                  onChange={handleInputChange} 
                  placeholder="Blood Type"
                />
                <input 
                  className="border p-2 rounded w-full" 
                  name="medical_info" 
                  value={formData.medical_info || ''} 
                  onChange={handleInputChange} 
                  placeholder="Medical Info"
                />
                <button 
                  onClick={handleUpdate} 
                  className="bg-blue-500 text-white px-4 py-2 rounded"
                >
                  Save Changes
                </button>
              </div>
            ) : (
              <div className="space-y-2">
                <p><strong>Full Name:</strong> {selectedPatient.first_name} {selectedPatient.middle_name} {selectedPatient.last_name}</p>
                <p><strong>Date of Birth:</strong> {selectedPatient.date_of_birth}</p>
                <p><strong>Age:</strong> {selectedPatient.age}</p>
                <p><strong>Gender:</strong> {selectedPatient.gender}</p>
                <p><strong>Phone:</strong> {selectedPatient.phone_number}</p>
                <p><strong>NIN:</strong> {selectedPatient.nin}</p>
                <p><strong>Address:</strong> {selectedPatient.address}</p>
                <p><strong>Blood Type:</strong> {selectedPatient.blood_type}</p>
                <p><strong>Medical Info:</strong> {selectedPatient.medical_info}</p>
              </div>
            )}
            <button 
              onClick={closeModal} 
              className="bg-red-500 text-white px-4 py-2 rounded mt-4"
            >
              Close
            </button>
          </div>
        </div>
      )}
    </div>
  );
};

export default PatientTable;
