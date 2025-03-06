import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import AuthService from "../services/auth.service";
import UserService from "../services/userService";
import DynamicProfileForm from "./DynamicProfileForm";
import { populateGroupDropdown } from "../utils/fetch_group";
import axios from "axios";

const API_URL = "http://localhost:8000/api/";

const determineProfileType = (group) => {
  switch (group) {
    case "Super Admin":
      return "super_admin";
    case "Hospital Head":
      return "hospital_head";
    case "Patient":
      return "patient";
    case "Hospital Admin":
    case "Doctor":
    case "Nurse":
    case "Clerk":
      return "staff";
    default:
      return null;
  }
};

const determineEndpoint = (profileType) => {
  switch (profileType) {
    case 'hospital_head':
      return `${API_URL}hospital-head-profiles/create`;
    case 'staff':
      return `${API_URL}staff-profiles/create/`;
    case 'patient':
      return `${API_URL}${profileType}/create/`;
    case 'super_admin':
      return `${API_URL}super-admin-profiles/create/`;
    default:
      throw new Error('Invalid profile type');
  }
};

const CreateUserWithProfile = () => {
  const navigate = useNavigate();
  const [groupOptions, setGroupOptions] = useState([]);
  const [selectedGroup, setSelectedGroup] = useState(null);
  const [userFormData, setUserFormData] = useState({
    username: "",
    email: "",
    password: "",
    confirmPassword: "",
    is_active: true,
  });
  const [profileData, setProfileData] = useState({});
  const [profilePicture, setProfilePicture] = useState(null);
  const [errors, setErrors] = useState({});
  const [isLoading, setIsLoading] = useState(false);
  const [newUserId, setNewUserId] = useState(null);
  const [showValidationDialog, setShowValidationDialog] = useState(false);
  const [validationMessages, setValidationMessages] = useState([]);
  const [profileFormValid, setProfileFormValid] = useState(false);

  useEffect(() => {
    const fetchGroups = async () => {
      try {
        const groups = await populateGroupDropdown();
        setGroupOptions(groups);
      } catch (error) {
        console.error("Error fetching groups:", error);
      }
    };
    fetchGroups();
  }, []);

  const validateUserForm = () => {
    const newErrors = {};
    const errorMessages = [];

    // Username validation - no spaces or special characters
    const usernameRegex = /^[a-zA-Z0-9]+$/;
    if (!userFormData.username.trim()) {
      newErrors.username = "Username is required";
      errorMessages.push("Username is required");
    } else if (!usernameRegex.test(userFormData.username)) {
      newErrors.username = "Username can only contain letters and numbers";
      errorMessages.push("Username can only contain letters and numbers");
    }

    // Email validation
    const emailRegex = /\S+@\S+\.\S+/;
    if (!userFormData.email.trim()) {
      newErrors.email = "Email is required";
      errorMessages.push("Email is required");
    } else if (!emailRegex.test(userFormData.email)) {
      newErrors.email = "Please enter a valid email address";
      errorMessages.push("Please enter a valid email address");
    }

    // Password validation - alphanumeric with at least one symbol
    const passwordRegex = /^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$/;
    if (!userFormData.password) {
      newErrors.password = "Password is required";
      errorMessages.push("Password is required");
    } else if (!passwordRegex.test(userFormData.password)) {
      newErrors.password = "Password must contain at least 8 characters, including letters, numbers, and one special character";
      errorMessages.push("Password must contain at least 8 characters, including letters, numbers, and one special character");
    }

    if (!userFormData.confirmPassword) {
      newErrors.confirmPassword = "Please confirm your password";
      errorMessages.push("Please confirm your password");
    } else if (userFormData.password !== userFormData.confirmPassword) {
      newErrors.confirmPassword = "Passwords do not match";
      errorMessages.push("Passwords do not match");
    }

    if (!selectedGroup) {
      newErrors.group = "Group selection is required";
      errorMessages.push("Group selection is required");
    }

    setErrors(newErrors);
    setValidationMessages(errorMessages);
    
    if (errorMessages.length > 0) {
      setShowValidationDialog(true);
      return false;
    }
    return true;
  };

  const handleUserInputChange = (e) => {
    const { name, value } = e.target;
    let processedValue = value;

    // Real-time validation and formatting
    if (name === 'username') {
      processedValue = value.replace(/[^a-zA-Z0-9]/g, ''); // Remove special characters and spaces
    }

    setUserFormData((prev) => ({ ...prev, [name]: processedValue }));
  };

  const handleGroupSelect = (group) => {
    setSelectedGroup(group);
    setProfileData({}); // Reset profile data when group changes
    setProfileFormValid(false); // Reset profile validation state
  };

  const validateProfileData = (profileType, data) => {
    const errorMessages = [];
    
    // Basic required fields for all profile types
    if (!data.first_name || !data.first_name.trim()) {
      errorMessages.push("First name is required");
    }
    
    if (!data.last_name || !data.last_name.trim()) {
      errorMessages.push("Last name is required");
    }
    
    if (!data.phone_number || !data.phone_number.trim()) {
      errorMessages.push("Phone number is required");
    }

    // Additional validation for patient profiles
    if (profileType === 'patient') {
      if (!data.date_of_birth) {
        errorMessages.push("Date of birth is required for patients");
      }
      if (!data.gender) {
        errorMessages.push("Gender is required for patients");
      }
      if (!data.emergency_contact_name || !data.emergency_contact_name.trim()) {
        errorMessages.push("Emergency contact name is required for patients");
      }
      if (!data.emergency_contact_number || !data.emergency_contact_number.trim()) {
        errorMessages.push("Emergency contact number is required for patients");
      }
      if (!data.nin || !data.nin.trim()) {
        errorMessages.push("National ID Number (NIN) is required for patients");
      }
    }

    // Additional validation for staff profiles
    if (profileType === 'staff') {
      if (!data.hospital_id) {
        errorMessages.push("Hospital selection is required for staff");
      }
    }

    if (errorMessages.length > 0) {
      setValidationMessages(errorMessages);
      setShowValidationDialog(true);
      return false;
    }
    
    return true;
  };

  const handleProfileDataUpdate = (newData) => {
    setProfileData(newData);
    setProfileFormValid(true); // Set to true when dynamic form data is updated
  };

  const createProfile = async (profileData, profileType) => {
    const user = AuthService.getCurrentUser();
    if (!user || !user.accessToken) {
      throw new Error("User not authenticated");
    }

    const formattedProfileType = determineProfileType(profileType);
    if (!formattedProfileType) {
      throw new Error("Invalid profile type");
    }

    const endpoint = determineEndpoint(formattedProfileType);

    const formData = new FormData();
    Object.entries(profileData).forEach(([key, value]) => {
      if (value !== null && value !== undefined) {
        formData.append(key, value);
      }
    });

    if (profilePicture) {
      formData.append("profile_picture", profilePicture);
    }

    console.log("📝 Final FormData Before Sending:");
    for (let [key, value] of formData.entries()) {
      console.log(`${key}:`, value);
    }

    try {
      const response = await axios.post(endpoint, formData, {
        headers: { Authorization: `Bearer ${user.accessToken}` },
      });
      return response.data;
    } catch (error) {
      console.error("Error creating profile:", error.response?.data || error.message);
      throw error;
    }
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    
    // First validate user form
    if (!validateUserForm()) {
      return;
    }

    // Then validate profile data if a group is selected
    if (selectedGroup) {
      const profileType = determineProfileType(selectedGroup.label);
      if (!validateProfileData(profileType, profileData)) {
        return;
      }
    } else {
      setValidationMessages(['Please select a user group']);
      setShowValidationDialog(true);
      return;
    }

    setIsLoading(true);
    try {
      // Step 1: Create the user
      const userData = { ...userFormData, group_id: selectedGroup.value };
      const userResponse = await UserService.createUser(userData);
      const userId = userResponse.id;
      setNewUserId(userId);

      // Step 2: Create the profile with a small delay to ensure user is created
      const fullProfileData = { user_id: userId, ...profileData };
      await createProfile(fullProfileData, selectedGroup.label);
      
      // Step 3: Update user profile status
      await AuthService.updateUserProfileStatus(userId, true);
      
      // Navigate to home page on success
      navigate("/home");
    } catch (error) {
      console.error("Error creating user or profile:", error);
      setErrors((prev) => ({ ...prev, submit: "User or profile creation failed" }));
      setValidationMessages([`Failed to create user or profile: ${error.response?.data?.message || error.message}`]);
      setShowValidationDialog(true);
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <div className="max-w-2xl mx-auto p-6 bg-white shadow-md rounded-md">
      <h2 className="text-2xl font-bold text-gray-900 mb-4">Create User & Profile</h2>
      <form onSubmit={handleSubmit} className="space-y-4">
        <div className="mb-4">
          <input 
            name="username" 
            placeholder="Username (letters and numbers only)" 
            value={userFormData.username}
            onChange={handleUserInputChange} 
            className="w-full p-2 border rounded" 
          />
          {errors.username && <p className="text-red-500 text-sm mt-1">{errors.username}</p>}
        </div>

        <div className="mb-4">
          <input 
            name="email" 
            type="email" 
            placeholder="Email" 
            value={userFormData.email}
            onChange={handleUserInputChange} 
            className="w-full p-2 border rounded" 
          />
          {errors.email && <p className="text-red-500 text-sm mt-1">{errors.email}</p>}
        </div>

        <div className="mb-4">
          <input 
            name="password" 
            type="password" 
            placeholder="Password (min 8 chars, include letters, numbers, and special char)" 
            value={userFormData.password}
            onChange={handleUserInputChange} 
            className="w-full p-2 border rounded" 
          />
          {errors.password && <p className="text-red-500 text-sm mt-1">{errors.password}</p>}
        </div>

        <div className="mb-4">
          <input 
            name="confirmPassword" 
            type="password" 
            placeholder="Confirm Password" 
            value={userFormData.confirmPassword}
            onChange={handleUserInputChange} 
            className="w-full p-2 border rounded" 
          />
          {errors.confirmPassword && <p className="text-red-500 text-sm mt-1">{errors.confirmPassword}</p>}
        </div>

        <div className="flex flex-wrap gap-2">
          {groupOptions.map((group) => (
            <button
              key={group.value}
              type="button"
              className={`px-4 py-2 border rounded ${
                selectedGroup?.value === group.value 
                  ? "bg-blue-500 text-white" 
                  : "bg-gray-200"
              }`}
              onClick={() => handleGroupSelect(group)}
            >
              {group.label}
            </button>
          ))}
        </div>
        {errors.group && <p className="text-red-500 text-sm mt-1">{errors.group}</p>}

        {selectedGroup && (
          <DynamicProfileForm 
            profileType={determineProfileType(selectedGroup.label)} 
            targetUser={{ id: newUserId }} 
            setProfileData={handleProfileDataUpdate} 
            setProfilePicture={setProfilePicture} 
          />
        )}

        <button 
          type="submit" 
          className="w-full bg-green-500 text-white p-2 rounded hover:bg-green-600 transition-colors"
          disabled={isLoading}
        >
          {isLoading ? "Processing..." : "Create User & Profile"}
        </button>

        {errors.submit && (
          <p className="text-red-500 text-center mt-2">{errors.submit}</p>
        )}
      </form>

      {showValidationDialog && validationMessages.length > 0 && (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50">
          <div className="bg-white rounded-lg p-6 max-w-md w-full mx-4">
            <h3 className="text-xl font-bold mb-4">Please Fix the Following Errors:</h3>
            <ul className="list-disc pl-5 space-y-1">
              {validationMessages.map((message, index) => (
                <li key={index} className="text-red-500">{message}</li>
              ))}
            </ul>
            <button
              onClick={() => setShowValidationDialog(false)}
              className="mt-4 px-4 py-2 bg-blue-500 text-white rounded hover:bg-blue-600 w-full"
            >
              Close
            </button>
          </div>
        </div>
      )}
    </div>
  );
};

export default CreateUserWithProfile;


// import React, { useState, useEffect } from "react";
// import { useNavigate } from "react-router-dom";
// import AuthService from "../services/auth.service";
// import UserService from "../services/userService";
// import DynamicProfileForm from "./DynamicProfileForm";
// import { populateGroupDropdown } from "../utils/fetch_group";
// import axios from "axios";

// const API_URL = "http://localhost:8000/api/";

// const determineProfileType = (group) => {
//   switch (group) {
//     case "Super Admin":
//       return "super_admin";
//     case "Hospital Head":
//       return "hospital_head";
//     case "Patient":
//       return "patient";
//     case "Hospital Admin":
//     case "Doctor":
//     case "Nurse":
//     case "Clerk":
//       return "staff";
//     default:
//       return null;
//   }
// };

// const CreateUserWithProfile = () => {
//   const navigate = useNavigate();
//   const [groupOptions, setGroupOptions] = useState([]);
//   const [selectedGroup, setSelectedGroup] = useState(null);
//   const [userFormData, setUserFormData] = useState({
//     username: "",
//     email: "",
//     password: "",
//     confirmPassword: "",
//     is_active: true,
//   });
//   const [profileData, setProfileData] = useState({});
//   const [profilePicture, setProfilePicture] = useState(null);
//   const [errors, setErrors] = useState({});
//   const [isLoading, setIsLoading] = useState(false);
//   const [newUserId, setNewUserId] = useState(null);
//   const [showValidationDialog, setShowValidationDialog] = useState(false);
//   const [validationMessages, setValidationMessages] = useState([]);

//   useEffect(() => {
//     const fetchGroups = async () => {
//       try {
//         const groups = await populateGroupDropdown();
//         setGroupOptions(groups);
//       } catch (error) {
//         console.error("Error fetching groups:", error);
//       }
//     };
//     fetchGroups();
//   }, []);

//   const validateUserForm = () => {
//     const newErrors = {};
//     const errorMessages = [];

//     // Username validation - no spaces or special characters
//     const usernameRegex = /^[a-zA-Z0-9]+$/;
//     if (!userFormData.username.trim()) {
//       newErrors.username = "Username is required";
//       errorMessages.push("Username is required");
//     } else if (!usernameRegex.test(userFormData.username)) {
//       newErrors.username = "Username can only contain letters and numbers";
//       errorMessages.push("Username can only contain letters and numbers");
//     }

//     // Email validation
//     const emailRegex = /\S+@\S+\.\S+/;
//     if (!userFormData.email.trim()) {
//       newErrors.email = "Email is required";
//       errorMessages.push("Email is required");
//     } else if (!emailRegex.test(userFormData.email)) {
//       newErrors.email = "Please enter a valid email address";
//       errorMessages.push("Please enter a valid email address");
//     }

//     // Password validation - alphanumeric with at least one symbol
//     const passwordRegex = /^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$/;
//     if (!userFormData.password) {
//       newErrors.password = "Password is required";
//       errorMessages.push("Password is required");
//     } else if (!passwordRegex.test(userFormData.password)) {
//       newErrors.password = "Password must contain at least 8 characters, including letters, numbers, and one special character";
//       errorMessages.push("Password must contain at least 8 characters, including letters, numbers, and one special character");
//     }

//     if (!userFormData.confirmPassword) {
//       newErrors.confirmPassword = "Please confirm your password";
//       errorMessages.push("Please confirm your password");
//     } else if (userFormData.password !== userFormData.confirmPassword) {
//       newErrors.confirmPassword = "Passwords do not match";
//       errorMessages.push("Passwords do not match");
//     }

//     if (!selectedGroup) {
//       newErrors.group = "Group selection is required";
//       errorMessages.push("Group selection is required");
//     }

//     setErrors(newErrors);
//     setValidationMessages(errorMessages);
    
//     if (errorMessages.length > 0) {
//       setShowValidationDialog(true);
//       return false;
//     }
//     return true;
//   };

//   const handleUserInputChange = (e) => {
//     const { name, value } = e.target;
//     let processedValue = value;

//     // Real-time validation and formatting
//     if (name === 'username') {
//       processedValue = value.replace(/[^a-zA-Z0-9]/g, ''); // Remove special characters and spaces
//     }

//     setUserFormData((prev) => ({ ...prev, [name]: processedValue }));
//   };

//   const handleGroupSelect = (group) => {
//     setSelectedGroup(group);
//   };

//   const validateProfileData = (profileType, data) => {
//     // Basic required fields for all profile types
//     if (!data.first_name || !data.last_name || !data.phone_number) {
//       return false;
//     }

//     // Additional validation for patient profiles
//     if (profileType === 'patient') {
//       if (!data.date_of_birth || !data.gender || !data.emergency_contact_name || 
//           !data.emergency_contact_number || !data.nin) {
//         return false;
//       }
//     }

//     // Additional validation for staff profiles
//     if (profileType === 'staff') {
//       if (!data.hospital_id) {
//         return false;
//       }
//     }

//     return true;
//   };

//   const handleSubmit = async (e) => {
//     e.preventDefault();
    
//     // First validate user form
//     if (!validateUserForm()) {
//       return;
//     }

//     // Then validate profile data
//     const profileType = determineProfileType(selectedGroup.label);
//     if (!validateProfileData(profileType, profileData)) {
//       setValidationMessages(['Please fill in all required profile fields']);
//       setShowValidationDialog(true);
//       return;
//     }

//     setIsLoading(true);
//     try {
//       const userData = { ...userFormData, group_id: selectedGroup.value };
//       const userResponse = await UserService.createUser(userData);
//       const userId = userResponse.id;
//       setNewUserId(userId);

//       const fullProfileData = { user_id: userId, ...profileData };
//       await UserService.createProfile(fullProfileData, selectedGroup.label);
//       await AuthService.updateUserProfileStatus(userId, true);
//       navigate("/home");
//     } catch (error) {
//       console.error("Error creating user or profile:", error);
//       setErrors((prev) => ({ ...prev, submit: "User or profile creation failed" }));
//       setValidationMessages(['Failed to create user or profile. Please try again.']);
//       setShowValidationDialog(true);
//     }
//     setIsLoading(false);
//   };

//   // Your existing createProfile function remains the same...

//   return (
//     <div className="max-w-2xl mx-auto p-6 bg-white shadow-md rounded-md">
//       <h2 className="text-2xl font-bold text-gray-900 mb-4">Create User & Profile</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <div className="mb-4">
//           <input 
//             name="username" 
//             placeholder="Username (letters and numbers only)" 
//             value={userFormData.username}
//             onChange={handleUserInputChange} 
//             className="w-full p-2 border rounded" 
//           />
//           {errors.username && <p className="text-red-500 text-sm mt-1">{errors.username}</p>}
//         </div>

//         <div className="mb-4">
//           <input 
//             name="email" 
//             type="email" 
//             placeholder="Email" 
//             value={userFormData.email}
//             onChange={handleUserInputChange} 
//             className="w-full p-2 border rounded" 
//           />
//           {errors.email && <p className="text-red-500 text-sm mt-1">{errors.email}</p>}
//         </div>

//         <div className="mb-4">
//           <input 
//             name="password" 
//             type="password" 
//             placeholder="Password (min 8 chars, include letters, numbers, and special char)" 
//             value={userFormData.password}
//             onChange={handleUserInputChange} 
//             className="w-full p-2 border rounded" 
//           />
//           {errors.password && <p className="text-red-500 text-sm mt-1">{errors.password}</p>}
//         </div>

//         <div className="mb-4">
//           <input 
//             name="confirmPassword" 
//             type="password" 
//             placeholder="Confirm Password" 
//             value={userFormData.confirmPassword}
//             onChange={handleUserInputChange} 
//             className="w-full p-2 border rounded" 
//           />
//           {errors.confirmPassword && <p className="text-red-500 text-sm mt-1">{errors.confirmPassword}</p>}
//         </div>

//         <div className="flex space-x-2">
//           {groupOptions.map((group) => (
//             <button
//               key={group.value}
//               type="button"
//               className={`px-4 py-2 border rounded ${
//                 selectedGroup?.value === group.value 
//                   ? "bg-blue-500 text-white" 
//                   : "bg-gray-200"
//               }`}
//               onClick={() => handleGroupSelect(group)}
//             >
//               {group.label}
//             </button>
//           ))}
//         </div>
//         {errors.group && <p className="text-red-500 text-sm mt-1">{errors.group}</p>}

//         {selectedGroup && (
//           <DynamicProfileForm 
//             profileType={determineProfileType(selectedGroup.label)} 
//             targetUser={{ id: newUserId }} 
//             setProfileData={setProfileData} 
//             setProfilePicture={setProfilePicture} 
//           />
//         )}

//         <button 
//           type="submit" 
//           className="w-full bg-green-500 text-white p-2 rounded hover:bg-green-600 transition-colors"
//           disabled={isLoading}
//         >
//           {isLoading ? "Processing..." : "Create User & Profile"}
//         </button>

//         {errors.submit && (
//           <p className="text-red-500 text-center mt-2">{errors.submit}</p>
//         )}
//       </form>

//       {showValidationDialog && validationMessages.length > 0 && (
//         <div className="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50">
//           <div className="bg-white rounded-lg p-6 max-w-md w-full mx-4">
//             <h3 className="text-xl font-bold mb-4">Please Fix the Following Errors:</h3>
//             <ul className="list-disc pl-5 space-y-1">
//               {validationMessages.map((message, index) => (
//                 <li key={index} className="text-red-500">{message}</li>
//               ))}
//             </ul>
//             <button
//               onClick={() => setShowValidationDialog(false)}
//               className="mt-4 px-4 py-2 bg-blue-500 text-white rounded hover:bg-blue-600 w-full"
//             >
//               Close
//             </button>
//           </div>
//         </div>
//       )}
//     </div>
//   );
// };

// export default CreateUserWithProfile;















// import React, { useState, useEffect } from "react";
// import { useNavigate } from "react-router-dom";
// import AuthService from "../services/auth.service";
// import UserService from "../services/userService";
// import DynamicProfileForm from "./DynamicProfileForm";
// import { populateGroupDropdown } from "../utils/fetch_group";
// import axios from "axios";

// const API_URL = "http://localhost:8000/api/";

// const determineProfileType = (group) => {
//   switch (group) {
//     case "Super Admin":
//       return "super_admin";
//     case "Hospital Head":
//       return "hospital_head";
//     case "Patient":
//       return "patient";
//     case "Hospital Admin":
//     case "Doctor":
//     case "Nurse":
//     case "Clerk":
//       return "staff";
//     default:
//       return null;
//   }
// };

// const CreateUserWithProfile = () => {
//   const navigate = useNavigate();
//   const [groupOptions, setGroupOptions] = useState([]);
//   const [selectedGroup, setSelectedGroup] = useState(null);
//   const [userFormData, setUserFormData] = useState({
//     username: "",
//     email: "",
//     password: "",
//     confirmPassword: "",
//     is_active: true,
//   });
//   const [profileData, setProfileData] = useState({});
//   const [profilePicture, setProfilePicture] = useState(null);
//   const [errors, setErrors] = useState({});
//   const [isLoading, setIsLoading] = useState(false);
//   const [newUserId, setNewUserId] = useState(null);

//   useEffect(() => {
//     const fetchGroups = async () => {
//       try {
//         const groups = await populateGroupDropdown();
//         setGroupOptions(groups);
//       } catch (error) {
//         console.error("Error fetching groups:", error);
//       }
//     };
//     fetchGroups();
//   }, []);

//   const validateUserForm = () => {
//     const newErrors = {};
//     if (!userFormData.username.trim()) newErrors.username = "Username is required";
//     if (!userFormData.email.trim() || !/\S+@\S+\.\S+/.test(userFormData.email))
//       newErrors.email = "Valid email is required";
//     if (!userFormData.password) newErrors.password = "Password is required";
//     if (userFormData.password !== userFormData.confirmPassword)
//       newErrors.confirmPassword = "Passwords do not match";
//     if (!selectedGroup) newErrors.group = "Group selection is required";

//     setErrors(newErrors);
//     return Object.keys(newErrors).length === 0;
//   };

//   const handleUserInputChange = (e) => {
//     const { name, value } = e.target;
//     setUserFormData((prev) => ({ ...prev, [name]: value }));
//   };

//   const handleGroupSelect = (group) => {
//     setSelectedGroup(group);
//   };

//   const createProfile = async (profileData, profileType) => {
//     const user = AuthService.getCurrentUser();
//     if (!user || !user.accessToken) {
//       throw new Error("User not authenticated");
//     }

//     console.log("Profile Type:", profileType);

//     const formattedProfileType = determineProfileType(profileType);
//     console.log("Formatted Profile Type:", formattedProfileType);

//     if (!formattedProfileType) {
//       throw new Error("Invalid profile type");
//     }
//         let endpoint = '';
//         switch (formattedProfileType) {
//           case 'hospital_head':
//             endpoint = `${API_URL}hospital-head-profiles/create`;
//             break;
//           case 'staff':
//             endpoint = `${API_URL}staff-profiles/create/`;
//             break;
//           case 'patient':
//             endpoint = `${API_URL}${formattedProfileType}/create/`;
//             break;
//           case 'super_admin':
//             endpoint = `${API_URL}super-admin-profiles/create/`;
//             break;
//           default:
//             throw new Error('Invalid profile type');
//         }
//     // const endpoint = `${API_URL}${formattedProfileType}-profiles/create/`;

//     const formData = new FormData();
//     Object.entries(profileData).forEach(([key, value]) => {
//       if (value) {
//         formData.append(key, value);
//       }
//     });

//     if (profilePicture) {
//       formData.append("profile_picture", profilePicture);
//     }


//     console.log("📝 Final FormData Before Sending:");
//     for (let [key, value] of formData.entries()) {
//       console.log(`${key}:`, value);
//     }

//     try {
//       const response = await axios.post(endpoint, formData, {
//         headers: { Authorization: `Bearer ${user.accessToken}` },
//       });
//       return response.data;
//     } catch (error) {
//       console.error("Error creating profile:", error.response?.data || error.message);
//       throw error;
//     }
//   };

//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     if (!validateUserForm()) return;

//     setIsLoading(true);
//     try {
//       const userData = { ...userFormData, group_id: selectedGroup.value };
//       const userResponse = await UserService.createUser(userData);
//       const userId = userResponse.id;
//       setNewUserId(userId);

//       setTimeout(async () => {
//         const fullProfileData = { user_id: userId, ...profileData };
//         await createProfile(fullProfileData, selectedGroup.label);
//         await AuthService.updateUserProfileStatus(userId, true);
//         navigate("/home");
//       }, 500);
//     } catch (error) {
//       console.error("Error creating user or profile:", error);
//       setErrors((prev) => ({ ...prev, submit: "User or profile creation failed" }));
//     }
//     setIsLoading(false);
//   };

//   return (
//     <div className="max-w-2xl mx-auto p-6 bg-white shadow-md rounded-md">
//       <h2 className="text-2xl font-bold text-gray-900 mb-4">Create User & Profile</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <input name="username" placeholder="Username" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.username && <p className="text-red-500">{errors.username}</p>}

//         <input name="email" type="email" placeholder="Email" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.email && <p className="text-red-500">{errors.email}</p>}

//         <input name="password" type="password" placeholder="Password" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.password && <p className="text-red-500">{errors.password}</p>}

//         <input name="confirmPassword" type="password" placeholder="Confirm Password" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.confirmPassword && <p className="text-red-500">{errors.confirmPassword}</p>}

//         <div className="flex space-x-2">
//           {groupOptions.map((group) => (
//             <button
//               key={group.value}
//               type="button"
//               className={`px-4 py-2 border rounded ${selectedGroup?.value === group.value ? "bg-blue-500 text-white" : "bg-gray-200"}`}
//               onClick={() => handleGroupSelect(group)}
//             >
//               {group.label}
//             </button>
//           ))}
//         </div>
//         {errors.group && <p className="text-red-500">{errors.group}</p>}

//         {selectedGroup && <DynamicProfileForm profileType={determineProfileType(selectedGroup.label)} targetUser={{ id: newUserId }} setProfileData={setProfileData} setProfilePicture={setProfilePicture} />}

//         <button type="submit" className="w-full bg-green-500 text-white p-2 rounded" disabled={isLoading}>
//           {isLoading ? "Processing..." : "Create User & Profile"}
//         </button>
//       </form>
//     </div>
//   );
// };

// export default CreateUserWithProfile;

















// import React, { useState, useEffect } from 'react';
// import { useNavigate } from 'react-router-dom';
// import AuthService from '../services/auth.service';
// import { populateGroupDropdown } from '../utils/fetch_group';
// import DynamicProfileForm from './DynamicProfileForm';
// import axios from "axios";
// import UserService from '../services/userService';

// const API_URL = "http://localhost:8000/api/";

// const CreateUserWithProfile = () => {
//   const navigate = useNavigate();
//   const [groupOptions, setGroupOptions] = useState([]);
//   const [selectedGroup, setSelectedGroup] = useState(null);
//   const [userFormData, setUserFormData] = useState({
//     username: '',
//     email: '',
//     password: '',
//     confirmPassword: '',
//     is_active: true,
//   });
//   const [profileData, setProfileData] = useState({});
//   const [errors, setErrors] = useState({});
//   const [isLoading, setIsLoading] = useState(false);
//   const [newUserId, setNewUserId] = useState(null);

//   useEffect(() => {
//     const fetchGroups = async () => {
//       try {
//         const groups = await populateGroupDropdown();
//         setGroupOptions(groups);
//       } catch (error) {
//         console.error('Error fetching groups:', error);
//       }
//     };
//     fetchGroups();
//   }, []);

//   const validateUserForm = () => {
//     const newErrors = {};
//     if (!userFormData.username.trim()) newErrors.username = 'Username is required';
//     if (!userFormData.email.trim() || !/\S+@\S+\.\S+/.test(userFormData.email))
//       newErrors.email = 'Valid email is required';
//     if (!userFormData.password) newErrors.password = 'Password is required';
//     if (userFormData.password !== userFormData.confirmPassword)
//       newErrors.confirmPassword = 'Passwords do not match';
//     if (!selectedGroup) newErrors.group = 'Group selection is required';

//     setErrors(newErrors);
//     return Object.keys(newErrors).length === 0;
//   };

//   const handleUserInputChange = (e) => {
//     const { name, value } = e.target;
//     setUserFormData((prev) => ({ ...prev, [name]: value }));
//   };

//   const handleGroupSelect = (group) => {
//     setSelectedGroup(group);
//   };

//   const createProfile = async (profileData, profileType) => {
//     const user = AuthService.getCurrentUser();
//     if (!user || !user.accessToken) {
//       throw new Error('User not authenticated');
//     }

//     console.log("Profile type", profileType);
//     const formattedProfileType = profileType.replace(/ /g, '_').toLowerCase();
//     console.log("Formatted Profile type", formattedProfileType);
//         let endpoint = '';
//         switch (formattedProfileType) {
//           case 'hospital_head':
//             endpoint = `${API_URL}hospital-head-profiles/create`;
//             break;
//           case 'staff':
//             endpoint = `${API_URL}staff-profiles/create/`;
//             break;
//           case 'patient':
//             endpoint = `${API_URL}patients/create/`;
//             break;
//           case 'super_admin':
//             endpoint = `${API_URL}super-admin-profiles/create/`;
//             break;
//           default:
//             throw new Error('Invalid profile type');
//         }


//     const formData = new FormData();
//     Object.entries(profileData).forEach(([key, value]) => {
//       if (value) {
//         formData.append(key, value);
//       }
//     });

//     try {
//       const response = await axios.post(endpoint, formData, {
//         headers: { Authorization: `Bearer ${user.accessToken}` },
//       });
//       return response.data;
//     } catch (error) {
//       console.error('Error creating profile:', error.response?.data || error.message);
//       throw error;
//     }
//   };

//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     if (!validateUserForm()) return;

//     setIsLoading(true);
//     try {
//       const userData = { ...userFormData, group_id: selectedGroup.value };
//       const userResponse = await UserService.createUser(userData);
//       const userId = userResponse.id;
//       setNewUserId(userId);

//       setTimeout(async () => {
//         const fullProfileData = { user_id: userId, ...profileData };
//         await createProfile(fullProfileData, selectedGroup.label);
//         navigate('/success');
//       }, 500);
//     } catch (error) {
//       console.error('Error creating user or profile:', error);
//       setErrors((prev) => ({ ...prev, submit: 'User or profile creation failed' }));
//     }
//     setIsLoading(false);
//   };

//   return (
//     <div className="max-w-2xl mx-auto p-6 bg-white shadow-md rounded-md">
//       <h2 className="text-2xl font-bold text-gray-900 mb-4">Create User & Profile</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <input name="username" placeholder="Username" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.username && <p className="text-red-500">{errors.username}</p>}

//         <input name="email" type="email" placeholder="Email" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.email && <p className="text-red-500">{errors.email}</p>}

//         <input name="password" type="password" placeholder="Password" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.password && <p className="text-red-500">{errors.password}</p>}

//         <input name="confirmPassword" type="password" placeholder="Confirm Password" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.confirmPassword && <p className="text-red-500">{errors.confirmPassword}</p>}

//         <div className="flex space-x-2">
//           {groupOptions.map((group) => (
//             <button
//               key={group.value}
//               type="button"
//               className={`px-4 py-2 border rounded ${selectedGroup?.value === group.value ? 'bg-blue-500 text-white' : 'bg-gray-200'}`}
//               onClick={() => handleGroupSelect(group)}
//             >
//               {group.label}
//             </button>
//           ))}
//         </div>
//         {errors.group && <p className="text-red-500">{errors.group}</p>}

//         {selectedGroup && <DynamicProfileForm profileType={selectedGroup.label.toLowerCase()} targetUser={{ id: newUserId }} setProfileData={setProfileData} />}

//         <button type="submit" className="w-full bg-green-500 text-white p-2 rounded" disabled={isLoading}>
//           {isLoading ? 'Processing...' : 'Create User & Profile'}
//         </button>
//       </form>
//     </div>
//   );
// };

// export default CreateUserWithProfile;







































// import React, { useState, useEffect } from 'react';
// import { useNavigate } from 'react-router-dom';
// import AuthService from '../services/auth.service';
// import { populateGroupDropdown } from '../utils/fetch_group';
// import DynamicProfileForm from './DynamicProfileForm';
// import axios from "axios";
// import UserService from '../services/userService';

// const API_URL = "http://localhost:8000/api/";

// const CreateUserWithProfile = () => {
//   const navigate = useNavigate();
//   const [groupOptions, setGroupOptions] = useState([]);
//   const [selectedGroup, setSelectedGroup] = useState(null);
//   const [userFormData, setUserFormData] = useState({
//     username: '',
//     email: '',
//     password: '',
//     confirmPassword: '',
//     is_active: true,
//   });
//   const [profileData, setProfileData] = useState({});
//   const [errors, setErrors] = useState({});
//   const [isLoading, setIsLoading] = useState(false);
//   const [newUserId, setNewUserId] = useState(null);

//   useEffect(() => {
//     const fetchGroups = async () => {
//       try {
//         const groups = await populateGroupDropdown();
//         setGroupOptions(groups);
//       } catch (error) {
//         console.error('Error fetching groups:', error);
//       }
//     };
//     fetchGroups();
//   }, []);

//   const validateUserForm = () => {
//     const newErrors = {};
//     if (!userFormData.username.trim()) newErrors.username = 'Username is required';
//     if (!userFormData.email.trim() || !/\S+@\S+\.\S+/.test(userFormData.email))
//       newErrors.email = 'Valid email is required';
//     if (!userFormData.password) newErrors.password = 'Password is required';
//     if (userFormData.password !== userFormData.confirmPassword)
//       newErrors.confirmPassword = 'Passwords do not match';
//     if (!selectedGroup) newErrors.group = 'Group selection is required';

//     setErrors(newErrors);
//     return Object.keys(newErrors).length === 0;
//   };

//   const handleUserInputChange = (e) => {
//     const { name, value } = e.target;
//     setUserFormData((prev) => ({ ...prev, [name]: value }));
//   };

//   const handleGroupSelect = (group) => {
//     setSelectedGroup(group);
//   };

//   const createProfile = async (profileData, profileType) => {
//     const user = AuthService.getCurrentUser();
//     if (!user || !user.accessToken) {
//       throw new Error('User not authenticated');
//     }
//     console.log("Profile type", profileType);
//     const formattedProfileType = profileType.replace(/ /g, '_').toLowerCase();
//     console.log("Formatted Profile type", formattedProfileType);
//         let endpoint = '';
//         switch (formattedProfileType) {
//           case 'hospital_head':
//             endpoint = `${API_URL}hospital-head-profiles/create`;
//             break;
//           case 'staff':
//             endpoint = `${API_URL}staff-profiles/create/`;
//             break;
//           case 'patient':
//             endpoint = `${API_URL}patients/create/`;
//             break;
//           case 'super_admin':
//             endpoint = `${API_URL}super-admin-profiles/create/`;
//             break;
//           default:
//             throw new Error('Invalid profile type');
//         }

//     // let endpoint = `${API_URL}${formattedProfileType}-profiles/create/`;

//     const formData = new FormData();
//     Object.entries(profileData).forEach(([key, value]) => {
//       formData.append(key, value);
//     });

//     try {
//       const response = await axios.post(endpoint, formData, {
//         headers: { Authorization: `Bearer ${user.accessToken}` },
//       });
//       return response.data;
//     } catch (error) {
//       console.error('Error creating profile:', error.response?.data || error.message);
//       throw error;
//     }
//   };

//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     if (!validateUserForm()) return;

//     setIsLoading(true);
//     try {
//       const userData = { ...userFormData, group_id: selectedGroup.value };
//       const userResponse = await UserService.createUser(userData);
//       const userId = userResponse.id;
//       setNewUserId(userId);
      
//       const fullProfileData = { user_id: userId, ...profileData };
//       await createProfile(fullProfileData, selectedGroup.label);
//       navigate('/success');
//     } catch (error) {
//       console.error('Error creating user or profile:', error);
//       setErrors((prev) => ({ ...prev, submit: 'User or profile creation failed' }));
//     }
//     setIsLoading(false);
//   };

//   return (
//     <div className="max-w-2xl mx-auto p-6 bg-white shadow-md rounded-md">
//       <h2 className="text-2xl font-bold text-gray-900 mb-4">Create User & Profile</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <input name="username" placeholder="Username" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.username && <p className="text-red-500">{errors.username}</p>}

//         <input name="email" type="email" placeholder="Email" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.email && <p className="text-red-500">{errors.email}</p>}

//         <input name="password" type="password" placeholder="Password" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.password && <p className="text-red-500">{errors.password}</p>}

//         <input name="confirmPassword" type="password" placeholder="Confirm Password" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.confirmPassword && <p className="text-red-500">{errors.confirmPassword}</p>}

//         <div className="flex space-x-2">
//           {groupOptions.map((group) => (
//             <button
//               key={group.value}
//               type="button"
//               className={`px-4 py-2 border rounded ${selectedGroup?.value === group.value ? 'bg-blue-500 text-white' : 'bg-gray-200'}`}
//               onClick={() => handleGroupSelect(group)}
//             >
//               {group.label}
//             </button>
//           ))}
//         </div>
//         {errors.group && <p className="text-red-500">{errors.group}</p>}

//         {selectedGroup && <DynamicProfileForm profileType={selectedGroup.label.toLowerCase()} targetUser={{ id: newUserId }} setProfileData={setProfileData} />}

//         <button type="submit" className="w-full bg-green-500 text-white p-2 rounded" disabled={isLoading}>
//           {isLoading ? 'Processing...' : 'Create User & Profile'}
//         </button>
//       </form>
//     </div>
//   );
// };

// export default CreateUserWithProfile;

























// import React, { useState, useEffect } from 'react';
// import { useNavigate } from 'react-router-dom';
// import AuthService from '../services/auth.service';
// import { populateGroupDropdown } from '../utils/fetch_group';
// import DynamicProfileForm from './DynamicProfileForm';
// import axios from "axios";
// import UserService from '../services/userService';

// const API_URL = "http://localhost:8000/api/";

// const CreateUserWithProfile = () => {
//   const navigate = useNavigate();
//   const [groupOptions, setGroupOptions] = useState([]);
//   const [selectedGroup, setSelectedGroup] = useState(null);
//   const [userFormData, setUserFormData] = useState({
//     username: '',
//     email: '',
//     password: '',
//     confirmPassword: '',
//     is_active: true,
//   });
//   const [errors, setErrors] = useState({});
//   const [isLoading, setIsLoading] = useState(false);
//   const [newUserId, setNewUserId] = useState(null);
  
//   useEffect(() => {
//     const fetchGroups = async () => {
//       try {
//         const groups = await populateGroupDropdown();
//         setGroupOptions(groups);
//       } catch (error) {
//         console.error('Error fetching groups:', error);
//       }
//     };
//     fetchGroups();
//   }, []);
  
//   const validateUserForm = () => {
//     const newErrors = {};
//     if (!userFormData.username.trim()) newErrors.username = 'Username is required';
//     if (!userFormData.email.trim() || !/\S+@\S+\.\S+/.test(userFormData.email))
//       newErrors.email = 'Valid email is required';
//     if (!userFormData.password) newErrors.password = 'Password is required';
//     if (userFormData.password !== userFormData.confirmPassword)
//       newErrors.confirmPassword = 'Passwords do not match';
//     if (!selectedGroup) newErrors.group = 'Group selection is required';
  
//     setErrors(newErrors);
//     return Object.keys(newErrors).length === 0;
//   };
  
//   const handleUserInputChange = (e) => {
//     const { name, value } = e.target;
//     setUserFormData((prev) => ({ ...prev, [name]: value }));
//   };
  
//   const handleGroupSelect = (group) => {
//     setSelectedGroup(group);
//   };
  
//   const createProfile = async (profileData, profileType) => {
//     const user = AuthService.getCurrentUser();
//     if (!user || !user.accessToken) {
//       throw new Error('User not authenticated');
//     }
//     // let endpoint = '';
//     const formattedProfileType = profileType.replace(' ', '_').toLowerCase();
//     let endpoint = '';
//     switch (formattedProfileType) {
//       case 'hospital_head':
//         endpoint = `${API_URL}hospital-head-profiles/create`;
//         break;
//       case 'staff':
//         endpoint = `${API_URL}staff-profiles/create/`;
//         break;
//       case 'patient':
//         endpoint = `${API_URL}patients/create/`;
//         break;
//       case 'super_admin':
//         endpoint = `${API_URL}super-admin-profiles/create/`;
//         break;
//       default:
//         throw new Error('Invalid profile type');
//     }

//     // let endpoint = `${API_URL}${formattedProfileType}-profiles/create/`;
  
//     const formData = new FormData();
//     Object.entries(profileData).forEach(([key, value]) => {
//       formData.append(key, value);
//     });
  
//     try {
//       const response = await axios.post(endpoint, formData, {
//         headers: { Authorization: `Bearer ${user.accessToken}` },
//       });
//       return response.data;
//     } catch (error) {
//       console.error('Error creating profile:', error.response?.data || error.message);
//       throw error;
//     }
//   };
  
//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     if (!validateUserForm()) return;
  
//     setIsLoading(true);
//     try {
//       const userData = { ...userFormData, group_id: selectedGroup.value };
//       const userResponse = await UserService.createUser(userData);
//       const userId = userResponse.id;
      
//       const profileData = { user_id: userId, ...userFormData };
//       await createProfile(profileData, selectedGroup.label);
//       navigate('/success');
//     } catch (error) {
//       console.error('Error creating user or profile:', error);
//       setErrors((prev) => ({ ...prev, submit: 'User or profile creation failed' }));
//     }
//     setIsLoading(false);
//   };
  
//   return (
//     <div className="max-w-2xl mx-auto p-6 bg-white shadow-md rounded-md">
//       <h2 className="text-2xl font-bold text-gray-900 mb-4">Create User & Profile</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <input name="username" placeholder="Username" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.username && <p className="text-red-500">{errors.username}</p>}
  
//         <input name="email" type="email" placeholder="Email" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.email && <p className="text-red-500">{errors.email}</p>}
  
//         <input name="password" type="password" placeholder="Password" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.password && <p className="text-red-500">{errors.password}</p>}
  
//         <input name="confirmPassword" type="password" placeholder="Confirm Password" onChange={handleUserInputChange} className="w-full p-2 border rounded" />
//         {errors.confirmPassword && <p className="text-red-500">{errors.confirmPassword}</p>}
  
//         <div className="flex space-x-2">
//           {groupOptions.map((group) => (
//             <button
//               key={group.value}
//               type="button"
//               className={`px-4 py-2 border rounded ${selectedGroup?.value === group.value ? 'bg-blue-500 text-white' : 'bg-gray-200'}`}
//               onClick={() => handleGroupSelect(group)}
//             >
//               {group.label}
//             </button>
//           ))}
//         </div>
//         {errors.group && <p className="text-red-500">{errors.group}</p>}
  
//         {selectedGroup && <DynamicProfileForm profileType={selectedGroup.label.toLowerCase()} targetUser={{ id: newUserId }} onSubmit={createProfile} />}
  
//         <button type="submit" className="w-full bg-green-500 text-white p-2 rounded" disabled={isLoading}>
//           {isLoading ? 'Processing...' : 'Create User & Profile'}
//         </button>
//       </form>
//     </div>
//   );
// };
  
// export default CreateUserWithProfile;






















// import React, { useState, useEffect } from 'react';
// import { useNavigate, useParams } from 'react-router-dom';
// import { EyeIcon, EyeSlashIcon } from '@heroicons/react/24/outline';
// import Select from 'react-select';
// import { populateGroupDropdown } from '../utils/fetch_group';
// import UserService from '../services/userService';

// const CreateUpdateUserForm = () => {
//   const { userId } = useParams();
//   const navigate = useNavigate();
//   const isUpdateMode = !!userId;

//   const [formData, setFormData] = useState({
//     username: '',
//     email: '',
//     password: '',
//     confirmPassword: '',
//     is_active: false,
//     group: null
//   });
//   const [showPassword, setShowPassword] = useState(false);
//   const [groupOptions, setGroupOptions] = useState([]);
//   const [errors, setErrors] = useState({});
//   const [isLoading, setIsLoading] = useState(false);
//   const [updatePassword, setUpdatePassword] = useState(false);

//   useEffect(() => {
//     const fetchData = async () => {
//       setIsLoading(true);
//       try {
//         const groups = await populateGroupDropdown();
//         setGroupOptions(groups);

//         if (isUpdateMode) {
//           const userData = await UserService.getUserById(userId);
//           setFormData(prevState => ({
//             ...prevState,
//             username: userData.username,
//             email: userData.email,
//             is_active: userData.is_active,
//             group: groups.find(g => g.value === userData.group_id)
//           }));
//         }
//       } catch (error) {
//         console.error('Error fetching data:', error);
//       }
//       setIsLoading(false);
//     };

//     fetchData();
//   }, [userId, isUpdateMode]);

//   const validateForm = () => {
//     const newErrors = {};
//     if (!formData.username.trim()) {
//       newErrors.username = 'Username is required';
//     } else if (/[^a-zA-Z0-9_]/.test(formData.username)) {
//       newErrors.username = 'Username can only contain letters, numbers, and underscores';
//     }

//     if (!formData.email.trim()) {
//       newErrors.email = 'Email is required';
//     } else if (!/\S+@\S+\.\S+/.test(formData.email)) {
//       newErrors.email = 'Invalid email format';
//     }

//     if (!isUpdateMode || updatePassword) {
//       if (!formData.password) {
//         newErrors.password = 'Password is required';
//       } else if (!/^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$/.test(formData.password)) {
//         newErrors.password = 'Password must contain at least 8 characters, including letters, numbers, and symbols';
//       }

//       if (formData.password !== formData.confirmPassword) {
//         newErrors.confirmPassword = 'Passwords do not match';
//       }
//     }

//     if (!formData.group) {
//       newErrors.group = 'Group is required';
//     }

//     setErrors(newErrors);
//     return Object.keys(newErrors).length === 0;
//   };

//   const handleInputChange = (e) => {
//     const { name, value, type, checked } = e.target;
//     setFormData(prevState => ({
//       ...prevState,
//       [name]: type === 'checkbox' ? checked : value
//     }));
//   };

//   const handleGroupChange = (selectedOption) => {
//     setFormData(prevState => ({
//       ...prevState,
//       group: selectedOption
//     }));
//   };

//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     if (!validateForm()) return;

//     setIsLoading(true);
//     try {
//       const submitData = {
//         ...formData,
//         group_id: formData.group.value
//       };

//       if (isUpdateMode) {
//         if (!updatePassword) {
//           delete submitData.password;
//           delete submitData.confirmPassword;
//         }
//         await UserService.updateUser(userId, submitData);
//       } else {
//         await UserService.createUser(submitData);
//       }

//       navigate('/users');
//     } catch (error) {
//       console.error('Error submitting form:', error);
//       setErrors(prevErrors => ({
//         ...prevErrors,
//         submit: 'An error occurred while submitting the form'
//       }));
//     }
//     setIsLoading(false);
//   };

//   if (isLoading) {
//     return <div className="text-center">Loading...</div>;
//   }

//   return (
//     <div className="min-h-screen bg-gray-100 flex items-center justify-center py-12 px-4 sm:px-6 lg:px-8">
//       <div className="max-w-md w-full space-y-8">
//         <div className="bg-white shadow-lg rounded-lg p-8 backdrop-filter backdrop-blur-lg bg-opacity-30">
//           <h2 className="text-center text-3xl font-extrabold text-gray-900">
//             {isUpdateMode ? 'Update User' : 'Create User'}
//           </h2>
//           <form className="mt-8 space-y-6" onSubmit={handleSubmit}>
//             <div className="rounded-md shadow-sm -space-y-px">
//               <div>
//                 <label htmlFor="username" className="sr-only">Username</label>
//                 <input
//                   id="username"
//                   name="username"
//                   type="text"
//                   required
//                   className="appearance-none rounded-none relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 rounded-t-md focus:outline-none focus:ring-blue-500 focus:border-blue-500 focus:z-10 sm:text-sm"
//                   placeholder="Username"
//                   value={formData.username}
//                   onChange={handleInputChange}
//                 />
//                 {errors.username && <p className="text-red-500 text-xs mt-1">{errors.username}</p>}
//               </div>
//               <div>
//                 <label htmlFor="email" className="sr-only">Email</label>
//                 <input
//                   id="email"
//                   name="email"
//                   type="email"
//                   required
//                   className="appearance-none rounded-none relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 focus:outline-none focus:ring-blue-500 focus:border-blue-500 focus:z-10 sm:text-sm"
//                   placeholder="Email address"
//                   value={formData.email}
//                   onChange={handleInputChange}
//                 />
//                 {errors.email && <p className="text-red-500 text-xs mt-1">{errors.email}</p>}
//               </div>
//               {(!isUpdateMode || updatePassword) && (
//                 <>
//                   <div className="relative">
//                     <label htmlFor="password" className="sr-only">Password</label>
//                     <input
//                       id="password"
//                       name="password"
//                       type={showPassword ? "text" : "password"}
//                       required
//                       className="appearance-none rounded-none relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 focus:outline-none focus:ring-blue-500 focus:border-blue-500 focus:z-10 sm:text-sm"
//                       placeholder="Password"
//                       value={formData.password}
//                       onChange={handleInputChange}
//                     />
//                     <button
//                       type="button"
//                       className="absolute inset-y-0 right-0 pr-3 flex items-center"
//                       onClick={() => setShowPassword(!showPassword)}
//                     >
//                       {showPassword ? (
//                         <EyeSlashIcon className="h-5 w-5 text-gray-400" />
//                       ) : (
//                         <EyeIcon className="h-5 w-5 text-gray-400" />
//                       )}
//                     </button>
//                   </div>
//                   {errors.password && <p className="text-red-500 text-xs mt-1">{errors.password}</p>}
//                   <div>
//                     <label htmlFor="confirmPassword" className="sr-only">Confirm Password</label>
//                     <input
//                       id="confirmPassword"
//                       name="confirmPassword"
//                       type="password"
//                       required
//                       className="appearance-none rounded-none relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 rounded-b-md focus:outline-none focus:ring-blue-500 focus:border-blue-500 focus:z-10 sm:text-sm"
//                       placeholder="Confirm password"
//                       value={formData.confirmPassword}
//                       onChange={handleInputChange}
//                     />
//                     {errors.confirmPassword && <p className="text-red-500 text-xs mt-1">{errors.confirmPassword}</p>}
//                   </div>
//                 </>
//               )}
//             </div>

//             <div className="flex items-center justify-between">
//               <div className="flex items-center">
//                 <input
//                   id="is_active"
//                   name="is_active"
//                   type="checkbox"
//                   className="h-4 w-4 text-blue-600 focus:ring-blue-500 border-gray-300 rounded"
//                   checked={formData.is_active}
//                   onChange={handleInputChange}
//                 />
//                 <label htmlFor="is_active" className="ml-2 block text-sm text-gray-900">
//                   Active
//                 </label>
//               </div>
//               {isUpdateMode && (
//                 <div className="flex items-center">
//                   <input
//                     id="updatePassword"
//                     name="updatePassword"
//                     type="checkbox"
//                     className="h-4 w-4 text-blue-600 focus:ring-blue-500 border-gray-300 rounded"
//                     checked={updatePassword}
//                     onChange={(e) => setUpdatePassword(e.target.checked)}
//                   />
//                   <label htmlFor="updatePassword" className="ml-2 block text-sm text-gray-900">
//                     Update Password
//                   </label>
//                 </div>
//               )}
//             </div>

//             <div>
//               <label htmlFor="group" className="block text-sm font-medium text-gray-700">
//                 Group
//               </label>
//               <Select
//                 id="group"
//                 name="group"
//                 options={groupOptions}
//                 value={formData.group}
//                 onChange={handleGroupChange}
//                 className="mt-1 block w-full py-2 px-3 border border-gray-300 bg-white rounded-md shadow-sm focus:outline-none focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
//               />
//               {errors.group && <p className="text-red-500 text-xs mt-1">{errors.group}</p>}
//             </div>

//             {errors.submit && <p className="text-red-500 text-sm">{errors.submit}</p>}

//             <div>
//               <button
//                 type="submit"
//                 className="group relative w-full flex justify-center py-2 px-4 border border-transparent text-sm font-medium rounded-md text-white bg-blue-600 hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500"
//                 disabled={isLoading}
//               >
//                 {isLoading ? 'Processing...' : isUpdateMode ? 'Update User' : 'Create User'}
//               </button>
//             </div>
//           </form>
//         </div>
//       </div>
//     </div>
//   );
// };

// export default CreateUpdateUserForm;