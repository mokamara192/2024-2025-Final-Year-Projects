// src/pages/DoctorAccess.js
import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { 
  KeyIcon, 
  ShieldCheckIcon, 
  UserIcon,
  LockClosedIcon,
  ExclamationCircleIcon
} from '@heroicons/react/24/outline';
import axios from 'axios';

const API_URL = 'http://localhost:8000/api/';
const DoctorAccess = () => {
  const [error, setError] = useState(null);

  
    const handleRequestAccess = async () => {
      const user = JSON.parse(localStorage.getItem('user'));
      const token = user?.accessToken;
      const profile_id=user?.profileId
      console.log(profile_id)
      try {
        setError(null);
        const response = await axios.post(
          `${API_URL}request-access/`,
          {
            patient_id: patientId, // Ensure patientId is set correctly
            doctor_id:profile_id,
          },
          {
            headers: { Authorization: `Bearer ${token}` }, // Include the Authorization header
          }
        );
        alert(response.data.message || 'Access request sent to the hospital admin.');
      } catch (err) {
        setError('An error occurred while sending the access request.');
      }
    };

  return (
    <div className="min-h-screen bg-gray-50 py-12 px-4 sm:px-6 lg:px-8">
      <div className="max-w-md mx-auto bg-white rounded-xl shadow-md overflow-hidden md:max-w-2xl p-8">
        <div className="text-center mb-8">
          <ShieldCheckIcon className="mx-auto h-12 w-12 text-blue-500" />
          <h2 className="mt-4 text-3xl font-extrabold text-gray-900">
            Medical Records Access
          </h2>
          <p className="mt-2 text-sm text-gray-600">
            Secure access to patient medical records
          </p>
        </div>

        {error && (
          <div className="mb-6 bg-red-50 p-4 rounded-lg flex items-center">
            <ExclamationCircleIcon className="h-5 w-5 text-red-400 mr-2" />
            <p className="text-sm text-red-600">{error}</p>
          </div>
        )}

        <div className="space-y-6">
          {/* Patient ID Input */}
          <div>
            <label className="block text-sm font-medium text-gray-700">
              Patient ID
            </label>
            <div className="mt-1 relative rounded-md shadow-sm">
              <div className="absolute inset-y-0 left-0 pl-3 flex items-center">
                <UserIcon className="h-5 w-5 text-gray-400" />
              </div>
              <input
                type="text"
                value={patientId}
                onChange={(e) => setPatientId(e.target.value)}
                className="pl-10 block w-full border-gray-300 rounded-md focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                placeholder="Enter Patient ID"
              />
            </div>
          </div>

          {/* Public Key Section */}
          <div className="bg-gray-50 p-6 rounded-lg">
            <h3 className="text-lg font-medium text-gray-900 mb-4 flex items-center">
              <KeyIcon className="h-5 w-5 text-blue-500 mr-2" />
              Public Access
            </h3>
            <div className="space-y-4">
              <input
                type="text"
                value={publicKey}
                onChange={(e) => setPublicKey(e.target.value)}
                className="block w-full border-gray-300 rounded-md focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                placeholder="Enter Public Key"
              />
              <button
                onClick={handlePublicAccess}
                className="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-blue-600 hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500"
              >
                Access Medical Records
              </button>
            </div>
          </div>

          {/* Secret Key Section */}
          <div className="bg-gray-50 p-6 rounded-lg">
            <h3 className="text-lg font-medium text-gray-900 mb-4 flex items-center">
              <LockClosedIcon className="h-5 w-5 text-green-500 mr-2" />
              Secured Access
            </h3>
            <div className="space-y-4">
              <input
                type="text"
                value={secretKey}
                onChange={(e) => setSecretKey(e.target.value)}
                className="block w-full border-gray-300 rounded-md focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                placeholder="Enter Secret Key"
              />
              <button
                onClick={handleSecretKeyAccess}
                className="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-green-600 hover:bg-green-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-green-500"
              >
                Access Secured Records
              </button>
            </div>
          </div>

          {/* Request Access Button */}
          <div className="pt-4">
            <button
              onClick={handleRequestAccess}
              className="w-full flex justify-center py-3 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-gray-700 bg-gray-100 hover:bg-gray-200 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-gray-500"
            >
              Request Access from Admin
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default DoctorAccess;





















// import React, { useState } from 'react';
// import { useNavigate } from 'react-router-dom';
// import axios from 'axios';

// const API_URL = 'http://localhost:8000/api/';

// const DoctorAccess = () => {
//   const [patientId, setPatientId] = useState('');
//   const [publicKey, setPublicKey] = useState('');
//   const [secretKey, setSecretKey] = useState('');
//   const [error, setError] = useState(null);
//   const navigate = useNavigate();

// const handlePublicAccess = async () => {
//   console.log('patientId:', patientId, 'publicKey:', publicKey);
//   try {
//     setError(null);
//     const user = JSON.parse(localStorage.getItem('user')); // Retrieve user data from localStorage
//     const token = user?.accessToken;

//     const response = await axios.post(
//       `${API_URL}validate-public-key/`,
//       {
//         patient_id: patientId, // Ensure patientId is set correctly
//         public_key: publicKey, // Ensure publicKey is set correctly
//       },
//       {
//         headers: { Authorization: `Bearer ${token}` }, // Include the Authorization header
//       }
//     );

//     if (response.data.valid) {
//       navigate(`/doctor-history/${patientId}`);
//     } else {
//       setError(response.data.error || 'Invalid Patient ID or Public Key.');
//     }
//   } catch (err) {
//     setError('An error occurred while validating the public key.');
//   }
// };

//   const handleSecretKeyAccess = async () => {
//     const user = JSON.parse(localStorage.getItem('user'));
//     const token = user?.accessToken;
//     const profile_id=user?.profileId

//     try {
//       setError(null);
//       const response = await axios.post(`${API_URL}validate-secret-key/`, 
//         {
//         patient_id: patientId,
//         secret_key: secretKey,
//         doctor_id:profile_id,
//       },
//       {
//         headers: { Authorization: `Bearer ${token}` }, // Include the Authorization header
//       }
//     );

//       if (response.data.valid) {
//         navigate(`/doctor-history/${patientId}`);
//       } else {
//         setError(response.data.error || 'Invalid Secret Key.');
//       }
//     } catch (err) {
//       setError('An error occurred while validating the secret key.');
//     }
//   };



//   const handleRequestAccess = async () => {
//     const user = JSON.parse(localStorage.getItem('user'));
//     const token = user?.accessToken;
//     const profile_id=user?.profileId
//     console.log(profile_id)
//     try {
//       setError(null);
//       const response = await axios.post(
//         `${API_URL}request-access/`,
//         {
//           patient_id: patientId, // Ensure patientId is set correctly
//           doctor_id:profile_id,
//         },
//         {
//           headers: { Authorization: `Bearer ${token}` }, // Include the Authorization header
//         }
//       );
//       alert(response.data.message || 'Access request sent to the hospital admin.');
//     } catch (err) {
//       setError('An error occurred while sending the access request.');
//     }
//   };

//   return (
//     <div className="p-6 max-w-lg mx-auto">
//       <h1 className="text-2xl font-bold mb-6">Doctor Access</h1>

//       {error && <p className="text-red-500 mb-4">{error}</p>}

//       <div className="mb-6">
//         <label className="block mb-2 font-semibold">Patient ID:</label>
//         <input
//           type="text"
//           value={patientId}
//           onChange={(e) => setPatientId(e.target.value)}
//           className="w-full p-2 border rounded"
//           placeholder="Enter Patient ID"
//         />
//       </div>

//       <div className="mb-6">
//         <label className="block mb-2 font-semibold">Public Key:</label>
//         <input
//           type="text"
//           value={publicKey}
//           onChange={(e) => setPublicKey(e.target.value)}
//           className="w-full p-2 border rounded"
//           placeholder="Enter Public Key"
//         />
//         <button
//           className="mt-4 w-full bg-blue-500 text-white p-2 rounded hover:bg-blue-600"
//           onClick={handlePublicAccess}
//         >
//           Access Medical Records
//         </button>
//       </div>

//       <div className="mb-6">
//         <label className="block mb-2 font-semibold">Secret Key:</label>
//         <input
//           type="text"
//           value={secretKey}
//           onChange={(e) => setSecretKey(e.target.value)}
//           className="w-full p-2 border rounded"
//           placeholder="Enter Secret Key"
//         />
//         <button
//           className="mt-4 w-full bg-green-500 text-white p-2 rounded hover:bg-green-600"
//           onClick={handleSecretKeyAccess}
//         >
//           Access Secured Records
//         </button>
//       </div>

//       <div className="mb-6">
//         <button
//           className="w-full bg-yellow-500 text-white p-2 rounded hover:bg-yellow-600"
//           onClick={handleRequestAccess}
//         >
//           Request Access from Admin
//         </button>
//       </div>
//     </div>
//   );
// };

// export default DoctorAccess;
