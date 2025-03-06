import axios from "axios";
const API_URL = "http://localhost:8000/api";

const NotificationService = {
  getNotifications: async (profileId) => {
    try {
      const user = JSON.parse(localStorage.getItem("user"));
      if (!user || !user.accessToken) throw new Error("User not authenticated");
      
      const response = await axios.get(`${API_URL}notifications/${profileId}/`, {
        headers: { Authorization: `Bearer ${user.accessToken}` },
      });
      return response.data;
    } catch (error) {
      console.error("Error fetching notifications:", error);
      throw error;
    }
  },
};

export default NotificationService;
