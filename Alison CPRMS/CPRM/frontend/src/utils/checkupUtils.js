// src/utils/checkupUtils.js

import AuthService from '../services/auth.service';
import axios from 'axios';

const API_URL = 'http://localhost:8000/api/';

export const createCheckup = async (triageId) => {
  const user = AuthService.getCurrentUser();
  const profile_id=user?.profileId

  if (!user || !user.accessToken) {
    throw new Error('User not authenticated');
  }

  if (!user.groups.includes('Doctor') && !user.groups.includes('Hospital Head') && !user.groups.includes('Super Admin')) {
    throw new Error('Unauthorized to create checkup');
  }

  try {
    const checkupData = {
      doctor_id: profile_id,
      triage_id: triageId,
    };

    const response = await axios.post(`${API_URL}checkups/create/`, checkupData, {
      headers: { Authorization: `Bearer ${user.accessToken}` }
    });
    return response.data;
  } catch (error) {
    console.error('Error creating checkup:', error);
    throw error;
  }
};

export const addSymptom = async (checkupId, symptomData) => {
  const user = AuthService.getCurrentUser();
  if (!user || !user.accessToken) {
    throw new Error('User not authenticated');
  }

  try {
    const completeSymptomData = {
      ...symptomData,
      checkup_id: checkupId,
    };

    const response = await axios.post(`${API_URL}symptoms/create/`, completeSymptomData, {
      headers: { Authorization: `Bearer ${user.accessToken}` }
    });
    return response.data;
  } catch (error) {
    console.error('Error adding symptom:', error);
    throw error;
  }
};

export const addTest = async (checkupId, testData) => {
  const user = AuthService.getCurrentUser();
  if (!user || !user.accessToken) {
    throw new Error('User not authenticated');
  }

  try {
    const formData = new FormData();
    formData.append('checkup_id', checkupId);
    formData.append('test_result', testData.testResult);
    formData.append('test_type', testData.testType);

    const response = await axios.post(`${API_URL}tests/create/`, formData, {
      headers: { 
        'Authorization': `Bearer ${user.accessToken}`,
        'Content-Type': 'multipart/form-data'
      }
    });
    return response.data;
  } catch (error) {
    console.error('Error adding test:', error);
    throw error;
  }
};

export const addDiagnosis = async (checkupId, diagnosisData) => {
  const user = AuthService.getCurrentUser();
  if (!user || !user.accessToken) {
    throw new Error('User not authenticated');
  }

  try {
    const completeDiagnosisData = {
      ...diagnosisData,
      checkup_id: checkupId,
    };

    const response = await axios.post(`${API_URL}diagnoses/create/`, completeDiagnosisData, {
      headers: { Authorization: `Bearer ${user.accessToken}` }
    });
    return response.data;
  } catch (error) {
    console.error('Error adding diagnosis:', error);
    throw error;
  }
};

export const createPrescription = async (checkupId, prescriptionData) => {
  const user = AuthService.getCurrentUser();
  if (!user || !user.accessToken) {
    throw new Error('User not authenticated');
  }

  try {
    const completePrescriptionData = {
      ...prescriptionData,
      checkup_id: checkupId,
    };

    const response = await axios.post(`${API_URL}prescriptions/create/`, completePrescriptionData, {
      headers: { Authorization: `Bearer ${user.accessToken}` }
    });
    return response.data;
  } catch (error) {
    console.error('Error creating prescription:', error);
    throw error;
  }
};

export const addMedicine = async (prescriptionId, medicineData) => {
  const user = AuthService.getCurrentUser();
  if (!user || !user.accessToken) {
    throw new Error('User not authenticated');
  }

  try {
    const completeMedicineData = {
      ...medicineData,
      prescription_id: prescriptionId,
    };

    const response = await axios.post(`${API_URL}medicines/create/`, completeMedicineData, {
      headers: { Authorization: `Bearer ${user.accessToken}` }
    });
    return response.data;
  } catch (error) {
    console.error('Error adding medicine:', error);
    throw error;
  }
};