// src->service->auth.service.js
import axios from 'axios';
import { jwtDecode } from 'jwt-decode';

const API_URL = 'http://localhost:8000/api';

const AuthService = {


  login: async (username, password) => {
    try {
      const response = await axios.post(API_URL + 'token/', { username, password });
      if (response.data.access) {
        const decodedToken = jwtDecode(response.data.access);
        const profileResponse = await axios.get(`${API_URL}user-profile/${decodedToken.user_id}/`, {
          headers: { Authorization: `Bearer ${response.data.access}` }
        });

        if (profileResponse.status === 200) {
          const userData = {
            accessToken: response.data.access,
            refreshToken: response.data.refresh,
            id: decodedToken.user_id,
            username: decodedToken.username,
            email: decodedToken.email,
            groups: decodedToken.groups,
            profile_set: decodedToken.profile_set,
            profileId: profileResponse.data.id
          };
          sessionStorage.setItem('user', JSON.stringify(userData));
          localStorage.setItem('user', JSON.stringify(userData));
          return userData;
        } else {
          throw new Error('Failed to fetch user profile');
        }
      }
      throw new Error('Login failed: No access token received');
    } catch (error) {
      console.error('Login error:', error.response?.data || error.message);
      throw error;
    }
  },

  logout: () => {
    sessionStorage.removeItem('user');
    localStorage.removeItem('user');
  },

  getCurrentUser: () => {
    const userStr = sessionStorage.getItem('user') || localStorage.getItem('user');
    if (userStr) return JSON.parse(userStr);
    return null;
  },
  getUserDetails: async (userId) => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {
      try {
        const response = await axios.get(`${API_URL}users/${userId}/`, {
          headers: { Authorization: `Bearer ${user.accessToken}` }
        });
        return response.data;
      } catch (error) {
        console.error('Error fetching user details:', error.response?.data || error.message);
        throw error;
      }
    }
    return null;
  },

  /**
   * Fetch user profile data dynamically by user ID.
   * Calls the `user-profile/<user_id>/` endpoint.
   * @param {number} userId - The ID of the user whose profile to fetch.
   * @returns {Promise<Object>} User profile data.
   */
  getUserProfile: async (userId) => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {
      try {
        const response = await axios.get(`${API_URL}user-profile/${userId}/`, {
          headers: { Authorization: `Bearer ${user.accessToken}` },
        });
        return response.data;
      } catch (error) {
        console.error('Error fetching user profile:', error.response?.data || error.message);
        throw error;
      }
    }
    throw new Error('User not authenticated');
  },


  getAuthorizedGroups: async () => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {
      try {
        const response = await axios.get(`${API_URL}authorized-groups/`, {
          headers: { Authorization: `Bearer ${user.accessToken}` }
        });
        return response.data;
      } catch (error) {
        console.error('Error fetching authorized groups:', error);
        throw error;
      }
    }
    throw new Error('User not authenticated');
  },

  getUserGroup: async (userId) => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {
      try {
        const response = await axios.get(`${API_URL}user/${userId}/group/`, {
          headers: { Authorization: `Bearer ${user.accessToken}` }
        });
        return response.data.group;
      } catch (error) {
        console.error('Error fetching user group:', error);
        throw error;
      }
    }
    throw new Error('User not authenticated');
  },

  
  getHospitalByHospitalAdmin: async (userId) => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {
      try {
        const response = await axios.get(`${API_URL}get-hospital-by-staffid/${userId}/`, {
          headers: { Authorization: `Bearer ${user.accessToken}` }
        });
        return response.data.hospital_id;
      } catch (error) {
        console.error('Error fetching hospital ID for Hospital Admin:', error);
        throw error;
      }
    }
    throw new Error('User not authenticated');
  },

  createProfile: async (profileData, PROFILE_TYPE) => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {


      let endpoint = '';

      // Determine the endpoint based on the profile type
      switch (PROFILE_TYPE) {
        case 'hospital_head':
          endpoint = `${API_URL}hospital-head-profiles/create`;
          break;
        case 'staff':
          endpoint = `${API_URL}staff-profiles/create/`;
          break;
        case 'patient':
          endpoint = `${API_URL}patients/create/`;
          break;
        case 'super_admin':
          endpoint = `${API_URL}super-admin-profiles/create/`;
          break;
        default:
          throw new Error('Invalid profile type');
      }

      try {
        for (let [key, value] of profileData.entries()) {
          console.log(`${key}: ${value}`);
        }
        const response = await axios.post(endpoint, profileData, {
          headers: { 
            'Authorization': `Bearer ${user.accessToken}`,
            // 'Content-Type': 'multipart/form-data'
          }
        });
        return response.data;
      } catch (error) {
        console.error('Error creating profile:', error);
        throw error;
      }
    }
    throw new Error('User not authenticated');
  },

};

export default AuthService;