import React, { useState, useEffect } from 'react';
import { createTriage, getTriageList, deleteTriage } from '../utils/triageUtils';
import { useNavigate } from 'react-router-dom';
// import { TrashIcon, EyeIcon } from '@heroicons/react/24/solid';
import {
  TrashIcon,
  EyeIcon,
  PlusCircleIcon,
  HeartIcon,
  UserIcon,
  ClipboardDocumentCheckIcon,
  ExclamationTriangleIcon
} from '@heroicons/react/24/outline';

export const CreateTriageForm = () => {
  const navigate = useNavigate();
  const [showMessage, setShowMessage] = useState(false);
  const [formData, setFormData] = useState({
    patient_id: '',
    blood_pressure: '',
    heart_rate: '',
    temperature: '',
    oxygen_saturation: '',
    chief_complaint: '',
    priority_level: '',
    initial_assessment: ''
  });

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const formDataToSubmit = new FormData();
      Object.keys(formData).forEach(key => {
        formDataToSubmit.append(key, formData[key]);
      });
      await createTriage(formData);
      setShowMessage(true);
      setTimeout(() => {
        setShowMessage(false);
        navigate('/triage-list'); // Navigate after message
      }, 2000);
    } catch (error) {
      console.error('Error creating triage:', error);
    }
  };


  return (
    <div className="max-w-2xl mx-auto">
      <div className="bg-white rounded-xl shadow-sm border border-gray-100 p-6">
        <div className="flex items-center gap-3 mb-6">
          <ClipboardDocumentCheckIcon className="h-6 w-6 text-blue-500" />
          <h2 className="text-2xl font-semibold text-gray-800">Create Triage Record</h2>
        </div>
        {showMessage && (
        <div className="fixed bottom-4 right-4 bg-green-500 text-white px-6 py-3 rounded-lg shadow-lg animate-fade-in-up">
          Triage record created successfully!
        </div>
      )}
        <form onSubmit={handleSubmit} className="space-y-6">
          <div className="grid md:grid-cols-2 gap-6">
            <div className="space-y-2">
              <label className="block text-sm font-medium text-gray-700">Patient ID</label>
              <input
                type="text"
                name="patient_id"
                value={formData.patient_id}
                onChange={handleChange}
                className="w-full px-4 py-2 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 transition-colors"
                placeholder="Enter patient ID"
              />
            </div>

            <div className="space-y-2">
              <label className="block text-sm font-medium text-gray-700">Blood Pressure</label>
              <input
                type="text"
                name="blood_pressure"
                value={formData.blood_pressure}
                onChange={handleChange}
                className="w-full px-4 py-2 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 transition-colors"
                placeholder="e.g., 120/80"
              />
            </div>

            <div className="space-y-2">
              <label className="block text-sm font-medium text-gray-700">Heart Rate</label>
              <input
                type="number"
                name="heart_rate"
                value={formData.heart_rate}
                onChange={handleChange}
                className="w-full px-4 py-2 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 transition-colors"
                placeholder="BPM"
              />
            </div>

            <div className="space-y-2">
              <label className="block text-sm font-medium text-gray-700">Temperature</label>
              <input
                type="number"
                name="temperature"
                value={formData.temperature}
                onChange={handleChange}
                className="w-full px-4 py-2 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 transition-colors"
                placeholder="°C"
              />
            </div>

            <div className="space-y-2">
              <label className="block text-sm font-medium text-gray-700">Oxygen Saturation</label>
              <input
                type="number"
                name="oxygen_saturation"
                value={formData.oxygen_saturation}
                onChange={handleChange}
                className="w-full px-4 py-2 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 transition-colors"
                placeholder="%"
              />
            </div>

            <div className="space-y-2">
              <label className="block text-sm font-medium text-gray-700">Priority Level</label>
              <select
                name="priority_level"
                value={formData.priority_level}
                onChange={handleChange}
                className="w-full px-4 py-2 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 transition-colors"
              >
                <option value="">Select Priority</option>
                <option value="low">Low</option>
                <option value="moderate">Moderate</option>
                <option value="high">High</option>
                <option value="emergency">Emergency</option>
              </select>
            </div>
          </div>

          <div className="space-y-2">
            <label className="block text-sm font-medium text-gray-700">Chief Complaint</label>
            <textarea
              name="chief_complaint"
              value={formData.chief_complaint}
              onChange={handleChange}
              className="w-full px-4 py-2 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 transition-colors"
              rows="3"
              placeholder="Enter chief complaint"
            />
          </div>

          <div className="space-y-2">
            <label className="block text-sm font-medium text-gray-700">Initial Assessment</label>
            <textarea
              name="initial_assessment"
              value={formData.initial_assessment}
              onChange={handleChange}
              className="w-full px-4 py-2 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 transition-colors"
              rows="4"
              placeholder="Enter initial assessment"
            />
          </div>

          <button
            type="submit"
            className="w-full flex items-center justify-center gap-2 px-6 py-3 bg-blue-500 text-white rounded-lg hover:bg-blue-600 focus:ring-4 focus:ring-blue-200 transition-colors"
          >
            <PlusCircleIcon className="h-5 w-5" />
            Create Triage Record
          </button>
        </form>
      </div>
    </div>
  );
};

