// profileManagement.js
import AuthService from '../services/auth.service';

export const ProfileManagement = {
  
  determineProfileType: (group) => {
    switch (group) {
      case 'Super Admin':
        return 'super_admin';
      case 'Hospital Head':
        return 'hospital_head';
      case 'Patient':
        return 'patient';
      case 'Hospital Admin':
      case 'Doctor':
      case 'Nurse':
      case 'Clerk':
        return 'staff';
      default:
        return null;
    }
  },

  canCreateProfileForUser: async (creatorGroup, targetGroup) => {
    const authorizedGroups = await AuthService.getAuthorizedGroups();
    return authorizedGroups[creatorGroup] && authorizedGroups[creatorGroup].includes(targetGroup);
  },

  
  handleProfileCreation: async (profileData, targetUserId,Profile_Type) => {
    try {

      profileData.append('user_id', targetUserId);

      const response = await AuthService.createProfile(profileData,Profile_Type);
      await AuthService.updateUserProfileStatus(targetUserId, true);
      return { success: true, data: response };
    } catch (error) {
      console.error('Error in profile creation:', error);
      return { success: false, error: error.message || 'An error occurred during profile creation' };
    }
  }
};
