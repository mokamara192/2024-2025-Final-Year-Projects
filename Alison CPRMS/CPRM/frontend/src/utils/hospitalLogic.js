import { useState, useEffect, useCallback } from 'react';
import axios from 'axios';
import { jwtDecode } from 'jwt-decode';

const API_URL = 'http://localhost:8000/api/';

export const useHospitalLogic = () => {
  const [hospitals, setHospitals] = useState([]);
  const [districts, setDistricts] = useState([]);
  const [formData, setFormData] = useState({
    name: '',
    district_id: '',
    hhead_id: '',
    emergency_number: '',
    address: '',
  });
  const [isUpdateMode, setIsUpdateMode] = useState(false);
  const [message, setMessage] = useState({ text: '', type: '' });



  const getAuthHeader = useCallback(() => {
    const user = JSON.parse(localStorage.getItem('user'));
    if (user && user.accessToken) {
      return { Authorization: `Bearer ${user.accessToken}` };
    }
    return {};
  }, []);

  
  const fetchHospitals = useCallback(async (districtId = '') => {
    try {
      const response = await axios.get(`${API_URL}hospitals/${districtId ? `?district=${districtId}` : ''}`, {
        headers: getAuthHeader()
      });
      console.log('Fetched hospitals:', response.data); // Log fetched data
      setHospitals(response.data); // Set the state with the fetched data
    } catch (error) {
      console.error('Error fetching hospitals:', error);
      showMessage('Error fetching hospitals', 'error');
    }
  }, [getAuthHeader]);
  


  const fetchDistricts = useCallback(async () => {
    try {
      const response = await axios.get(`${API_URL}districts/`, {
        headers: getAuthHeader()
      });
      setDistricts(response.data);
    } catch (error) {
      console.error('Error fetching districts:', error);
      showMessage('Error fetching districts', 'error');
    }
  }, [getAuthHeader]);



  const isSuperAdmin = useCallback(() => {
    const user = JSON.parse(localStorage.getItem('user'));
    if (user && user.accessToken) {
      const decodedToken = jwtDecode(user.accessToken);
      return decodedToken.groups.includes('Super Admin');
    }
    return false;
  }, []);



  const checkHospitalHeadGroup = useCallback(async (hheadID) => {
    try {
      const hheadDetails = await axios.get(`${API_URL}hospital-head-profiles/${hheadID}/`, {
        headers: getAuthHeader(),
      });

      console.log('Response data:', hheadDetails);

      // const Hostipatl_Head_ID= hheadDetails.user.id;
      const Hospital_Head_ID = hheadDetails.data.user.id;

      console.log('Response data:', Hospital_Head_ID);

      const response = await axios.get(`${API_URL}user/${Hospital_Head_ID}/group/`, {
        headers: getAuthHeader(),
      });
  
      // Log the response data to the console
      console.log('Response data:', response.data);
  
      // Directly compare the group name with 'Hospital Head'
      return response.data.group === 'Hospital Head';
    } catch (error) {
      console.error('Error checking user group:', error);
      showMessage('Error checking user group', 'error');
      return false;
    }
  }, [getAuthHeader]);
  


  const handleSubmit = async (e) => {
    e.preventDefault();
  
    if (!formData.hhead_id) {
      showMessage('Hospital Head ID is required.', 'error');
      return;
    }
  
    const isHospitalHead = await checkHospitalHeadGroup(formData.hhead_id);
    if (!isHospitalHead) {
      showMessage('The selected user is not in the Hospital Head group.', 'error');
      return;
    }
  
    try {
      const config = { headers: getAuthHeader() };
      console.log('Submitting form data:', formData);

      if (isUpdateMode) {
        await axios.put(`${API_URL}hospitals/${formData.id}/update/`, formData, config);
        fetchHospitals();
        showMessage('Hospital updated successfully', 'success');
        setIsUpdateMode(false);
      } else {
      await axios.post(`${API_URL}hospitals/create/`, formData, config);
      showMessage('Hospital created successfully', 'success');
      fetchHospitals();
      }
    } catch (error) {
      // console.error('Error submitting hospital:', error);
      console.error('Error submitting hospital:', error.response?.data || error.message);

      showMessage(`Error creating hospital: ${error.response?.data?.detail || error.message}`, 'error');
    }
  };


  const handleDelete = async (id) => {
    if (!isSuperAdmin()) {
      showMessage('Only Super Admin users can delete hospitals.', 'error');
      return;
    }
    try {
      await axios.delete(`${API_URL}hospitals/${id}/delete/`, {
        headers: getAuthHeader()
      });
      showMessage('Hospital deleted successfully', 'success');
      fetchHospitals();
    } catch (error) {
      console.error('Error deleting hospital:', error);
      showMessage(`Error deleting hospital: ${error.response?.data?.detail || error.message}`, 'error');
    }
  };



  const handleRowClick = (hospital) => {
    setFormData({
      id: hospital.id,
      name: hospital.name,
      district_id: hospital.district.id,
      hhead_id: hospital.hhead.id,
      emergency_number: hospital.emergency_number,
      address: hospital.address,
    });
    console.log('FormData Hospitaal id ', formData.id);
    setIsUpdateMode(true);
  };




  const handleFilter = (districtId) => {
    fetchHospitals(districtId);
  };




  const showMessage = (text, type) => {
    setMessage({ text, type });
    setTimeout(() => setMessage({ text: '', type: '' }), 5000); // Clear message after 5 seconds
  };



  useEffect(() => {
    fetchHospitals();
    fetchDistricts();
  }, [fetchHospitals, fetchDistricts]);

  return {
    hospitals,
    districts,
    formData,
    setFormData,
    isUpdateMode,
    setIsUpdateMode,
    handleSubmit,
    handleDelete,
    handleRowClick,
    fetchHospitals,
    fetchDistricts,
    isSuperAdmin,
    handleFilter,
    message,
  };
};