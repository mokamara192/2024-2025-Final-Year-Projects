import React, { useEffect, useState } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { 
  ArrowPathIcon,
  UserCircleIcon,
  EnvelopeIcon,
  UserIcon,
  BuildingOfficeIcon,
  PhoneIcon,
  MapPinIcon,
  KeyIcon,
  BeakerIcon,
  CalendarIcon,
  IdentificationIcon,
  ShieldCheckIcon,
  HeartIcon
} from '@heroicons/react/24/outline';
import AuthService from '../services/auth.service';
import axios from 'axios';

const API_URL = "http://localhost:8000/api/";

const InfoCard = ({ icon: Icon, label, value, showRegenerate, onRegenerate }) => {
  if (!value) return null;
  return (
    <div className="flex items-start space-x-3 p-4 bg-white rounded-lg shadow-sm border border-gray-100">
      <Icon className="h-5 w-5 text-blue-500 mt-0.5" />
      <div className="flex-grow">
        <div className="flex justify-between items-start">
          <div>
            <p className="text-sm font-medium text-gray-500">{label}</p>
            <p className="mt-1 text-sm text-gray-900">{value}</p>
          </div>
          {showRegenerate && (
            <button
              onClick={onRegenerate}
              className="p-2 text-gray-400 hover:text-gray-500 rounded-full hover:bg-gray-50"
              title={`Regenerate ${label}`}
            >
              <ArrowPathIcon className="h-5 w-5" />
            </button>
          )}
        </div>
      </div>
    </div>
  );
};
// const InfoCard = ({ icon: Icon, label, value }) => {
//   if (!value) return null;
//   return (
//     <div className="flex items-start space-x-3 p-4 bg-white rounded-lg shadow-sm border border-gray-100">
//       <Icon className="h-5 w-5 text-blue-500 mt-0.5" />
//       <div>
//         <p className="text-sm font-medium text-gray-500">{label}</p>
//         <p className="mt-1 text-sm text-gray-900">{value}</p>
//       </div>
//     </div>
//   );
// };

const ProfileSection = ({ title, children }) => (
  <div className="mt-8">
    <h2 className="text-lg font-medium text-gray-900 mb-4">{title}</h2>
    <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
      {children}
    </div>
  </div>
);

const UserProfile = () => {
  const { userId } = useParams();
  const navigate = useNavigate();
  const [userProfile, setUserProfile] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchProfile = async () => {
      try {
        const currentUser = AuthService.getCurrentUser();
        const idToFetch = userId || currentUser?.id;
        if (!idToFetch) throw new Error('User ID is not available.');
        
        const response = await AuthService.getUserProfile(idToFetch);
        setUserProfile(response);
      } catch (err) {
        setError(err.message || 'Failed to fetch user profile.');
      } finally {
        setLoading(false);
      }
    };

    fetchProfile();
  }, [userId]);


  const handlePublicKeyRegenerate = async () => {
    const user = JSON.parse(localStorage.getItem('user'));
    const token = user?.accessToken;
  
    try {
      const response = await axios.post(
        `${API_URL}patients/${userProfile.id}/generate-public-key/`,
        {}, // empty body
        {
          headers: { 
            Authorization: `Bearer ${token}`,
            'Content-Type': 'application/json',
          }
        }
      );
      
      // Axios automatically throws an error for non-2xx responses
      // and response.data already contains the parsed JSON
      setUserProfile(prev => ({
        ...prev,
        public_key: response.data.public_key
      }));
    } catch (error) {
      console.error('Error regenerating public key:', error.response?.data || error.message);
      // Handle error appropriately
    }
  };

