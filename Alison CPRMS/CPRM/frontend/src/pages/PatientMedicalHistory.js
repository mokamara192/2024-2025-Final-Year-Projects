import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom'; // Import useNavigate
import MedicalHistoryService from '../utils/medical_history';
import { 
  ClipboardDocumentListIcon, 
  UserCircleIcon,
  CalendarIcon,
  UserIcon,
  BuildingOfficeIcon,
  ShieldCheckIcon,
  ShieldExclamationIcon
} from '@heroicons/react/24/outline';

const PatientMedicalHistory = () => {
  const [medicalHistory, setMedicalHistory] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);
  
    const navigate = useNavigate(); // Initialize navigate
  
    useEffect(() => {
      const fetchMedicalHistory = async () => {
        try {
          setLoading(true);
          const data = await MedicalHistoryService.getPatientMedicalHistory();
          setMedicalHistory(data);
        } catch (err) {
          setError('Failed to load medical history.');
        } finally {
          setLoading(false);
        }
      };
      fetchMedicalHistory();
    }, []);
  
    const toggleSecure = async (checkupId) => {
      try {
        const updatedRecord = await MedicalHistoryService.toggleSecureStatus(checkupId);
        setMedicalHistory((prev) =>
          prev.map((record) =>
            record.checkup_id === checkupId ? { ...record, secure: updatedRecord.secure } : record
          )
        );
      } catch (err) {
        alert('Failed to update secure status.');
      }
    };

  if (loading) {
    return (
      <div className="flex items-center justify-center min-h-screen">
        <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-500" />
      </div>
    );
  }

  if (error) {
    return (
      <div className="flex items-center justify-center min-h-screen">
        <div className="text-red-500 bg-red-50 px-4 py-3 rounded-lg">{error}</div>
      </div>
    );
  }

  return (
    <div className="max-w-7xl mx-auto p-6 space-y-6">
      {/* Header Section */}
      <div className="flex items-center justify-between">
        <div className="flex items-center gap-3">
          <ClipboardDocumentListIcon className="h-8 w-8 text-blue-600" />
          <h1 className="text-2xl font-semibold text-gray-900">Medical History</h1>
        </div>
      </div>


      {/* Medical Records Grid */}
      <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
        {medicalHistory.map((record) => (
          <div
            key={record.checkup_id}
            onClick={() => navigate(`/details/${record.checkup_id}`)}
            className="bg-white rounded-xl shadow-sm border border-gray-200 hover:shadow-md transition-all cursor-pointer group"
          >
            <div className="p-6 space-y-4">
              {/* Header */}
              <div className="flex items-start justify-between">
                <div className="space-y-1">
                  <div className="font-medium text-gray-900">{record.diagnosis || 'No Diagnosis'}</div>
                  <div className="text-sm text-gray-500">{record.status}</div>
                </div>
                <button
                  onClick={(e) => {
                    e.stopPropagation();
                    toggleSecure(record.checkup_id);
                  }}
                  className={`inline-flex items-center gap-1.5 px-3 py-1.5 rounded-full text-sm font-medium transition-colors
                    ${record.secure 
                      ? 'bg-red-50 text-red-600 hover:bg-red-100' 
                      : 'bg-green-50 text-green-600 hover:bg-green-100'
                    }`}
                >
                  {record.secure ? (
                    <ShieldExclamationIcon className="h-4 w-4" />
                  ) : (
                    <ShieldCheckIcon className="h-4 w-4" />
                  )}
                  {record.secure ? 'Unsecure' : 'Secure'}
                </button>
              </div>

              {/* Details */}
              <div className="grid grid-cols-2 gap-4">
                <div className="flex items-center gap-2 text-gray-600">
                  <CalendarIcon className="h-4 w-4" />
                  <span className="text-sm">
                    {new Date(record.date).toLocaleDateString()}
                  </span>
                </div>
                <div className="flex items-center gap-2 text-gray-600">
                  <UserIcon className="h-4 w-4" />
                  <span className="text-sm">{record.doctor_name}</span>
                </div>
                <div className="flex items-center gap-2 text-gray-600 col-span-2">
                  <BuildingOfficeIcon className="h-4 w-4" />
                  <span className="text-sm">{record.hospital_name}</span>
                </div>
              </div>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default PatientMedicalHistory;





// import React, { useEffect, useState } from 'react';
// import { useNavigate } from 'react-router-dom'; // Import useNavigate
// import MedicalHistoryService from '../utils/medical_history';

// const PatientMedicalHistory = () => {
//   const [medicalHistory, setMedicalHistory] = useState([]);
//   const [loading, setLoading] = useState(true);
//   const [error, setError] = useState(null);

//   const navigate = useNavigate(); // Initialize navigate

//   useEffect(() => {
//     const fetchMedicalHistory = async () => {
//       try {
//         setLoading(true);
//         const data = await MedicalHistoryService.getPatientMedicalHistory();
//         setMedicalHistory(data);
//       } catch (err) {
//         setError('Failed to load medical history.');
//       } finally {
//         setLoading(false);
//       }
//     };
//     fetchMedicalHistory();
//   }, []);

//   const toggleSecure = async (checkupId) => {
//     try {
//       const updatedRecord = await MedicalHistoryService.toggleSecureStatus(checkupId);
//       setMedicalHistory((prev) =>
//         prev.map((record) =>
//           record.checkup_id === checkupId ? { ...record, secure: updatedRecord.secure } : record
//         )
//       );
//     } catch (err) {
//       alert('Failed to update secure status.');
//     }
//   };

//   if (loading) return <p>Loading...</p>;
//   if (error) return <p>{error}</p>;

//   return (
//     <div className="p-6">
//       <h1 className="text-2xl font-bold mb-4">Patient Medical History</h1>
//       <div className="mb-6">
//         <p><strong>Full Name:</strong> John Doe</p>
//         <p><strong>Blood Type:</strong> O+</p>
//         <p><strong>Medical Info:</strong> No known allergies</p>
//       </div>

//       <div className="grid grid-cols-2 gap-4">
//         {medicalHistory.map((record) => (
//           <div
//             key={record.checkup_id}
//             className="border p-4 rounded shadow-sm hover:shadow-md transition"
//             onClick={() => navigate(`/details/${record.checkup_id}`)} // Navigate to detailed view
//           >
//             <p><strong>Diagnosis:</strong> {record.diagnosis || 'N/A'}</p>
//             <p><strong>Date:</strong> {new Date(record.date).toLocaleDateString()}</p>
//             <p><strong>Doctor:</strong> {record.doctor_name}</p>
//             <p><strong>Hospital:</strong> {record.hospital_name}</p>
//             <p><strong>Status:</strong> {record.status}</p>
//             <button
//               className={`mt-2 px-4 py-2 text-sm rounded ${
//                 record.secure ? 'bg-red-500 text-white' : 'bg-green-500 text-white'
//               }`}
//               onClick={(e) => {
//                 e.stopPropagation(); // Prevent navigating when toggling
//                 toggleSecure(record.checkup_id);
//               }}
//             >
//               {record.secure ? 'Unsecure' : 'Secure'}
//             </button>
//           </div>
//         ))}
//       </div>
//     </div>
//   );
// };

// export default PatientMedicalHistory;


