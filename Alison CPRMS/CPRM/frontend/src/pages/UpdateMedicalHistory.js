import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import axios from 'axios';
import { 
    PlusCircleIcon, 
    XCircleIcon, 
    ExclamationCircleIcon,
    DocumentTextIcon,
    ArrowLeftIcon,
    CheckCircleIcon
  } from "@heroicons/react/24/outline";
const API_URL = "http://localhost:8000/api/";

const MedicalRecordUpdate = () => {
  const { checkupId } = useParams();
  const navigate = useNavigate();
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const [success, setSuccess] = useState(false);
  const [formData, setFormData] = useState({
    checkup: null,
    diagnoses: [],
    symptoms: [],
    prescription: null,
    medicines: [],
    test_results: [],
  });
  const [newItem, setNewItem] = useState({
    diagnosis: { name: '', note: '' },
    symptom: { name: '', severity: 'mild', note: '' },
    medicine: { name: '', dosage: '', frequency: '', duration: '', note: '' },
    test: { test_type: '', test_result: null },
  });

  const user = JSON.parse(localStorage.getItem('user'));
  const token = user?.accessToken;

  const fetchData = async () => {
    try {
      setLoading(true);
      const response = await axios.get(
        `${API_URL}checkup/${checkupId}/update/`,
        { headers: { Authorization: `Bearer ${token}` } }
      );
      setFormData(response.data);
    } catch (err) {
      setError('Failed to load medical record');
      console.error(err);
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    fetchData();
  }, [checkupId]);

  const handleStatusChange = async (status) => {
    try {
      await axios.patch(
        `${API_URL}checkup/${checkupId}/status/`,
        { status },
        { headers: { Authorization: `Bearer ${token}` } }
      );
      setFormData(prev => ({ ...prev, checkup: { ...prev.checkup, status } }));
      setSuccess(true);
    } catch (error) {
      setError('Failed to update status');
      console.error(error);
    }
  };

  const handleAddDiagnosis = async () => {
    try {
      const response = await axios.post(
        `${API_URL}checkup/${checkupId}/diagnoses/`,
        newItem.diagnosis,
        { headers: { 
          Authorization: `Bearer ${token}`,
          'Content-Type': 'application/json',
        }}
      );
      setFormData(prev => ({
        ...prev,
        diagnoses: [...prev.diagnoses, response.data]
      }));
      setNewItem(prev => ({ ...prev, diagnosis: { name: '', note: '' } }));
      setSuccess(true);
    } catch (error) {
      setError('Failed to add diagnosis');
    }
  };

  const handleUpdateDiagnosis = async (id, data) => {
    try {
      await axios.patch(
        `${API_URL}checkup/${checkupId}/diagnoses/`,
        { id, ...data },
        { headers: { 
          Authorization: `Bearer ${token}`,
          'Content-Type': 'application/json',
        }}
      );
      setFormData(prev => ({
        ...prev,
        diagnoses: prev.diagnoses.map(d => 
          d.id === id ? { ...d, ...data } : d
        )
      }));
      setSuccess(true);
    } catch (error) {
      setError('Failed to update diagnosis');
    }
  };

  const handleDeleteDiagnosis = async (id) => {
    try {
      await axios.delete(
        `${API_URL}checkup/${checkupId}/diagnoses/`,
        { 
          headers: { 
            Authorization: `Bearer ${token}`,
            'Content-Type': 'application/json',
          },
          data: { id }
        }
      );
      setFormData(prev => ({
        ...prev,
        diagnoses: prev.diagnoses.filter(d => d.id !== id)
      }));
      setSuccess(true);
    } catch (error) {
      setError('Failed to delete diagnosis');
    }
  };


  // Symptom Handlers
  const handleAddSymptom = async () => {
    try {
      const response = await axios.post(
        `${API_URL}checkup/${checkupId}/symptoms/`,
        newItem.symptom,
        { headers: { 
          Authorization: `Bearer ${token}`,
          'Content-Type': 'application/json',
        }}
      );
      setFormData(prev => ({
        ...prev,
        symptoms: [...prev.symptoms, response.data]
      }));
      setNewItem(prev => ({ 
        ...prev, 
        symptom: { name: '', severity: 'mild', note: '' } 
      }));
      setSuccess(true);
    } catch (error) {
      setError('Failed to add symptom');
    }
  };

  const handleUpdateSymptom = async (id, data) => {
    try {
      await axios.patch(
        `${API_URL}checkup/${checkupId}/symptoms/`,
        { id, ...data },
        { headers: { 
          Authorization: `Bearer ${token}`,
          'Content-Type': 'application/json',
        }}
      );
      setFormData(prev => ({
        ...prev,
        symptoms: prev.symptoms.map(s => 
          s.id === id ? { ...s, ...data } : s
        )
      }));
      setSuccess(true);
    } catch (error) {
      setError('Failed to update symptom');
    }
  };

  const handleDeleteSymptom = async (id) => {
    try {
      await axios.delete(
        `${API_URL}checkup/${checkupId}/symptoms/`,
        { 
          headers: { 
            Authorization: `Bearer ${token}`,
            'Content-Type': 'application/json',
          },
          data: { id }
        }
      );
      setFormData(prev => ({
        ...prev,
        symptoms: prev.symptoms.filter(s => s.id !== id)
      }));
      setSuccess(true);
    } catch (error) {
      setError('Failed to delete symptom');
    }
  };

  // Test Handlers
  const handleAddTest = async () => {
    const formData = new FormData();
    formData.append('test_type', newItem.test.test_type);
    if (newItem.test.test_result) {
      formData.append('test_result', newItem.test.test_result);
    }

    try {
      const response = await axios.post(
        `${API_URL}checkup/${checkupId}/tests/`,
        formData,
        { 
          headers: { 
            Authorization: `Bearer ${token}`,
            'Content-Type': 'multipart/form-data',
          }
        }
      );
      setFormData(prev => ({
        ...prev,
        test_results: [...prev.test_results, response.data]
      }));
      setNewItem(prev => ({ 
        ...prev, 
        test: { test_type: '', test_result: null } 
      }));
      setSuccess(true);
    } catch (error) {
      setError('Failed to add test');
    }
  };

  const handleUpdateTest = async (id, data) => {
    const formData = new FormData();
    formData.append('id', id);
    formData.append('test_type', data.test_type);
    if (data.test_result) {
      formData.append('test_result', data.test_result);
    }

    try {
      await axios.patch(
        `${API_URL}checkup/${checkupId}/tests/`,
        formData,
        { 
          headers: { 
            Authorization: `Bearer ${token}`,
            'Content-Type': 'multipart/form-data',
          }
        }
      );
      await fetchData(); // Refresh data to get updated file URLs
      setSuccess(true);
    } catch (error) {
      setError('Failed to update test');
    }
  };

  const handleDeleteTest = async (id) => {
    try {
      await axios.delete(
        `${API_URL}checkup/${checkupId}/tests/`,
        { 
          headers: { 
            Authorization: `Bearer ${token}`,
            'Content-Type': 'application/json',
          },
          data: { id }
        }
      );
      setFormData(prev => ({
        ...prev,
        test_results: prev.test_results.filter(t => t.id !== id)
      }));
      setSuccess(true);
    } catch (error) {
      setError('Failed to delete test');
    }
  };



  if (loading) return (
    <div className="flex justify-center items-center h-screen">
      <div className="animate-spin rounded-full h-12 w-12 border-4 border-blue-500 border-t-transparent"></div>
    </div>
  );

  if (error) return (
    <div className="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative mt-4">
      {error}
    </div>
  );


   return (
    <div className="min-h-screen bg-gray-50 py-8">
      <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
        {/* Header */}
        <div className="mb-8 flex items-center justify-between">
          <h1 className="text-3xl font-bold text-gray-900">Medical Record Update</h1>
          <button
            onClick={() => navigate(-1)}
            className="flex items-center px-4 py-2 text-gray-700 hover:text-gray-900"
          >
            <ArrowLeftIcon className="h-5 w-5 mr-2" />
            Back
          </button>
        </div>

        {/* Success Message */}
        {success && (
          <div className="mb-6 bg-green-50 p-4 rounded-md flex items-center">
            <CheckCircleIcon className="h-5 w-5 text-green-400 mr-2" />
            <p className="text-green-700">Update successful!</p>
          </div>
        )}

        {/* Error Message */}
        {error && (
          <div className="mb-6 bg-red-50 p-4 rounded-md flex items-center">
            <ExclamationCircleIcon className="h-5 w-5 text-red-400 mr-2" />
            <p className="text-red-700">{error}</p>
          </div>
        )}

        {/* Main Content */}
        <div className="space-y-6">
          {/* Status Section */}
          <div className="bg-white rounded-lg shadow p-6">
            <h2 className="text-xl font-semibold text-gray-900 mb-4">Status</h2>
            <select
              value={formData.checkup?.status || 'ongoing'}
              onChange={(e) => handleStatusChange(e.target.value)}
              className="w-full max-w-xs px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent"
            >
              <option value="ongoing">Ongoing</option>
              <option value="completed">Completed</option>
              <option value="cancelled">Cancelled</option>
            </select>
          </div>

          {/* Diagnoses Section */}
          <div className="bg-white rounded-lg shadow p-6">
            <h2 className="text-xl font-semibold text-gray-900 mb-4">Diagnoses</h2>
            <div className="space-y-4">
              {formData.diagnoses?.map((diagnosis) => (
                <div key={diagnosis.id} className="flex items-start space-x-4 p-4 bg-gray-50 rounded-md">
                  <div className="flex-grow space-y-3">
                    <input
                      type="text"
                      value={diagnosis.name}
                      onChange={(e) => handleUpdateDiagnosis(diagnosis.id, { name: e.target.value })}
                      className="w-full px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                      placeholder="Diagnosis name"
                    />
                    <textarea
                      value={diagnosis.note}
                      onChange={(e) => handleUpdateDiagnosis(diagnosis.id, { note: e.target.value })}
                      className="w-full px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                      placeholder="Notes"
                      rows="2"
                    />
                  </div>
                  <button
                    onClick={() => handleDeleteDiagnosis(diagnosis.id)}
                    className="text-red-500 hover:text-red-700"
                  >
                    <XCircleIcon className="h-6 w-6" />
                  </button>
                </div>
              ))}
              
              {/* New Diagnosis Form */}
              <div className="p-4 bg-blue-50 rounded-md">
                <div className="space-y-3">
                  <input
                    type="text"
                    value={newItem.diagnosis.name}
                    onChange={(e) => setNewItem(prev => ({
                      ...prev,
                      diagnosis: { ...prev.diagnosis, name: e.target.value }
                    }))}
                    className="w-full px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                    placeholder="New diagnosis name"
                  />
                  <textarea
                    value={newItem.diagnosis.note}
                    onChange={(e) => setNewItem(prev => ({
                      ...prev,
                      diagnosis: { ...prev.diagnosis, note: e.target.value }
                    }))}
                    className="w-full px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                    placeholder="New diagnosis notes"
                    rows="2"
                  />
                  <button
                    onClick={handleAddDiagnosis}
                    disabled={!newItem.diagnosis.name}
                    className="flex items-center px-4 py-2 bg-blue-500 text-white rounded-md hover:bg-blue-600 disabled:bg-gray-300 disabled:cursor-not-allowed"
                  >
                    <PlusCircleIcon className="h-5 w-5 mr-2" />
                    Add Diagnosis
                  </button>
                </div>
              </div>
            </div>
          </div>

          {/* Symptoms Section */}
          <div className="bg-white rounded-lg shadow p-6">
            <h2 className="text-xl font-semibold text-gray-900 mb-4">Symptoms</h2>
            <div className="space-y-4">
              {formData.symptoms?.map((symptom) => (
                <div key={symptom.id} className="flex items-start space-x-4 p-4 bg-gray-50 rounded-md">
                  <div className="flex-grow space-y-3">
                    <div className="flex space-x-4">
                      <input
                        type="text"
                        value={symptom.name}
                        onChange={(e) => handleUpdateSymptom(symptom.id, { name: e.target.value })}
                        className="flex-grow px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                        placeholder="Symptom name"
                      />
                      <select
                        value={symptom.severity}
                        onChange={(e) => handleUpdateSymptom(symptom.id, { severity: e.target.value })}
                        className="px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                      >
                        <option value="mild">Mild</option>
                        <option value="moderate">Moderate</option>
                        <option value="severe">Severe</option>
                      </select>
                    </div>
                    <textarea
                      value={symptom.note}
                      onChange={(e) => handleUpdateSymptom(symptom.id, { note: e.target.value })}
                      className="w-full px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                      placeholder="Notes"
                      rows="2"
                    />
                  </div>
                  <button
                    onClick={() => handleDeleteSymptom(symptom.id)}
                    className="text-red-500 hover:text-red-700"
                  >
                    <XCircleIcon className="h-6 w-6" />
                  </button>
                </div>
              ))}

              {/* New Symptom Form */}
              <div className="p-4 bg-blue-50 rounded-md">
                <div className="space-y-3">
                  <div className="flex space-x-4">
                    <input
                      type="text"
                      value={newItem.symptom.name}
                      onChange={(e) => setNewItem(prev => ({
                        ...prev,
                        symptom: { ...prev.symptom, name: e.target.value }
                      }))}
                      className="flex-grow px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                      placeholder="New symptom name"
                    />
                    <select
                      value={newItem.symptom.severity}
                      onChange={(e) => setNewItem(prev => ({
                        ...prev,
                        symptom: { ...prev.symptom, severity: e.target.value }
                      }))}
                      className="px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                    >
                      <option value="mild">Mild</option>
                      <option value="moderate">Moderate</option>
                      <option value="severe">Severe</option>
                    </select>
                  </div>
                  <textarea
                    value={newItem.symptom.note}
                    onChange={(e) => setNewItem(prev => ({
                      ...prev,
                      symptom: { ...prev.symptom, note: e.target.value }
                    }))}
                    className="w-full px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                    placeholder="New symptom notes"
                    rows="2"
                  />
                  <button
                    onClick={handleAddSymptom}
                    disabled={!newItem.symptom.name}
                    className="flex items-center px-4 py-2 bg-blue-500 text-white rounded-md hover:bg-blue-600 disabled:bg-gray-300 disabled:cursor-not-allowed"
                  >
                    <PlusCircleIcon className="h-5 w-5 mr-2" />
                    Add Symptom
                  </button>
                </div>
              </div>
            </div>
          </div>

          {/* Tests Section */}
          {/* <div className="bg-white rounded-lg shadow p-6">
            <h2 className="text-xl font-semibold text-gray-900 mb-4">Tests</h2>
            <div className="space-y-4">
              {formData.test_results?.map((test) => (
                <div key={test.id} className="flex items-start space-x-4 p-4 bg-gray-50 rounded-md">
                  <div className="flex-grow space-y-3">
                    <input
                      type="text"
                      value={test.test_type}
                      onChange={(e) => handleUpdateTest(test.id, { test_type: e.target.value })}
                      className="w-full px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                      placeholder="Test type"
                    />
                    <div className="flex space-x-4">
                      <input
                        type="file"
                        onChange={(e) => handleUpdateTest(test.id, { test_result: e.target.files[0] })}
                        className="flex-grow"
                      />
                      {test.test_result_url && (
                        <a
                          href={test.test_result_url}
                          target="_blank"
                          rel="noopener noreferrer"
                          className="flex items-center px-4 py-2 bg-gray-100 text-gray-700 rounded-md hover:bg-gray-200"
                        >
                          <DocumentTextIcon className="h-5 w-5 mr-2" />
                          View Result
                        </a>
                      )}
                    </div>
                  </div>
                  <button
                    onClick={() => handleDeleteTest(test.id)}
                    className="text-red-500 hover:text-red-700"
                  >
                    <XCircleIcon className="h-6 w-6" />
                  </button>
                </div>
              ))} */}

              {/* New Test Form */}
              {/* <div className="p-4 bg-blue-50 rounded-md">
                <div className="space-y-3">
                  <input
                    type="text"
                    value={newItem.test.test_type}
                    onChange={(e) => setNewItem(prev => ({
                      ...prev,
                      test: { ...prev.test, test_type: e.target.value }
                    }))}
                    className="w-full px-4 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                    placeholder="New test type"
                  />
                  <input
                    type="file"
                    onChange={(e) => setNewItem(prev => ({
                      ...prev,
                      test: { ...prev.test, test_result: e.target.files[0] }
                    }))}
                    className="w-full"
                  />
                  <button
                    onClick={handleAddTest}
                    disabled={!newItem.test.test_type}
                    className="flex items-center px-4 py-2 bg-blue-500 text-white rounded-md hover:bg-blue-600 disabled:bg-gray-300 disabled:cursor-not-allowed"
                  >
                    <PlusCircleIcon className="h-5 w-5 mr-2" />
                    Add Test
                  </button>
                </div>
              </div>
            </div> */}
          {/* </div> */}
        </div>
      </div>
    </div>
  );
};

export default MedicalRecordUpdate;


















