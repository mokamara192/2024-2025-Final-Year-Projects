import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import AuthService from '../services/auth.service';
import ProfileService from '../utils/profile.service';
import { Card, CardHeader, CardContent } from '../components/card';

const ProfilePage = () => {
  const [profile, setProfile] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const navigate = useNavigate();

  useEffect(() => {
    const fetchData = async () => {
      try {
        const currentUser = AuthService.getCurrentUser();
        if (!currentUser) {
          navigate('/login');
          return;
        }

        const profileData = await ProfileService.fetchUserProfile();
        setProfile(profileData);
      } catch (err) {
        setError('Failed to fetch profile data. Please try again later.');
        console.error('Error:', err);
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, [navigate]);

  if (loading) return <div>Loading...</div>;
  if (error) return <div className="text-red-500">{error}</div>;
  if (!profile) return <div>No profile data available.</div>;

  const renderProfileInfo = () => {
    const commonFields = (
      <>
        <p><strong>Name:</strong> {profile.first_name || 'N/A'} {profile.middle_name ? profile.middle_name + ' ' : ''}{profile.last_name || 'N/A'}</p>
        <p><strong>Phone:</strong> {profile.phone_number || 'N/A'}</p>
        <p><strong>Address:</strong> {profile.address || 'N/A'}</p>
        {profile.profile_picture_url && (
          <img src={profile.profile_picture_url} alt="Profile" className="max-w-[200px] max-h-[200px] mt-4" />
        )}
      </>
    );

    const additionalFields = {
      Patient: (
        <>
          <p><strong>Date of Birth:</strong> {profile.date_of_birth || 'N/A'}</p>
          <p><strong>Age:</strong> {profile.age || 'N/A'}</p>
          <p><strong>Gender:</strong> {profile.gender || 'N/A'}</p>
          <p><strong>Emergency Contact:</strong> {profile.emergency_contact_name || 'N/A'} ({profile.emergency_contact_number || 'N/A'})</p>
          <p><strong>Blood Type:</strong> {profile.blood_type || 'N/A'}</p>
          <p><strong>Medical Info:</strong> {profile.medical_info || 'N/A'}</p>
        </>
      ),
      Staff: (
        <>
          <p><strong>Hospital:</strong> {profile.hospital?.name || 'N/A'}</p>
          <p><strong>Specialty:</strong> {profile.specialty || 'N/A'}</p>
          <p><strong>Hire Date:</strong> {profile.hire_date || 'N/A'}</p>
        </>
      )
    };

    const groupSpecificFields = additionalFields[profile.group] || null;

    return (
      <>
        {commonFields}
        {groupSpecificFields}
      </>
    );
  };

  return (
    <Card className="w-full max-w-2xl mx-auto mt-8">
      <CardHeader>
        <h1 className="text-2xl font-bold">Profile Information</h1>
      </CardHeader>
      <CardContent>
        <p><strong>Username:</strong> {profile.username || 'N/A'}</p>
        <p><strong>Email:</strong> {profile.email || 'N/A'}</p>
        <p><strong>Group:</strong> {profile.group || 'N/A'}</p>
        {renderProfileInfo()}
      </CardContent>
    </Card>
  );
};

export default ProfilePage;