export const TriageList = () => {
  const [triages, setTriages] = useState([]);
  const [selectedTriage, setSelectedTriage] = useState(null);
  const navigate = useNavigate();

  useEffect(() => {
    fetchTriages();
  }, []);

  const fetchTriages = async () => {
    try {
      const triageData = await getTriageList();
      setTriages(triageData);
    } catch (error) {
      console.error('Error fetching triage list:', error);
    }
  };

  const handleDelete = async (triageId) => {
    try {
      await deleteTriage(triageId);
      fetchTriages();
    } catch (error) {
      console.error('Error deleting triage:', error);
    }
  };

  const getPriorityBadge = (priority) => {
    const baseClasses = "px-3 py-1 rounded-full text-sm font-medium";
    switch (priority.toLowerCase()) {
      case 'low':
        return `${baseClasses} bg-green-100 text-green-800`;
      case 'medium':
        return `${baseClasses} bg-yellow-100 text-yellow-800`;
      case 'high':
        return `${baseClasses} bg-orange-100 text-orange-800`;
      case 'emergency':
        return `${baseClasses} bg-red-100 text-red-800`;
      default:
        return `${baseClasses} bg-gray-100 text-gray-800`;
    }
  };

  return (
    <div className="container mx-auto px-4 py-8">
      <div className="flex items-center justify-between mb-6">
        <h1 className="text-2xl font-bold text-gray-800">Triage Records</h1>
        <button
          onClick={() => navigate('/create-triage')}
          className="flex items-center gap-2 px-4 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors"
        >
          <PlusCircleIcon className="h-5 w-5" />
          New Triage
        </button>
      </div>

      <div className="grid gap-4">
        {triages.map((triage) => (
          <div key={triage.id} className="bg-white rounded-xl shadow-sm border border-gray-100 p-6">
            <div className="flex flex-col md:flex-row justify-between gap-4">
              <div className="grid md:grid-cols-2 gap-x-12 gap-y-4">
                <div className="space-y-4">
                  <div className="flex items-center gap-2">
                    <UserIcon className="h-5 w-5 text-gray-400" />
                    <div>
                      <p className="text-sm text-gray-500">Patient ID</p>
                      <p className="font-medium">{triage.patient.id}</p>
                    </div>
                  </div>
                  
                  <div className="flex items-center gap-2">
                    <HeartIcon className="h-5 w-5 text-rose-400" />
                    <div>
                      <p className="text-sm text-gray-500">Vitals</p>
                      <div className="space-y-1">
                        <p className="font-medium">HR: {triage.heart_rate} bpm</p>
                        <p className="font-medium">BP: {triage.blood_pressure}</p>
                        <p className="font-medium">Temp: {triage.temperature}°C</p>
                        <p className="font-medium">O₂: {triage.oxygen_saturation}%</p>
                      </div>
                    </div>
                  </div>
                </div>

                <div className="space-y-4">
                  <div className="flex items-center gap-2">
                    <ExclamationTriangleIcon className="h-5 w-5 text-gray-400" />
                    <div>
                      <p className="text-sm text-gray-500">Priority Level</p>
                      <span className={getPriorityBadge(triage.priority_level)}>
                        {triage.priority_level}
                      </span>
                    </div>
                  </div>

                  <div>
                    <p className="text-sm text-gray-500">Date</p>
                    <p className="font-medium">
                      {new Date(triage.date).toLocaleDateString()}
                    </p>
                  </div>
                </div>
              </div>

              <div className="flex md:flex-col gap-2 ml-auto">
                <button
                  onClick={() => setSelectedTriage(triage)}
                  className="flex items-center gap-2 px-4 py-2 text-gray-700 bg-gray-100 rounded-lg hover:bg-gray-200 transition-colors"
                >
                  <EyeIcon className="h-5 w-5" />
                  <span className="hidden md:inline">View</span>
                </button>
                
                <button
                  onClick={() => navigate(`/create-checkup/${triage.id}`)}
                  className="flex items-center gap-2 px-4 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors"
                >
                  <PlusCircleIcon className="h-5 w-5" />
                  <span className="hidden md:inline">Create Checkup</span>
                </button>

                <button
                  onClick={() => handleDelete(triage.id)}
                  className="flex items-center gap-2 px-4 py-2 text-red-600 bg-red-50 rounded-lg hover:bg-red-100 transition-colors"
                >
                  <TrashIcon className="h-5 w-5" />
                  <span className="hidden md:inline">Delete</span>
                </button>
              </div>
            </div>
          </div>
        ))}
      </div>

      {/* Detailed View Modal */}
      {selectedTriage && (
        <div className="fixed inset-0 bg-black/50 flex items-center justify-center p-4 z-50">
          <div className="bg-white rounded-xl shadow-lg max-w-2xl w-full max-h-[90vh] overflow-y-auto">
            <div className="p-6">
              <div className="flex items-center justify-between mb-6">
                <h2 className="text-2xl font-semibold text-gray-800">Triage Details</h2>
                <button
                  onClick={() => setSelectedTriage(null)}
                  className="text-gray-400 hover:text-gray-600"
                >
                  <svg className="w-6 h-6" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                    <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M6 18L18 6M6 6l12 12" />
                  </svg>
                </button>
              </div>

              <div className="grid md:grid-cols-2 gap-6">
                <div className="space-y-4">
                  <div>
                    <p className="text-sm text-gray-500">Patient Information</p>
                    <p className="font-medium">ID: {selectedTriage.patient.id}</p>
                    <p className="font-medium">
                      {selectedTriage.patient.first_name} {selectedTriage.patient.last_name}
                    </p>
                  </div>

                  <div>
                    <p className="text-sm text-gray-500">Vital Signs</p>
                    <div className="space-y-2">
                      <p className="font-medium">Heart Rate: {selectedTriage.heart_rate} bpm</p>
                      <p className="font-medium">Blood Pressure: {selectedTriage.blood_pressure}</p>
                      <p className="font-medium">Temperature: {selectedTriage.temperature}°C</p>
                      <p className="font-medium">Oxygen: {selectedTriage.oxygen_saturation}%</p>
                    </div>
                  </div>
                </div>

                <div className="space-y-4">
                  <div>
                    <p className="text-sm text-gray-500">Staff Information</p>
                    <p className="font-medium">Staff ID: {selectedTriage.staff.id}</p>
                  </div>

                  <div>
                    <p className="text-sm text-gray-500">Date & Time</p>
                    <p className="font-medium">
                      {new Date(selectedTriage.date).toLocaleString()}
                    </p>
                  </div>

                  <div>
                    <p className="text-sm text-gray-500">Priority Level</p>
                    <span className={getPriorityBadge(selectedTriage.priority_level)}>
                      {selectedTriage.priority_level}
                    </span>
                  </div>
                </div>

                <div className="md:col-span-2 space-y-4">
                  <div>
                    <p className="text-sm text-gray-500">Chief Complaint</p>
                    <p className="mt-1 p-3 bg-gray-50 rounded-lg">
                      {selectedTriage.chief_complaint}
                    </p>
                  </div>

                  <div>
                    <p className="text-sm text-gray-500">Initial Assessment</p>
                    <p className="mt-1 p-3 bg-gray-50 rounded-lg">
                      {selectedTriage.initial_assessment}
                    </p>
                  </div>
                </div>
              </div>

              <div className="mt-6 flex justify-end gap-3">
                <button
                  onClick={() => setSelectedTriage(null)}
                  className="px-4 py-2 text-gray-600 bg-gray-100 rounded-lg hover:bg-gray-200 transition-colors"
                >
                  Close
                </button>
                <button
                  onClick={() => {
                    navigate(`/create-checkup/${selectedTriage.id}`);
                    setSelectedTriage(null);
                  }}
                  className="flex items-center gap-2 px-4 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors"
                >
                  <PlusCircleIcon className="h-5 w-5" />
                  Create Checkup
                </button>
              </div>
            </div>
          </div>
        </div>
      )}
    </div>
  );
};






