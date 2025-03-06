import axios from "axios";

const API_URL = "http://localhost:8000/api/";

const RequestAccessService = {
  getRequests: async () => {
    const user = JSON.parse(localStorage.getItem('user'));
    const token = user?.accessToken;
    try {
      const response = await axios.get(`${API_URL}request-access_record/`, {
        headers: { Authorization: `Bearer ${token}` },
      });
      return response.data;
    } catch (error) {
      console.error("Error fetching request access data:", error);
      throw error;
    }
  },

  updateRequestStatus: async (requestId, status) => {
    const user = JSON.parse(localStorage.getItem('user'));
    const token = user?.accessToken;
    const profile_id=user?.profileId
    console.log(profile_id)
    try {
      const response = await axios.patch(
        `${API_URL}request-access/${requestId}/`,
        { status, profile_id },
        {
          headers: { Authorization:  `Bearer ${token}` },
        }
      );
      return response.data;
    } catch (error) {
      console.error("Error updating request status:", error);
      throw error;
    }
  },
};

export default RequestAccessService;
