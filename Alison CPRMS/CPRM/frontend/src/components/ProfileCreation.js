// ProfileCreationForm.js
import React, { useState } from 'react';
import AuthService from '../services/auth.service';
import { ProfileManagement } from '../utils/profileManagement';
import DynamicProfileForm from './DynamicProfileForm';

const ProfileCreation = () => {
  const [userId, setUserId] = useState('');
  const [targetUser, setTargetUser] = useState(null);
  const [message, setMessage] = useState('');
  const [profileType, setProfileType] = useState('');

  const handleUserIdCheck = async () => {
    try {
      const targetUserData = await AuthService.getUserDetails(userId);
      const targetGroup = await AuthService.getUserGroup(userId);
      const currentUser = AuthService.getCurrentUser();
      const canCreate = await ProfileManagement.canCreateProfileForUser(currentUser.groups, targetGroup);
      
      if (canCreate) {
        setProfileType(ProfileManagement.determineProfileType(targetGroup));
        setTargetUser(targetUserData);
      } else {
        setMessage("You don't have the authority to create a profile for this user.");
      }
    } catch (error) {
      setMessage('Error checking user. Please try again.');
    }
  };

  const handleSubmit = async (formData) => {
    try {
      const result = await ProfileManagement.handleProfileCreation(formData, targetUser.id,profileType);
      console.log("Form Data:", formData); // Log form data to check it

      if (result.success) {
        setMessage('Profile created successfully!');
        setTargetUser(null);
        setUserId('');
      } else {
        setMessage(result.error || 'Error creating profile. Please try again.');
      }
    } catch (error) {
      setMessage('Error creating profile. Please try again.');
    }
  };

  return (
    <div className="container mx-auto p-4">
      <h2 className="text-2xl font-bold mb-4">Create User Profile</h2>
      <div className="mb-4">
        <input
          type="text"
          value={userId}
          onChange={(e) => setUserId(e.target.value)}
          placeholder="Enter User ID"
          className="border p-2 mr-2"
        />
        <button onClick={handleUserIdCheck} className="bg-blue-500 text-white p-2 rounded">
          Check User
        </button>
      </div>
      {message && <p className="text-green-500 mb-4">{message}</p>}
      {profileType && targetUser && (
        <DynamicProfileForm
          profileType={profileType}
          onSubmit={handleSubmit}
          targetUser={targetUser}
        />
      )}
    </div>
  );
};

export default ProfileCreation;