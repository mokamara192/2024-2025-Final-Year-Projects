import { useState, useEffect, useCallback } from 'react';
import axios from 'axios';
import AuthService from '../services/auth.service'; // Ensure AuthService is properly imported

const useRegionDistrictLogic = () => {
  const [regions, setRegions] = useState([]);
  const [districts, setDistricts] = useState([]);
  const [regionForm, setRegionForm] = useState({ name: '', id: null });
  const [districtForm, setDistrictForm] = useState({ name: '', region_id: '', id: null });
  const [isUpdatingRegion, setIsUpdatingRegion] = useState(false);
  const [isUpdatingDistrict, setIsUpdatingDistrict] = useState(false);
  const [notification, setNotification] = useState(null);

  // Function to get the authorization header
  const getAuthHeader = () => {
    const user = AuthService.getCurrentUser();
    if (user && user.accessToken) {
      return { Authorization: `Bearer ${user.accessToken}` };
    }
    return {};
  };

  const showNotification = (message, type = 'success') => {
    setNotification({ message, type });
    setTimeout(() => setNotification(null), 3000);
  };

  const fetchRegions = useCallback(async () => {
    try {
      const response = await axios.get('http://localhost:8000/api/regions/', {
        headers: getAuthHeader() // Include Authorization header
      });
      setRegions(response.data);
    } catch (error) {
      console.error('Error fetching regions:', error);
      showNotification('Failed to fetch regions', 'error');
    }
  }, []);

  const fetchDistricts = useCallback(async () => {
    try {
      const response = await axios.get('http://localhost:8000/api/districts/', {
        headers: getAuthHeader() // Include Authorization header
      });
      setDistricts(response.data);
    } catch (error) {
      console.error('Error fetching districts:', error);
      showNotification('Failed to fetch districts', 'error');
    }
  }, []);

  useEffect(() => {
    fetchRegions();
    fetchDistricts();
  }, [fetchRegions, fetchDistricts]);

  const handleRegionSubmit = async (e) => {
    e.preventDefault();
    try {
      if (isUpdatingRegion) {
        await axios.put(`http://localhost:8000/api/regions/${regionForm.id}/update/`, 
          { name: regionForm.name },
          { headers: getAuthHeader() } // Include Authorization header
        );
        showNotification('Region updated successfully');
      } else {
        await axios.post('http://localhost:8000/api/regions/create/', 
          { name: regionForm.name },
          { headers: getAuthHeader() } // Include Authorization header
        );
        showNotification('Region created successfully');
      }
      fetchRegions();
      resetRegionForm();
    } catch (error) {
      console.error('Error submitting region:', error);
      showNotification('Failed to submit region', 'error');
    }
  };

  const handleDistrictSubmit = async (e) => {
    e.preventDefault();
    try {
      if (isUpdatingDistrict) {
        await axios.put(`http://localhost:8000/api/districts/${districtForm.id}/update/`, {
          name: districtForm.name,
          region_id: districtForm.region_id
        }, {
          headers: getAuthHeader() // Include Authorization header
        });
        showNotification('District updated successfully');
      } else {
        await axios.post('http://localhost:8000/api/districts/create/', {
          name: districtForm.name,
          region_id: districtForm.region_id
        }, {
          headers: getAuthHeader() // Include Authorization header
        });
        showNotification('District created successfully');
      }
      fetchDistricts();
      resetDistrictForm();
    } catch (error) {
      console.error('Error submitting district:', error);
      showNotification('Failed to submit district', 'error');
    }
  };

  const handleRegionDelete = async (id) => {
    try {
      await axios.delete(`http://localhost:8000/api/regions/${id}/delete/`, {
        headers: getAuthHeader() // Include Authorization header
      });
      fetchRegions();
      showNotification('Region deleted successfully');
    } catch (error) {
      console.error('Error deleting region:', error);
      showNotification('Failed to delete region', 'error');
    }
  };

  const handleDistrictDelete = async (id) => {
    try {
      await axios.delete(`http://localhost:8000/api/districts/${id}/delete/`, {
        headers: getAuthHeader() // Include Authorization header
      });
      fetchDistricts();
      showNotification('District deleted successfully');
    } catch (error) {
      console.error('Error deleting district:', error);
      showNotification('Failed to delete district', 'error');
    }
  };

  const selectRegionForUpdate = (region) => {
    setRegionForm({ name: region.name, id: region.id });
    setIsUpdatingRegion(true);
  };

  const selectDistrictForUpdate = (district) => {
    setDistrictForm({ name: district.name, region_id: district.region.id, id: district.id });
    setIsUpdatingDistrict(true);
  };

  const resetRegionForm = () => {
    setRegionForm({ name: '', id: null });
    setIsUpdatingRegion(false);
  };

  const resetDistrictForm = () => {
    setDistrictForm({ name: '', region_id: '', id: null });
    setIsUpdatingDistrict(false);
  };

  return {
    regions,
    districts,
    regionForm,
    districtForm,
    isUpdatingRegion,
    isUpdatingDistrict,
    notification,
    setRegionForm,
    setDistrictForm,
    handleRegionSubmit,
    handleDistrictSubmit,
    handleRegionDelete,
    handleDistrictDelete,
    selectRegionForUpdate,
    selectDistrictForUpdate,
    resetRegionForm,
    resetDistrictForm
  };
};

export default useRegionDistrictLogic;
