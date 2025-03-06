import React, { useState, useRef, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { 
  BellIcon, 
  UserCircleIcon,
  ChevronDownIcon,
  ArrowRightOnRectangleIcon,
  UserIcon
} from '@heroicons/react/24/outline';
import AuthService from '../services/auth.service';
import NotificationService from '../services/notification.service';

const Topbar = ({ user, profile }) => {
  const [isProfileMenuOpen, setIsProfileMenuOpen] = useState(false);
  const [isNotificationsOpen, setIsNotificationsOpen] = useState(false);
  const [notifications, setNotifications] = useState([]);
  const [unreadCount, setUnreadCount] = useState(0);
  const menuRef = useRef(null);
  const navigate = useNavigate();
  const profileId = user?.profileId;
  const userRole = user?.groups;

  useEffect(() => {
    if (profileId && (userRole === "Doctor" || userRole === "Patient")) {
      fetchNotifications();
    }
  }, [profileId, userRole]);

  const fetchNotifications = async () => {
    try {
      const data = await NotificationService.getNotifications(profileId);
      setNotifications(data.notifications);
      setUnreadCount(data.notifications.filter(n => !n.read).length);
    } catch (error) {
      console.error("Error fetching notifications:", error);
    }
  };
  const handleLogout = () => {
    AuthService.logout();
    window.location.reload();
  };

  const handleViewProfile = () => {
    const loggedInUserId = profile?.user_id;
    if (loggedInUserId) {
      navigate(`/profile/${loggedInUserId}`);
      setIsProfileMenuOpen(false);
    } else {
      navigate('/profile');
    }
  };
  const markAsRead = async (notificationId, notificationType) => {
    try {
      await NotificationService.markNotificationAsRead(notificationId, notificationType);
      setNotifications((prev) => prev.map(n => n.id === notificationId ? { ...n, read: true } : n));
      setUnreadCount((prev) => prev - 1);
    } catch (error) {
      console.error("Error marking notification as read:", error);
    }
  };

  return (
    <header className="bg-white shadow-sm border-b border-gray-200">
      <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
        <div className="flex justify-between h-16">
          <div className="flex items-center">
            <img className="h-8 w-auto" src="/static/logo/welbodi padi.svg" alt="Logo" />
          </div>
          <div className="flex items-center space-x-4" ref={menuRef}>
            {(userRole === "Doctor" || userRole === "Patient") && (
              <div className="relative">
                <button onClick={() => setIsNotificationsOpen(!isNotificationsOpen)}
                  className="relative p-2 rounded-full text-gray-400 hover:text-gray-500 hover:bg-gray-100">
                  <BellIcon className="h-6 w-6" />
                  {unreadCount > 0 && (
                    <span className="absolute -top-1 -right-1 h-4 w-4 rounded-full bg-red-500 flex items-center justify-center text-xs text-white">
                      {unreadCount}
                    </span>
                  )}
                </button>
                {isNotificationsOpen && (
                  <div className="absolute right-0 mt-2 w-80 bg-white shadow-lg rounded-lg ring-1 ring-black ring-opacity-5">
                    <div className="p-4">
                      <h3 className="text-sm font-medium text-gray-900">Notifications</h3>
                      <div className="mt-2 divide-y divide-gray-100 max-h-60 overflow-y-auto">
                        {notifications.length > 0 ? (
                          notifications.map(notif => (
                            <div key={notif.id} className="py-3 cursor-pointer hover:bg-gray-100"
                              onClick={() => markAsRead(notif.id, userRole === "Doctor" ? "doctor" : "patient")}
                            >
                              <p className="text-sm text-gray-600">{notif.message}</p>
                              <p className="text-xs text-gray-400 mt-1">{new Date(notif.created_at).toLocaleString()}</p>
                            </div>
                          ))
                        ) : (
                          <p className="text-sm text-gray-500">No new notifications</p>
                        )}
                      </div>
                    </div>
                  </div>
                )}
              </div>
            )}
{/* Profile section */}
<div className="relative flex items-center">
              {/* Profile button */}
              <button
                onClick={() => setIsProfileMenuOpen(!isProfileMenuOpen)}
                className="flex items-center space-x-2 p-2 rounded-lg hover:bg-gray-100 transition-colors duration-200"
              >
                <div className="relative">
                  {profile?.profile_picture_url ? (
                    <img
                      className="h-8 w-8 rounded-full object-cover ring-2 ring-white"
                      src={profile.profile_picture_url}
                      alt="Profile"
                    />
                  ) : (
                    <UserCircleIcon className="h-8 w-8 text-gray-400" />
                  )}
                  <div className="absolute bottom-0 right-0 h-3 w-3 rounded-full bg-green-400 ring-2 ring-white" />
                </div>
                <div className="hidden md:block text-left">
                  <div className="text-sm font-medium text-gray-700">
                    {`${profile.first_name} ${profile.last_name}`}
                  </div>
                  <div className="text-xs text-gray-500">{user.groups}</div>
                </div>
                <ChevronDownIcon className="h-5 w-5 text-gray-400" />
              </button>

              {/* Profile dropdown */}
              {isProfileMenuOpen && (
                <div className="absolute right-0 top-full mt-2 w-48 rounded-lg bg-white shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none">
                  <div className="py-1">
                    <button
                      onClick={handleViewProfile}
                      className="flex items-center w-full px-4 py-2 text-sm text-gray-700 hover:bg-gray-100"
                    >
                      <UserIcon className="h-4 w-4 mr-3 text-gray-400" />
                      Your Profile
                    </button>
                    {/* <button
                      onClick={() => navigate('/settings')}
                      className="flex items-center w-full px-4 py-2 text-sm text-gray-700 hover:bg-gray-100"
                    >
                      <Cog6ToothIcon className="h-4 w-4 mr-3 text-gray-400" />
                      Settings
                    </button> */}
                    <div className="border-t border-gray-100" />
                    <button
                      onClick={handleLogout}
                      className="flex items-center w-full px-4 py-2 text-sm text-red-600 hover:bg-gray-100"
                    >
                      <ArrowRightOnRectangleIcon className="h-4 w-4 mr-3 text-red-400" />
                      Sign out
                    </button>
                  </div>
                </div>
              )}
            </div>
          </div>
        </div>
      </div>
    </header>
  );
};

export default Topbar;
















// import React, { useState, useRef, useEffect } from 'react';
// import { useNavigate } from 'react-router-dom';
// import { 
//   BellIcon, 
//   UserCircleIcon,
//   ChevronDownIcon,
//   Cog6ToothIcon,
//   ArrowRightOnRectangleIcon,
//   UserIcon
// } from '@heroicons/react/24/outline';
// import AuthService from '../services/auth.service';

// const NotificationBadge = () => (
//   <span className="absolute -top-1 -right-1 h-4 w-4 rounded-full bg-red-500 flex items-center justify-center">
//     <span className="text-xs text-white">3</span>
//   </span>
// );

// const Topbar = ({ user, profile }) => {
//   const [isProfileMenuOpen, setIsProfileMenuOpen] = useState(false);
//   const [isNotificationsOpen, setIsNotificationsOpen] = useState(false);
//   const menuRef = useRef(null);
//   const navigate = useNavigate();

//   // Close menus when clicking outside
//   useEffect(() => {
//     const handleClickOutside = (event) => {
//       if (menuRef.current && !menuRef.current.contains(event.target)) {
//         setIsProfileMenuOpen(false);
//         setIsNotificationsOpen(false);
//       }
//     };

//     document.addEventListener('mousedown', handleClickOutside);
//     return () => document.removeEventListener('mousedown', handleClickOutside);
//   }, []);

//   const handleLogout = () => {
//     AuthService.logout();
//     window.location.reload();
//   };

//   const handleViewProfile = () => {
//     const loggedInUserId = profile?.user_id;
//     if (loggedInUserId) {
//       navigate(`/profile/${loggedInUserId}`);
//       setIsProfileMenuOpen(false);
//     } else {
//       navigate('/profile');
//     }
//   };

//   // Mock notifications - replace with real data
//   const notifications = [
//     { id: 1, text: "New patient admission", time: "5m ago" },
//     { id: 2, text: "Medical record updated", time: "1h ago" },
//     { id: 3, text: "Staff meeting reminder", time: "2h ago" },
//   ];

//   return (
//     <header className="bg-white shadow-sm border-b border-gray-200">
//       <div className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
//         <div className="flex justify-between h-16">
//           {/* Left side - Logo */}
//           <div className="flex items-center">
//             <img 
//               className="h-8 w-auto" 
//               src="/static/logo/welbodi padi.svg" 
//               alt="Logo" 
//             />
//           </div>

//           {/* Right side - User section */}
//           <div className="flex items-center space-x-4" ref={menuRef}>
//             {/* Notifications */}
//             <div className="relative">
//               <button 
//                 onClick={() => setIsNotificationsOpen(!isNotificationsOpen)}
//                 className="relative p-2 rounded-full text-gray-400 hover:text-gray-500 hover:bg-gray-100 transition-colors duration-200"
//               >
//                 <BellIcon className="h-6 w-6" />
//                 <NotificationBadge />
//               </button>

//               {/* Notifications dropdown */}
//               {isNotificationsOpen && (
//                 <div className="absolute right-0 mt-2 w-80 rounded-lg bg-white shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none">
//                   <div className="p-4">
//                     <h3 className="text-sm font-medium text-gray-900">Notifications</h3>
//                     <div className="mt-2 divide-y divide-gray-100">
//                       {notifications.map((notification) => (
//                         <div key={notification.id} className="py-3">
//                           <p className="text-sm text-gray-600">{notification.text}</p>
//                           <p className="text-xs text-gray-400 mt-1">{notification.time}</p>
//                         </div>
//                       ))}
//                     </div>
//                   </div>
//                 </div>
//               )}
//             </div>

//             {/* Profile section */}
//             <div className="relative flex items-center">
//               {/* Profile button */}
//               <button
//                 onClick={() => setIsProfileMenuOpen(!isProfileMenuOpen)}
//                 className="flex items-center space-x-2 p-2 rounded-lg hover:bg-gray-100 transition-colors duration-200"
//               >
//                 <div className="relative">
//                   {profile?.profile_picture_url ? (
//                     <img
//                       className="h-8 w-8 rounded-full object-cover ring-2 ring-white"
//                       src={profile.profile_picture_url}
//                       alt="Profile"
//                     />
//                   ) : (
//                     <UserCircleIcon className="h-8 w-8 text-gray-400" />
//                   )}
//                   <div className="absolute bottom-0 right-0 h-3 w-3 rounded-full bg-green-400 ring-2 ring-white" />
//                 </div>
//                 <div className="hidden md:block text-left">
//                   <div className="text-sm font-medium text-gray-700">
//                     {`${profile.first_name} ${profile.last_name}`}
//                   </div>
//                   <div className="text-xs text-gray-500">{user.groups}</div>
//                 </div>
//                 <ChevronDownIcon className="h-5 w-5 text-gray-400" />
//               </button>

//               {/* Profile dropdown */}
//               {isProfileMenuOpen && (
//                 <div className="absolute right-0 top-full mt-2 w-48 rounded-lg bg-white shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none">
//                   <div className="py-1">
//                     <button
//                       onClick={handleViewProfile}
//                       className="flex items-center w-full px-4 py-2 text-sm text-gray-700 hover:bg-gray-100"
//                     >
//                       <UserIcon className="h-4 w-4 mr-3 text-gray-400" />
//                       Your Profile
//                     </button>
//                     {/* <button
//                       onClick={() => navigate('/settings')}
//                       className="flex items-center w-full px-4 py-2 text-sm text-gray-700 hover:bg-gray-100"
//                     >
//                       <Cog6ToothIcon className="h-4 w-4 mr-3 text-gray-400" />
//                       Settings
//                     </button> */}
//                     <div className="border-t border-gray-100" />
//                     <button
//                       onClick={handleLogout}
//                       className="flex items-center w-full px-4 py-2 text-sm text-red-600 hover:bg-gray-100"
//                     >
//                       <ArrowRightOnRectangleIcon className="h-4 w-4 mr-3 text-red-400" />
//                       Sign out
//                     </button>
//                   </div>
//                 </div>
//               )}
//             </div>
//           </div>
//         </div>
//       </div>
//     </header>
//   );
// };

// export default Topbar;