// import React, { useState, useEffect } from 'react';
// import { createTriage, getTriageList, deleteTriage } from '../utils/triageUtils';
// import { useNavigate } from 'react-router-dom';
// import { TrashIcon, EyeIcon } from '@heroicons/react/24/solid';

// export const CreateTriageForm = () => {
//   const [formData, setFormData] = useState({
//     patient_id: '',
//     blood_pressure: '',
//     heart_rate: '',
//     temperature: '',
//     oxygen_saturation: '',
//     chief_complaint: '',
//     priority_level: '',
//     initial_assessment: ''
//   });

//   const handleChange = (e) => {
//     setFormData({ ...formData, [e.target.name]: e.target.value });
//   };

//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     try {

//       const formDataToSubmit = new FormData();
//       Object.keys(formData).forEach(key => {
//           console.log(`Appending ${key}:`, formData[key]); // Log to see each field
//           formDataToSubmit.append(key, formData[key]);
//       });

//           // Log all FormData entries
//     for (let [key, value] of formDataToSubmit.entries()) {
//       console.log(`${key}: ${value}`);
//     }


    

//       await createTriage(formData);
//       // Reset form or navigate to triage list
//     } catch (error) {
//       console.error('Error creating triage:', error);
//     }
//   };

//   return (
//     <div className="bg-white p-4 rounded-lg shadow">
//       <h2 className="text-2xl font-bold mb-4">Create Triage</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <input
//           type="text"
//           name="patient_id"
//           value={formData.patient_id}
//           onChange={handleChange}
//           placeholder="Patient ID"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         />
//         <input
//           type="text"
//           name="blood_pressure"
//           value={formData.blood_pressure}
//           onChange={handleChange}
//           placeholder="Blood Pressure"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         />
//         <input
//           type="number"
//           name="heart_rate"
//           value={formData.heart_rate}
//           onChange={handleChange}
//           placeholder="Heart Rate"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         />
//         <input
//           type="number"
//           name="temperature"
//           value={formData.temperature}
//           onChange={handleChange}
//           placeholder="Temperature"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         />
//         <input
//           type="number"
//           name="oxygen_saturation"
//           value={formData.oxygen_saturation}
//           onChange={handleChange}
//           placeholder="Oxygen Saturation"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         />
//         <textarea
//           name="chief_complaint"
//           value={formData.chief_complaint}
//           onChange={handleChange}
//           placeholder="Chief Complaint"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         ></textarea>
//         <select
//           name="priority_level"
//           value={formData.priority_level}
//           onChange={handleChange}
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424]"
//         >
//           <option value="">Select Priority Level</option>
//           <option value="low">Low</option>
//           <option value="medium">Medium</option>
//           <option value="high">High</option>
//           <option value="emergency">Emergency</option>
//         </select>
//         <textarea
//           name="initial_assessment"
//           value={formData.initial_assessment}
//           onChange={handleChange}
//           placeholder="Initial Assessment"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         ></textarea>
//         <button type="submit" className="w-full p-2 bg-[#146FEF] text-white rounded">Create</button>
//       </form>
//     </div>
//   );
// };














