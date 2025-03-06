import { useState } from "react";
import axios from "axios";
import { useNavigate } from 'react-router-dom';

import { 
  UserIcon, 
  LockClosedIcon, 
  XMarkIcon,
  KeyIcon,
  CheckCircleIcon,
  ExclamationCircleIcon
} from "@heroicons/react/24/outline";

const Input = ({ icon: Icon, label, type, value, onChange, placeholder }) => (
  <div className="mb-4">
    <label className="block text-sm font-medium text-gray-700 mb-1">{label}</label>
    <div className="relative">
      <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
        <Icon className="h-5 w-5 text-gray-400" />
      </div>
      <input
        type={type}
        value={value}
        onChange={onChange}
        placeholder={placeholder}
        className="block w-full pl-10 pr-3 py-2 border border-gray-200 rounded-lg focus:outline-none focus:ring-2 focus:ring-sky-500 focus:border-transparent transition-all duration-200"
      />
    </div>
  </div>
);

const UpdateUsernamePassword = ({ onClose }) => {
  const [username, setUsername] = useState("");
  const [currentPassword, setCurrentPassword] = useState("");
  const [newPassword, setNewPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);
  const [success, setSuccess] = useState(null);
  const navigate = useNavigate();

  const handleUpdate = async () => {
    if (!username || !currentPassword || !newPassword || !confirmPassword) {
      setError("Please fill in all fields");
      return;
    }

    if (newPassword !== confirmPassword) {
      setError("New passwords do not match");
      return;
    }

    if (newPassword.length < 8) {
      setError("New password must be at least 8 characters long");
      return;
    }

    setLoading(true);
    setError(null);
    setSuccess(null);

    try {
      const response = await axios.post(
        "http://localhost:8000/api/update-username_password/",
        {
          username: username.trim(),
          current_password: currentPassword,
          new_password: newPassword,
        },
        {
          headers: {
            Authorization: `Bearer ${
              JSON.parse(localStorage.getItem("user")).accessToken
            }`,
          },
        }
      );

      setSuccess("Credentials updated successfully!");
      // Clear form after successful update
      setUsername("");
      setCurrentPassword("");
      setNewPassword("");
      setConfirmPassword("");
      
      // Close modal after a delay
      setTimeout(() => {
        navigate('/home');
        // onClose();
      }, 2000);
    } catch (err) {
      setError(
        err.response?.data?.message ||
          "Failed to update credentials. Please check your current password."
      );
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="fixed inset-0 bg-black/50 backdrop-blur-sm flex justify-center items-center p-4 z-50">
      <div className="bg-white rounded-xl shadow-xl w-full max-w-md relative transform transition-all">
        {/* Header */}
        <div className="flex items-center justify-between p-6 border-b border-gray-100">
          <h2 className="text-xl font-semibold text-gray-800">
            Update Credentials
          </h2>
          <button
            onClick={onClose}
            className="text-gray-400 hover:text-gray-500 transition-colors"
          >
            <XMarkIcon className="h-6 w-6" />
          </button>
        </div>

        {/* Form Content */}
        <div className="p-6 space-y-4">
          {/* Status Messages */}
          {error && (
            <div className="bg-red-50 text-red-600 px-4 py-3 rounded-lg flex items-center gap-2">
              <ExclamationCircleIcon className="h-5 w-5 text-red-500" />
              <p className="text-sm">{error}</p>
            </div>
          )}

          {success && (
            <div className="bg-green-50 text-green-600 px-4 py-3 rounded-lg flex items-center gap-2">
              <CheckCircleIcon className="h-5 w-5 text-green-500" />
              <p className="text-sm">{success}</p>
            </div>
          )}

          {/* Form Fields */}
          <Input
            icon={UserIcon}
            label="Username"
            type="text"
            value={username}
            onChange={(e) => setUsername(e.target.value)}
            placeholder="Enter new username"
          />

          <Input
            icon={KeyIcon}
            label="Current Password"
            type="password"
            value={currentPassword}
            onChange={(e) => setCurrentPassword(e.target.value)}
            placeholder="Enter current password"
          />

          <Input
            icon={LockClosedIcon}
            label="New Password"
            type="password"
            value={newPassword}
            onChange={(e) => setNewPassword(e.target.value)}
            placeholder="Enter new password"
          />

          <Input
            icon={LockClosedIcon}
            label="Confirm New Password"
            type="password"
            value={confirmPassword}
            onChange={(e) => setConfirmPassword(e.target.value)}
            placeholder="Confirm new password"
          />
        </div>

        {/* Footer */}
        <div className="px-6 py-4 bg-gray-50 rounded-b-xl flex justify-end gap-3">
          <button
            onClick={onClose}
            className="px-4 py-2 text-sm font-medium text-gray-700 hover:bg-gray-100 rounded-lg transition-colors"
          >
            Cancel
          </button>
          <button
            onClick={handleUpdate}
            disabled={loading}
            className="px-4 py-2 text-sm font-medium text-white bg-sky-500 hover:bg-sky-600 rounded-lg transition-colors disabled:opacity-50 disabled:cursor-not-allowed flex items-center gap-2"
          >
            {loading ? (
              <>
                <svg
                  className="animate-spin h-4 w-4"
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                >
                  <circle
                    className="opacity-25"
                    cx="12"
                    cy="12"
                    r="10"
                    stroke="currentColor"
                    strokeWidth="4"
                  ></circle>
                  <path
                    className="opacity-75"
                    fill="currentColor"
                    d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4zm2 5.291A7.962 7.962 0 014 12H0c0 3.042 1.135 5.824 3 7.938l3-2.647z"
                  ></path>
                </svg>
                <span>Updating...</span>
              </>
            ) : (
              "Update Credentials"
            )}
          </button>
        </div>
      </div>
    </div>
  );
};

export default UpdateUsernamePassword;


// import { useState } from "react";
// import axios from "axios";

// const UpdateUsernamePassword = ({ onClose }) => {
//     const [username, setUsername] = useState("");
//     const [currentPassword, setCurrentPassword] = useState("");
//     const [newPassword, setNewPassword] = useState("");
//     const [confirmPassword, setConfirmPassword] = useState("");
//     const [loading, setLoading] = useState(false);
//     const [error, setError] = useState(null);
//     const [success, setSuccess] = useState(null);
    
//     const handleUpdate = async () => {
//         if (newPassword !== confirmPassword) {
//             setError("New passwords do not match");
//             return;
//         }

//         setLoading(true);
//         setError(null);
//         setSuccess(null);
        
//         try {
//             const response = await axios.post("http://localhost:8000/api/update-username_password/", {
//                 username: username.trim(),
//                 current_password: currentPassword,
//                 new_password: newPassword,
//             }, {
//                 headers: { Authorization: `Bearer ${JSON.parse(localStorage.getItem("user")).accessToken}` }
//             });
            
//             setSuccess("Password updated successfully");
//             setUsername("");
//             setCurrentPassword("");
//             setNewPassword("");
//             setConfirmPassword("");
//         } catch (err) {
//             setError("Failed to update credentials. Please check your current password.");
//         } finally {
//             setLoading(false);
//         }
//     };
    
//     return (
//         <div className="fixed inset-0 bg-black bg-opacity-50 flex justify-center items-center">
//             <div className="bg-white p-6 rounded-lg shadow-lg w-96">
//                 <h2 className="text-lg font-bold mb-4">Update Username & Password</h2>
//                 {error && <p className="text-red-500">{error}</p>}
//                 {success && <p className="text-green-500">{success}</p>}
//                 <label className="block mb-2">Username</label>
//                 <input 
//                     type="text" 
//                     value={username} 
//                     onChange={(e) => setUsername(e.target.value)}
//                     className="border p-2 w-full rounded-lg mb-4"
//                 />
//                 <label className="block mb-2">Current Password</label>
//                 <input 
//                     type="password" 
//                     value={currentPassword} 
//                     onChange={(e) => setCurrentPassword(e.target.value)}
//                     className="border p-2 w-full rounded-lg mb-4"
//                 />
//                 <label className="block mb-2">New Password</label>
//                 <input 
//                     type="password" 
//                     value={newPassword} 
//                     onChange={(e) => setNewPassword(e.target.value)}
//                     className="border p-2 w-full rounded-lg mb-4"
//                 />
//                 <label className="block mb-2">Confirm New Password</label>
//                 <input 
//                     type="password" 
//                     value={confirmPassword} 
//                     onChange={(e) => setConfirmPassword(e.target.value)}
//                     className="border p-2 w-full rounded-lg mb-4"
//                 />
//                 <div className="flex justify-end space-x-2">
//                     <button onClick={onClose} className="bg-gray-400 text-white px-4 py-2 rounded-lg">Cancel</button>
//                     <button onClick={handleUpdate} disabled={loading} className="bg-blue-500 text-white px-4 py-2 rounded-lg">
//                         {loading ? "Updating..." : "Save"}
//                     </button>
//                 </div>
//             </div>
//         </div>
//     );
// };

// export default UpdateUsernamePassword;
