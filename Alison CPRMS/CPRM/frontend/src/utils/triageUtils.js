// src/utils/triageUtils.js

import AuthService from '../services/auth.service';
import axios from 'axios';

const API_URL = 'http://localhost:8000/api/';
// const [currentUserGroup, setCurrentUserGroup] = useState('');

export const createTriage = async (triageData) => {
  const user = AuthService.getCurrentUser();
  const profile_id=user?.profileId

  if (!user || !user.accessToken) {
    throw new Error('User not authenticated');
  }

  try {
    const hospitalId = await getHospitalId(user.id);
    const completeTriageData = {
      ...triageData,
      staff_id: profile_id,
      hospital_id: hospitalId,
    };
    const response = await axios.post(`${API_URL}triages/create/`, completeTriageData, {
      headers: { Authorization: `Bearer ${user.accessToken}` }
    });
    return response.data;
  } catch (error) {
    console.error('Error creating triage:', error);
    throw error;
  }
};

export const getHospitalId = async (userId) => {
  const user = AuthService.getCurrentUser();
  let endpoint='';
  if (!user || !user.accessToken) {
    throw new Error('User not authenticated');
  }

  try {
    if (user.groups === 'Hospital Head') {
        endpoint = `${API_URL}get-hospital-by-hospitalhead/`;

    }
    else if (user.groups === 'Nurse' || user.groups === 'Doctor' ){
        endpoint = `${API_URL}get-hospital-by-staffid/`;
    }


    const response = await axios.get(`${endpoint}${userId}/`, {
      headers: { Authorization: `Bearer ${user.accessToken}` }
    });
    return response.data.hospital_id;
  } catch (error) {
    console.error('Error fetching hospital ID:', error);
    throw error;
  }
};

export const getTriageList = async () => {
  const user = AuthService.getCurrentUser();
  if (!user || !user.accessToken) {
    throw new Error('User not authenticated');
  }

  try {
    const hospitalId = await getHospitalId(user.id);
    const response = await axios.get(`${API_URL}triage/hospital/${hospitalId}/`, {
      headers: { Authorization: `Bearer ${user.accessToken}` }
    });
    return response.data.filter(triage => !triage.checkup);
  } catch (error) {
    console.error('Error fetching triage list:', error);
    throw error;
  }
};

export const deleteTriage = async (triageId) => {
  const user = AuthService.getCurrentUser();
  if (!user || !user.accessToken) {
    throw new Error('User not authenticated');
  }

  try {
    await axios.delete(`${API_URL}triages/${triageId}/delete/`, {
      headers: { Authorization: `Bearer ${user.accessToken}` }
    });
  } catch (error) {
    console.error('Error deleting triage:', error);
    throw error;
  }
};