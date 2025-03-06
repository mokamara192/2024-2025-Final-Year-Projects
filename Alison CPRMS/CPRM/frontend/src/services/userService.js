import axios from 'axios';
import AuthService from './auth.service';

const API_URL = 'http://localhost:8000/api/';

const UserService = {
  getUserById: async (userId) => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {
      try {
        const response = await axios.get(API_URL + `users/${userId}/`, {
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

  updateUser: async (userId, userData) => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {
      try {
        const response = await axios.put(API_URL + `users/${userId}/update/`, userData, {
          headers: { Authorization: `Bearer ${user.accessToken}` }
        });
        return response.data;
      } catch (error) {
        console.error('Error updating user:', error.response?.data || error.message);
        throw error;
      }
    }
    return null;
  },

  createUser: async (userData) => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {
      try {
        const response = await axios.post(API_URL + 'users/create/', userData, {
          headers: { Authorization: `Bearer ${user.accessToken}` }
        });
        return response.data;
      } catch (error) {
        console.error('Error creating user:', error.response?.data || error.message);
        throw error;
      }
    }
    return null;
  },

  getAllUsers: async () => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {
      try {
        const response = await axios.get(API_URL + 'users/', {
          headers: { Authorization: `Bearer ${user.accessToken}` }
        });
        return response.data;
      } catch (error) {
        console.error('Error fetching all users:', error.response?.data || error.message);
        throw error;
      }
    }
    return [];
  }
};

export default UserService;