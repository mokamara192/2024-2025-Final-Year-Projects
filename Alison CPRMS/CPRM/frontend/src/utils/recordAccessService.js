import axios from "axios";

const API_URL = "http://localhost:8000/api/";

const RecordAccessService = {
  getRecords: async () => {
    const user = JSON.parse(localStorage.getItem('user'));
    const token = user?.accessToken;
    const profile_id=user?.profileId
    try {
      // const response = await axios.get(`${API_URL}record-access/`,
      const response = await axios.get(`${API_URL}record-access/?profile_id=${profile_id}`,
      // {profile_id},
        {
        headers: { Authorization: `Bearer ${token}` },
      }
    );
      console.log("Fetched Records:", response);  // Debugging
      return response.data;
    } catch (error) {
      console.error("Error fetching record access data:", error);
      throw error;
    }
  },
};

export default RecordAccessService;
