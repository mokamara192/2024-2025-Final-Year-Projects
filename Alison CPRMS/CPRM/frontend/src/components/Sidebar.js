import React, { useState } from 'react';
import { Link, useLocation } from 'react-router-dom';
import { 
  HomeIcon,
  UsersIcon, 
  ClipboardDocumentListIcon,
  UserIcon,
  DocumentTextIcon,
  UserGroupIcon,
  UserPlusIcon,
  BuildingOfficeIcon,
  KeyIcon,
  LockClosedIcon,

  ShieldCheckIcon
} from '@heroicons/react/24/outline';
import AuthService from '../services/auth.service';
const SidebarLink = ({ to, icon: Icon, children, isActive, isSidebarOpen }) => (
  <Link
    to={to}
    className={`flex items-center px-3 py-2 rounded-lg transition-all duration-200
      ${isActive 
        ? 'bg-white text-blue-600 shadow-sm' 
        : 'text-gray-700 hover:bg-white/60'
      }
      ${isSidebarOpen ? 'mx-2' : 'mx-1 justify-center'}`
    }
    title={!isSidebarOpen ? children : ''}
  >
    <Icon 
      className={`flex-shrink-0 h-5 w-5 transition-colors duration-200
        ${isActive ? 'text-blue-600' : 'text-gray-500'}
        ${!isSidebarOpen && 'mr-0'}`
      } 
    />
    {isSidebarOpen && (
      <span className="ml-3 text-sm font-medium truncate">{children}</span>
    )}
  </Link>
);

const Sidebar = () => {
  const [isSidebarOpen, setIsSidebarOpen] = useState(true);
  const location = useLocation();
  
  const user = AuthService.getCurrentUser();
  const userRole = user?.groups || "Patient"; // Default role if none found


  const navigation = [
    // Main
    { name: 'Dashboard', to: '/', icon: HomeIcon },
    { name: 'Triage List', to: '/triage-list', icon: ClipboardDocumentListIcon },
    { name: 'Triage', to: '/create-triage', icon: DocumentTextIcon },
    { name: 'Profile', to: '/profile/create', icon: UserIcon },
  
    // Patient Management
    { name: 'Medical History', to: '/patient_medical_history_list', icon: DocumentTextIcon },
    { name: 'Patient', to: '/patients', icon: UserIcon },
  
    // User Management
    { name: 'Create User', to: '/users/create', icon: UserPlusIcon },
    { name: 'Update User', to: '/users', icon: UsersIcon },
    { name: 'User Profile', to: '/users_profile', icon: UserGroupIcon },
  
    // Facility Management
    { name: 'Location', to: '/region-district', icon: MapPinIcon },
    { name: 'Hospital', to: '/hospitals', icon: BuildingOfficeIcon },
  
    // Access Control
    { name: 'Doctor Access', to: '/doctor_access', icon: ShieldCheckIcon },
    { name: 'Request Access', to: '/request-access', icon: KeyIcon },
    { name: 'Record Access', to: '/record-access', icon: LockClosedIcon },
  
    // Settings
    { name: 'Update Credentials', to: '/update_username_password', icon: Cog6ToothIcon },
  ];
  
  const navigationGroups = [
    {
      title: 'Main',
      items: navigation.filter((item, index) => index < 4 && canAccess(userRole, item.to))
    },
    {
      title: 'Patient Management',
      items: navigation.filter((item, index) => index >= 4 && index < 6 && canAccess(userRole, item.to))
    },
    {
      title: 'User Management',
      items: navigation.filter((item, index) => index >= 6 && index < 9 && canAccess(userRole, item.to))
    },
    {
      title: 'Facility Management',
      items: navigation.filter((item, index) => index >= 9 && index < 11 && canAccess(userRole, item.to))
    },
    {
      title: 'Access Control',
      items: navigation.filter((item, index) => index >= 11 && index < 14 && canAccess(userRole, item.to))
    },
    {
      title: 'Settings',
      items: navigation.filter((item, index) => index >= 14 && canAccess(userRole, item.to))
    }
  ];
  
  return (
    <div 
      className={`${
        isSidebarOpen ? 'w-64' : 'w-16'
      } transition-all duration-300 ease-in-out flex flex-col`}
    >
      <div className="flex h-full flex-col bg-blue-50 shadow-lg border-r">
        <div className="flex h-16 flex-shrink-0 items-center justify-between px-3 bg-white border-b">
          <div className={`overflow-hidden transition-all duration-300 ${
            isSidebarOpen ? 'w-40' : 'w-0'
          }`}>
            <img
              className="h-8 w-auto"
              src="/static/logo/welbodi padi_hoz.svg"
              alt="Logo"
            />
          </div>
          
          <button 
            onClick={() => setIsSidebarOpen(!isSidebarOpen)}
            className="p-1.5 rounded-lg bg-gray-50 hover:bg-gray-100 transition-colors duration-200"
            aria-label={isSidebarOpen ? "Collapse sidebar" : "Expand sidebar"}
          >
            {isSidebarOpen ? (
              <ChevronLeftIcon className="h-5 w-5 text-gray-500" />
            ) : (
              <ChevronRightIcon className="h-5 w-5 text-gray-500" />
            )}
          </button>
        </div>

        <div className="flex-1 overflow-y-auto">
          <nav className="flex-1 space-y-4 py-4">
            {navigationGroups.map((group, idx) => (
              group.items.length > 0 && (
                <div key={group.title} className={idx !== 0 ? 'border-t border-gray-200 pt-4' : ''}>
                  {isSidebarOpen && (
                    <h3 className="px-4 text-xs font-semibold text-gray-500 uppercase tracking-wider mb-2">
                      {group.title}
                    </h3>
                  )}
                  <div className="space-y-1">
                    {group.items.map((item) => (
                      <SidebarLink
                        key={item.name}
                        to={item.to}
                        icon={item.icon}
                        isActive={location.pathname === item.to}
                        isSidebarOpen={isSidebarOpen}
                      >
                        {item.name}
                      </SidebarLink>
                    ))}
                  </div>
                </div>
              )
            ))}
          </nav>
        </div>
      </div>
    </div>
  );
};

export default Sidebar;