const handlePrivateKeyRegenerate = async () => {
  const user = JSON.parse(localStorage.getItem('user'));
  const token = user?.accessToken;
  try {
    const response = await axios.post(
      `${API_URL}patients/${userProfile.id}/generate-private-key/`,
      {}, // empty body
      {
        headers: { 
          Authorization: `Bearer ${token}`,
          'Content-Type': 'application/json',
        }
      }
    );

    // Update the userProfile state with the new private key
    setUserProfile(prev => ({
      ...prev,
      private_key: response.data.private_key
    }));
  } catch (error) {
    console.error('Error regenerating private key:', error);
    // Handle error appropriately
  }
};



  if (loading) {
    return (
      <div className="min-h-screen flex items-center justify-center bg-gray-50">
        <div className="animate-spin rounded-full h-12 w-12 border-4 border-blue-500 border-t-transparent"></div>
      </div>
    );
  }

  if (error) {
    return (
      <div className="min-h-screen flex items-center justify-center bg-gray-50">
        <div className="bg-white p-8 rounded-lg shadow-md">
          <h3 className="text-red-500 text-lg font-medium">Error</h3>
          <p className="mt-2 text-gray-600">{error}</p>
        </div>
      </div>
    );
  }

  const renderProfileContent = () => {
    const commonDetails = (
      <>
        <ProfileSection title="Basic Information">
          <InfoCard icon={IdentificationIcon} label="User ID" value={userProfile.id} />
          <InfoCard icon={EnvelopeIcon} label="Email" value={userProfile.user?.email} />
          <InfoCard icon={UserIcon} label="Username" value={userProfile.user?.username} />
          <InfoCard icon={ShieldCheckIcon} label="Role" value={userProfile.group} />
        </ProfileSection>
      </>
    );

    switch (userProfile.group) {
      case 'Patient':
        return (
          <>
            {commonDetails}
            <ProfileSection title="Personal Details">
              <InfoCard icon={CalendarIcon} label="Date of Birth" value={userProfile.date_of_birth} />
              <InfoCard icon={BeakerIcon} label="Blood Type" value={userProfile.blood_type} />
              <InfoCard icon={IdentificationIcon} label="NIN" value={userProfile.nin} />
              <InfoCard icon={UserIcon} label="Gender" value={userProfile.gender} />
              <InfoCard icon={MapPinIcon} label="Address" value={userProfile.address} />
            </ProfileSection>
            <ProfileSection title="Emergency Contact">
              <InfoCard icon={UserIcon} label="Contact Name" value={userProfile.emergency_contact_name} />
              <InfoCard icon={PhoneIcon} label="Contact Number" value={userProfile.emergency_contact_number} />
            </ProfileSection>
            <ProfileSection title="Medical Information">
              <InfoCard icon={HeartIcon} label="Medical Info" value={userProfile.medical_info} />
              {/* <InfoCard icon={KeyIcon} label="Public Key" value={userProfile.public_key} />
              <InfoCard icon={KeyIcon} label="Private Key" value={userProfile.private_key} /> */}
              <InfoCard 
                icon={KeyIcon} 
                label="Public Key" 
                value={userProfile.public_key}
                showRegenerate={userProfile.group === 'Patient'}
                onRegenerate={handlePublicKeyRegenerate}
              />
              <InfoCard 
                icon={KeyIcon} 
                label="Private Key" 
                value={userProfile.private_key}
                showRegenerate={userProfile.group === 'Patient'}
                onRegenerate={handlePrivateKeyRegenerate}
              />
            </ProfileSection>
          </>
        );

      case 'Staff':
        return (
          <>
            {commonDetails}
            <ProfileSection title="Professional Details">
              <InfoCard icon={BuildingOfficeIcon} label="Hospital" value={userProfile.hospital?.name} />
              <InfoCard icon={UserIcon} label="Specialty" value={userProfile.specialty} />
              <InfoCard icon={CalendarIcon} label="Hire Date" value={userProfile.hire_date} />
            </ProfileSection>
          </>
        );

      case 'Super Admin':
      case 'Hospital Head':
        return (
          <>
            {commonDetails}
            <ProfileSection title="Contact Information">
              <InfoCard icon={MapPinIcon} label="Address" value={userProfile.address} />
              <InfoCard icon={PhoneIcon} label="Phone" value={userProfile.phone_number} />
            </ProfileSection>
          </>
        );

      default:
        return commonDetails;
    }
  };

  return (
    <div className="min-h-screen bg-gray-50 py-8 px-4 sm:px-6 lg:px-8">
      <div className="max-w-4xl mx-auto">
        {/* Profile Header */}
        <div className="bg-white rounded-lg shadow-md overflow-hidden">
  <div className="h-32 bg-gradient-to-r from-blue-500 to-blue-600"></div>
  <div className="relative px-6 pb-6">
    <div className="flex items-end gap-6 -mt-16">
      {/* Profile Picture Container */}
        <div className="relative">
          {userProfile.profile_picture_url ? (
            <img
              src={userProfile.profile_picture_url}
              alt="Profile"
              className="h-32 w-32 rounded-full border-4 border-white shadow-lg object-cover bg-white"
            />
          ) : (
            <div className="h-32 w-32 rounded-full border-4 border-white shadow-lg bg-gray-100 flex items-center justify-center">
              <UserCircleIcon className="h-20 w-20 text-gray-400" />
            </div>
          )}
          <div className="absolute -bottom-2 -right-2 h-6 w-6 bg-green-400 rounded-full border-4 border-white"></div>
        </div>
        
        {/* Name and Group Container */}
        <div className="pb-4">
          <h1 className="text-2xl font-bold text-gray-900">
            {userProfile.first_name} {userProfile.middle_name} {userProfile.last_name}
          </h1>
          <p className="text-gray-500">{userProfile.group}</p>
        </div>
      </div>
    </div>
  </div>
        {/* Profile Content */}
        <div className="mt-6">
          {renderProfileContent()}
        </div>

        {/* Actions */}
        <div className="mt-8 flex justify-end">
          {/* <button
            onClick={() => navigate('/dummyupdate')}
            className="px-6 py-2 bg-blue-600 text-white font-medium rounded-lg hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 focus:ring-offset-2 transition-colors duration-200"
          >
            Update Profile
          </button> */}
        </div>
      </div>
    </div>
  );
};

export default UserProfile;