// export const TriageList = () => {
//   const [triages, setTriages] = useState([]);
//   const [selectedTriage, setSelectedTriage] = useState(null);
//   const navigate = useNavigate();

//   useEffect(() => {
//     fetchTriages();
//   }, []);

//   const fetchTriages = async () => {
//     try {
//       const triageData = await getTriageList();
//       setTriages(triageData);
//     } catch (error) {
//       console.error('Error fetching triage list:', error);
//     }
//   };

//   const handleDelete = async (triageId) => {
//     try {
//       await deleteTriage(triageId);
//       fetchTriages();
//     } catch (error) {
//       console.error('Error deleting triage:', error);
//     }
//   };

//   const handleCreateCheckup = (triageId) => {
//     navigate(`/create-checkup/${triageId}`);
//   };

//   const handleView = (triage) => {
//     setSelectedTriage(triage);
//   };

//   const closeDetailedView = () => {
//     setSelectedTriage(null);
//   };

//   const getPriorityColor = (priority) => {
//     switch (priority.toLowerCase()) {
//       case 'low':
//         return 'text-green-500';
//       case 'medium':
//         return 'text-yellow-500';
//       case 'high':
//         return 'text-orange-500';
//       case 'emergency':
//         return 'text-red-500';
//       default:
//         return 'text-gray-500';
//     }
//   };

