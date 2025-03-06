
import React, { useState, useEffect } from 'react';
import { Outlet, useNavigate } from 'react-router-dom';
import AuthService from '../services/auth.service';
import ProfileService from '../utils/profile.service';
import Topbar from '../components/Topbar';
import Sidebar from '../components/Sidebar';

const Dashboard = () => {
  const [user, setUser] = useState(null);
  const [profile, setProfile] = useState(null);
  const [loading, setLoading] = useState(true);
  const navigate = useNavigate();

  useEffect(() => {
    const fetchUserAndProfile = async () => {
      try {
        const currentUser = AuthService.getCurrentUser();
        console.log('Current user from storage:', currentUser);
        
        if (!currentUser || !currentUser.accessToken) {
          console.log('No user or access token, redirecting to login');
          navigate('/login', { replace: true });
          return;
        }

        setUser(currentUser);

        try {
          const profileData = await ProfileService.fetchUserProfile();
          console.log('Profile data fetched:', profileData);
          setProfile(profileData);
        } catch (profileError) {
          console.error('Error fetching profile:', profileError);
          navigate('/login');
          // Consider whether to redirect on profile fetch error
          // or just log the error and continue
        }
      } catch (error) {
        console.error('Error in fetchUserAndProfile:', error);
      } finally {
        setLoading(false);
      }
    };

    fetchUserAndProfile();
  }, [navigate]);

  if (loading) {
    return <div>Loading...</div>;
  }

  if (!user || !profile) {
    return <div>Error loading user data. Please try logging in again.</div>;
  }

  return (
    <div className="flex h-screen bg-gray-100">
      <Sidebar />
      <div className="flex flex-col flex-1 overflow-hidden">
        <Topbar user={user} profile={profile} />
        <main className="flex-1 overflow-x-hidden overflow-y-auto bg-gray-100">
          <div className="container mx-auto px-6 py-8">
            <Outlet />
          </div>
        </main>
      </div>
    </div>
  );
};

export default Dashboard;