import axios from 'axios';

export const getAvailableGroups = async () => {
  const user = JSON.parse(localStorage.getItem('user'));
  console.log('User from localStorage:', user);
  
  if (!user || !user.accessToken) {
    console.error('No user or access token found in localStorage');
    return [];
  }

  console.log('Access token:', user.accessToken);

  try {
    const response = await axios.get('http://localhost:8000/api/get_available_groups/', {
      headers: { Authorization: `Bearer ${user.accessToken}` }
    });

    console.log('Response:', response);
    return response.data.available_groups;
  } catch (error) {
    console.error('Error fetching available groups:', error.response ? error.response.data : error.message);
    return [];
  }
};

export const populateGroupDropdown = async () => {
  const groups = await getAvailableGroups();
  return groups.map(group => ({ 
    value: group.id, 
    label: group.name 
  }));
};