//   return (
//     <div className="container mx-auto px-4 py-8">
//       <h1 className="text-3xl font-bold mb-6">Triage List</h1>
//       <div className="space-y-4">
//         {triages.map((triage) => (
//           <div key={triage.id} className="bg-white rounded-lg shadow-md p-4">
//             <div className="flex justify-between items-center">
//               <div>
//                 <p><span className="font-semibold">Patient ID:</span> {triage.patient.id}</p>
//                 <p><span className="font-semibold">Staff ID:</span> {triage.staff.id}</p>
//                 <p><span className="font-semibold">Heart Rate:</span> {triage.heart_rate}</p>
//                 <p><span className="font-semibold">Blood Pressure:</span> {triage.blood_pressure}</p>
//                 <p><span className="font-semibold">Temperature:</span> {triage.temperature}</p>
//                 <p><span className="font-semibold">Oxygen:</span> {triage.oxygen_saturation}%</p>
//                 <p className={`font-semibold ${getPriorityColor(triage.priority_level)}`}>
//                   Priority Level: {triage.priority_level}
//                 </p>
//                 <p><span className="font-semibold">Date:</span> {new Date(triage.date).toLocaleDateString()}</p>
//               </div>
//               <div className="flex space-x-2">
//                 <button
//                   onClick={() => handleView(triage)}
//                   className="bg-gray-800 text-white px-4 py-2 rounded flex items-center"
//                 >
//                   <EyeIcon className="h-5 w-5 mr-2" />
//                   View
//                 </button>
//                 <button
//                   onClick={() => handleCreateCheckup(triage.id)}
//                   className="bg-blue-500 text-white px-4 py-2 rounded"
//                 >
//                   Create Check Up
//                 </button>
//                 <button
//                   onClick={() => handleDelete(triage.id)}
//                   className="bg-red-500 text-white p-2 rounded"
//                 >
//                   <TrashIcon className="h-5 w-5" />
//                 </button>
//               </div>
//             </div>
//           </div>
//         ))}
//       </div>

//       {selectedTriage && (
//         <div className="fixed inset-0 bg-black bg-opacity-50 flex justify-center items-center">
//           <div className="bg-white rounded-lg p-6 max-w-2xl w-full">
//             <h2 className="text-2xl font-bold mb-4">Triage Detailed</h2>
//             <div className="grid grid-cols-2 gap-4">
//               <div>
//                 <p><span className="font-semibold">Patient ID:</span> {selectedTriage.patient.id}</p>
//                 <p><span className="font-semibold">Name:</span> {selectedTriage.patient.first_name} {selectedTriage.patient.last_name}</p>
//                 <p><span className="font-semibold">Heart Rate:</span> {selectedTriage.heart_rate}</p>
//                 <p><span className="font-semibold">Oxygen:</span> {selectedTriage.oxygen_saturation}%</p>
//                 <p><span className="font-semibold">Initial Assessment:</span> {selectedTriage.initial_assessment}</p>
//               </div>
//               <div>
//                 <p><span className="font-semibold">Staff ID:</span> {selectedTriage.staff.id}</p>
//                 <p><span className="font-semibold">Date:</span> {new Date(selectedTriage.date).toLocaleDateString()}</p>
//                 <p><span className="font-semibold">Blood Pressure:</span> {selectedTriage.blood_pressure}</p>
//                 <p><span className="font-semibold">Temperature:</span> {selectedTriage.temperature}</p>
//                 <p><span className="font-semibold">Chief Complaint:</span> {selectedTriage.chief_complaint}</p>
//               </div>
//             </div>
//             <p className={`font-semibold ${getPriorityColor(selectedTriage.priority_level)} mt-4`}>
//               Priority Level: {selectedTriage.priority_level}
//             </p>
//             <div className="mt-6 flex justify-end space-x-4">
//               <button
//                 onClick={() => handleCreateCheckup(selectedTriage.id)}
//                 className="bg-blue-500 text-white px-4 py-2 rounded"
//               >
//                 Create Check Up
//               </button>
//               <button
//                 onClick={closeDetailedView}
//                 className="bg-gray-300 text-gray-800 px-4 py-2 rounded"
//               >
//                 Close
//               </button>
//             </div>
//           </div>
//         </div>
//       )}
//     </div>
//   );
// };