

// src/utils/profile.service.js
import axios from 'axios';
import AuthService from '../services/auth.service';

const API_URL = 'http://localhost:8000/api/';

class ProfileService {
  static async fetchUserProfile() {
    const user = AuthService.getCurrentUser();
    if (!user) throw new Error('User not logged in.');

    try {
      const response = await axios.get(`${API_URL}user-profile/${user.id}/`, {
        headers: { Authorization: `Bearer ${user.accessToken}` },
      });
      console.log('Profile data received:', response.data);
      return response.data;
    } catch (error) {
      console.error('Error fetching profile:', error.response?.data || error.message);
      throw error;
    }
  }
}

export default ProfileService;
