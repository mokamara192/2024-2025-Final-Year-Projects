import React, { useState, useEffect } from "react";
import axios from "axios";
import { 
  Bars3Icon, 
  XMarkIcon, 
  ChartBarIcon, 
  UsersIcon, 
  BuildingOfficeIcon, 
  BellIcon, 
  ClipboardIcon,
  UserCircleIcon,
  ArrowUpIcon,
  ArrowDownIcon,
  Cog6ToothIcon,
  HomeIcon
} from "@heroicons/react/24/outline";
import { ResponsiveContainer, BarChart, Bar, XAxis, YAxis, CartesianGrid, Tooltip, Legend, LineChart, Line, Area, AreaChart } from "recharts";

const API_URL = "http://localhost:8000/api/";

const DashboardLayout = () => {
  const [user, setUser] = useState(null);
  const [dashboardData, setDashboardData] = useState(null);
  const [loading, setLoading] = useState(true);
  const [sidebarOpen, setSidebarOpen] = useState(true);
  const [error, setError] = useState(null);
  const [timeRange, setTimeRange] = useState('7days');

  useEffect(() => {
    const fetchDashboardData = async () => {
      try {
        setLoading(true);
        // Get user from localStorage
        const userData = JSON.parse(localStorage.getItem("user"));
        setUser(userData);

        if (!userData || !userData.accessToken) {
          throw new Error("Authentication required. Please log in.");
        }

        // Fetch dashboard data with auth token
        const response = await axios.get(`${API_URL}dashboard-stats/`, {
          headers: { 
            Authorization: `Bearer ${userData.accessToken}`,
            'Content-Type': 'application/json'
          },
          params: {
            timeRange: timeRange
          }
        });

        if (response.data) {
          setDashboardData(response.data);
          setError(null);
        } else {
          throw new Error("No data received from server");
        }

      } catch (error) {
        console.error("Dashboard data fetch error:", error);
        
        if (error.response?.status === 401) {
          setError("Session expired. Please log in again.");
          // Optionally redirect to login
          // window.location.href = '/login';
        } else if (error.response?.status === 403) {
          setError("You don't have permission to access this dashboard.");
        } else {
          setError(error.message || "Failed to load dashboard data.");
        }
      } finally {
        setLoading(false);
      }
    };

    fetchDashboardData();
  }, [timeRange]);

  const StatCard = ({ title, value,  icon: Icon }) => (
    <div className="bg-white rounded-xl shadow-sm hover:shadow-md transition-shadow duration-300 p-6 border border-gray-100">
      <div className="flex items-center justify-between">
        <div className="flex items-center space-x-4">
          <div className="p-3 bg-blue-50 rounded-lg">
            <Icon className="w-6 h-6 text-blue-500" />
          </div>
          <div>
            <h3 className="text-sm font-medium text-gray-500">{title}</h3>
            <div className="flex items-baseline space-x-2">
              <p className="text-2xl font-bold text-gray-900">{value.toLocaleString()}</p>
              {/* {trend && (
                <span className={`flex items-center text-sm font-medium ${trend === 'up' ? 'text-green-500' : 'text-red-500'}`}>
                  {trend === 'up' ? <ArrowUpIcon className="w-4 h-4 mr-1" /> : <ArrowDownIcon className="w-4 h-4 mr-1" />}
                  {percentage}%
                </span>
              )} */}
            </div>
          </div>
        </div>
      </div>
    </div>
  );

  const TopDiseasesChart = ({ data }) => (
    <div className="bg-white rounded-xl shadow-sm p-6 border border-gray-100">
      <div className="flex items-center justify-between mb-6">
        <h2 className="text-lg font-semibold text-gray-900">Disease Trends</h2>
        <select 
          className="text-sm border-gray-200 rounded-lg focus:ring-blue-500"
          value={timeRange}
          onChange={(e) => setTimeRange(e.target.value)}
        >
          <option value="7days">Last 7 days</option>
          <option value="30days">Last 30 days</option>
          <option value="90days">Last 90 days</option>
        </select>
      </div>
      <ResponsiveContainer width="100%" height={300}>
        <AreaChart data={data} margin={{ top: 10, right: 30, left: 0, bottom: 0 }}>
          <defs>
            <linearGradient id="colorCases" x1="0" y1="0" x2="0" y2="1">
              <stop offset="5%" stopColor="#3b82f6" stopOpacity={0.1}/>
              <stop offset="95%" stopColor="#3b82f6" stopOpacity={0}/>
            </linearGradient>
          </defs>
          <CartesianGrid strokeDasharray="3 3" stroke="#f3f4f6" />
          <XAxis 
            dataKey="name" 
            stroke="#6b7280"
            tick={{ fill: '#6b7280', fontSize: 12 }}
          />
          <YAxis 
            stroke="#6b7280"
            tick={{ fill: '#6b7280', fontSize: 12 }}
          />
          <Tooltip 
            contentStyle={{ 
              backgroundColor: '#fff',
              border: '1px solid #e5e7eb',
              borderRadius: '8px',
              boxShadow: '0 2px 4px rgba(0,0,0,0.1)'
            }}
          />
          <Area 
            type="monotone" 
            dataKey="cases" 
            stroke="#3b82f6" 
            fillOpacity={1} 
            fill="url(#colorCases)" 
          />
        </AreaChart>
      </ResponsiveContainer>
    </div>
  );

  const HospitalPerformanceChart = ({ data }) => (
    <div className="bg-white rounded-xl shadow-sm p-6 border border-gray-100">
      <div className="flex items-center justify-between mb-6">
        <h2 className="text-lg font-semibold text-gray-900">Hospital Performance</h2>
        <div className="flex items-center space-x-2">
          <span className="w-3 h-3 bg-blue-500 rounded-full"></span>
          <span className="text-sm text-gray-500">Total Cases</span>
        </div>
      </div>
      <ResponsiveContainer width="100%" height={300}>
        <LineChart data={data} margin={{ top: 10, right: 30, left: 0, bottom: 0 }}>
          <CartesianGrid strokeDasharray="3 3" stroke="#f3f4f6" />
          <XAxis 
            dataKey="name" 
            stroke="#6b7280"
            tick={{ fill: '#6b7280', fontSize: 12 }}
          />
          <YAxis 
            stroke="#6b7280"
            tick={{ fill: '#6b7280', fontSize: 12 }}
          />
          <Tooltip
            contentStyle={{
              backgroundColor: '#fff',
              border: '1px solid #e5e7eb',
              borderRadius: '8px',
              boxShadow: '0 2px 4px rgba(0,0,0,0.1)'
            }}
          />
          <Line 
            type="monotone" 
            dataKey="total_cases" 
            stroke="#3b82f6" 
            strokeWidth={2}
            dot={{ stroke: '#3b82f6', strokeWidth: 2, r: 4 }}
            activeDot={{ r: 6, stroke: '#3b82f6', strokeWidth: 2 }}
          />
        </LineChart>
      </ResponsiveContainer>
    </div>
  );

  const PatientList = ({ data }) => (
    <div className="bg-white rounded-xl shadow-sm p-6 border border-gray-100">
      <div className="flex items-center justify-between mb-4">
        <h2 className="text-lg font-semibold text-gray-900">Recent Patients</h2>
        <button className="text-sm text-blue-500 hover:text-blue-600">View all</button>
      </div>
      <div className="divide-y divide-gray-100">
        {data.map((patient, index) => (
          <div key={index} className="py-4 flex items-center justify-between">
            <div className="flex items-center space-x-3">
              <div className="h-10 w-10 rounded-full bg-gray-100 flex items-center justify-center">
                <UserCircleIcon className="h-6 w-6 text-gray-400" />
              </div>
              <div>
                <p className="font-medium text-gray-900">
                  {patient.patient__first_name} {patient.patient__last_name}
                </p>
                <p className="text-sm text-gray-500">
                  Last visit: {new Date(patient.last_visit).toLocaleDateString()}
                </p>
              </div>
            </div>
            <button className="text-sm text-blue-500 hover:text-blue-600 font-medium">
              View Details
            </button>
          </div>
        ))}
      </div>
    </div>
  );

  const RecentCheckups = ({ data }) => (
    <div className="bg-white rounded-xl shadow-sm p-6 border border-gray-100">
      <div className="flex items-center justify-between mb-4">
        <h2 className="text-lg font-semibold text-gray-900">Recent Checkups</h2>
        <button className="text-sm text-blue-500 hover:text-blue-600">View all</button>
      </div>
      {data.length === 0 ? (
        <div className="text-center py-8">
          <div className="mx-auto h-12 w-12 text-gray-400">
            <ClipboardIcon className="h-12 w-12" />
          </div>
          <h3 className="mt-2 text-sm font-medium text-gray-900">No checkups</h3>
          <p className="mt-1 text-sm text-gray-500">No recent checkups found.</p>
          {/* <button className="mt-4 text-sm font-medium text-blue-500 hover:text-blue-600">
            Schedule Checkup
          </button> */}
        </div>
      ) : (
        <div className="divide-y divide-gray-100">
          {data.map((checkup, index) => (
            <div key={index} className="py-4">
              <div className="flex items-center justify-between">
                <div>
                  <p className="font-medium text-gray-900">
                    Dr. {checkup.doctor__first_name} {checkup.doctor__last_name}
                  </p>
                  <p className="text-sm text-gray-500">
                    {new Date(checkup.date).toLocaleDateString()}
                  </p>
                </div>
                <span className={`
                  px-3 py-1 rounded-full text-sm font-medium
                  ${checkup.status === "completed" 
                    ? "bg-green-100 text-green-800" 
                    : "bg-yellow-100 text-yellow-800"}
                `}>
                  {checkup.status}
                </span>
              </div>
            </div>
          ))}
        </div>
      )}
    </div>
  );

  const renderDashboardContent = () => {
    if (!dashboardData) return null;

    switch (dashboardData.role) {
      case "Super Admin":
        return (
          <div className="space-y-6">
            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
              <StatCard 
                title="Total Hospitals" 
                value={dashboardData.totalHospitals}
                // trend="up"
                // percentage="12"
                icon={BuildingOfficeIcon}
              />
              <StatCard 
                title="Total Staff" 
                value={dashboardData.totalStaff}
                // trend="up"
                // percentage="8"
                icon={UsersIcon}
              />
              <StatCard 
                title="Total Patients" 
                value={dashboardData.totalPatients}
                // trend="down"
                // percentage="3"
                icon={UserCircleIcon}
              />
            </div>
            <div className="grid grid-cols-1 lg:grid-cols-2 gap-6">
              <TopDiseasesChart data={dashboardData.topDiseases} />
              <HospitalPerformanceChart data={dashboardData.topHospitals} />
            </div>
            {/* <div className="grid grid-cols-1 lg:grid-cols-2 gap-6">
              <PatientList data={dashboardData.recentPatients || []} />
              <RecentCheckups data={dashboardData.recentCheckups || []} />
            </div> */}
          </div>
        );

      case "Hospital Head / Admin":
        return (
          <div className="space-y-6">
            <h1 className="text-2xl font-bold text-gray-900">
              {dashboardData.hospitalName} Overview
            </h1>
            <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
              <StatCard 
                title="Total Staff" 
                value={dashboardData.totalStaff}
                // trend="up"
                // percentage="5"
                icon={UsersIcon}
              />
              <StatCard 
                title="Total Patients" 
                value={dashboardData.totalPatients}
                trend="up"
                percentage="8"
                icon={UserCircleIcon}
              />
            </div>
            <TopDiseasesChart data={dashboardData.topDiseases} />
            <PatientList data={dashboardData.recentPatients || []} />
          </div>
        );

      case "Staff (Doctor/Nurse/Clerk)":
        return (
          <div className="space-y-6">
            <h1 className="text-2xl font-bold text-gray-900">
              {dashboardData.hospitalName} - Your Patients
            </h1>
            <PatientList data={dashboardData.treatedPatients || []} />
            <TopDiseasesChart data={dashboardData.topDiseases} />
          </div>
        );

      case "Patient":
        return (
          <div className="space-y-6">
            <h1 className="text-2xl font-bold text-gray-900">Your Medical History</h1>
            <RecentCheckups data={dashboardData.recentCheckups || []} />
            <div className="bg-white rounded-xl shadow-sm p-6 border border-gray-100">
              <h2 className="text-lg font-semibold text-gray-900 mb-4">Recent Diagnoses</h2>
              <div className="divide-y divide-gray-100">
                {dashboardData.recentDiagnoses?.map((diagnosis, index) => (
                  <div key={index} className="py-4">
                    <div className="flex items-center justify-between">
                      <div>
                        <p className="font-medium text-gray-900">{diagnosis.name}</p>
                        <p className="text-sm text-gray-500 mt-1">{diagnosis.note}</p>
                        <p className="text-xs text-gray-400 mt-1">
                          Diagnosed on: {new Date(diagnosis.date).toLocaleDateString()}
                        </p>
                      </div>
                      <span className="px-3 py-1 rounded-full text-sm font-medium bg-blue-100 text-blue-800">
                        {diagnosis.status}
                      </span>
                    </div>
                  </div>
                ))}
              </div>
            </div>
          </div>
        );

      default:
        return (
          <div className="text-center py-12">
            <div className="mx-auto h-12 w-12 text-gray-400">
              <XMarkIcon className="h-12 w-12" />
            </div>
            <h3 className="mt-2 text-lg font-medium text-gray-900">Unauthorized Access</h3>
            <p className="mt-1 text-sm text-gray-500">
              You don't have permission to view this dashboard.
            </p>
          </div>
        );
    }
  };

  return (
    <div className="min-h-screen bg-gray-50">
      {/* Main Content */}
      <div className="lg:pl-84">

        {/* Main Content Area */}
        <main className="p-6">
          {loading ? (
            <div className="flex items-center justify-center h-64">
              <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-500"></div>
            </div>
          ) : error ? (
            <div className="bg-red-50 p-4 rounded-lg">
              <p className="text-red-500">{error}</p>
            </div>
          ) : (
            renderDashboardContent()
          )}
        </main>
      </div>
    </div>
  );
};

export default DashboardLayout;


// import React, { useState, useEffect } from "react";
// import axios from "axios";
// import { Bars3Icon, XMarkIcon, ChartBarIcon, UsersIcon, BuildingOfficeIcon, BellIcon, ClipboardIcon, UserCircleIcon } from "@heroicons/react/24/outline";
// import { ResponsiveContainer, BarChart, Bar, XAxis, YAxis, CartesianGrid, Tooltip, Legend, LineChart, Line } from "recharts";

// const API_URL = "http://localhost:8000/api/";

// const DashboardLayout = () => {
//   const [user, setUser] = useState(null);
//   const [dashboardData, setDashboardData] = useState(null);
//   const [loading, setLoading] = useState(true);
//   const [sidebarOpen, setSidebarOpen] = useState(false);
//   const [error, setError] = useState(null);

//   useEffect(() => {
//     const fetchDashboardData = async () => {
//       try {
//         setLoading(true);
//         const userData = JSON.parse(localStorage.getItem("user"));
//         setUser(userData);

//         if (!userData) {
//           throw new Error("User not found, please log in again.");
//         }

//         const response = await axios.get(`${API_URL}dashboard-stats/`, {
//           headers: { Authorization: `Bearer ${userData.accessToken}` },
//         });

//         setDashboardData(response.data);
//       } catch (error) {
//         console.error("Error fetching dashboard data:", error);
//         setError(error.message);
//         if (error.response) {
//           console.error("Status:", error.response.status);
//           console.error("Data:", error.response.data);
//           console.error("Headers:", error.response.headers);
//         }
//         setError(error.response ? error.response.data.message : error.message);
//       } finally {
//         setLoading(false);
//       }
//     };

//     fetchDashboardData();
//   }, []);

//   const renderDashboardContent = () => {
//     if (!dashboardData) return null;

//     switch (dashboardData.role) {
//       case "Super Admin":
//         return (
//           <div>
//             <h1 className="text-2xl font-bold">National Healthcare Overview</h1>
//             <div className="grid grid-cols-1 lg:grid-cols-3 gap-6 mt-4">
//               <StatCard title="Total Hospitals" value={dashboardData.totalHospitals} />
//               <StatCard title="Total Staff" value={dashboardData.totalStaff} />
//               <StatCard title="Total Patients" value={dashboardData.totalPatients} />
//             </div>
//             <div className="grid grid-cols-1 lg:grid-cols-2 gap-6 mt-6">
//               <TopDiseasesChart data={dashboardData.topDiseases} />
//               <HospitalPerformanceChart data={dashboardData.topHospitals} />
//             </div>
//           </div>
//         );

//       case "Hospital Head / Admin":
//         return (
//           <div>
//             <h1 className="text-2xl font-bold">{dashboardData.hospitalName} Overview</h1>
//             <div className="grid grid-cols-1 lg:grid-cols-2 gap-6 mt-4">
//               <StatCard title="Total Staff" value={dashboardData.totalStaff} />
//               <StatCard title="Total Patients" value={dashboardData.totalPatients} />
//             </div>
//             <TopDiseasesChart data={dashboardData.topDiseases} />
//           </div>
//         );

//       case "Staff (Doctor/Nurse/Clerk)":
//         return (
//           <div>
//             <h1 className="text-2xl font-bold">{dashboardData.hospitalName} - Your Patients</h1>
//             <PatientList data={dashboardData.treatedPatients} />
//             <TopDiseasesChart data={dashboardData.topDiseases} />
//           </div>
//         );

//       case "Patient":
//         return (
//           <div>
//             <h1 className="text-2xl font-bold">Your Medical History</h1>
//             <RecentCheckups data={dashboardData.recentCheckups} />
//             <RecentDiagnoses data={dashboardData.recentDiagnoses} />
//           </div>
//         );

//       default:
//         return <p>Unauthorized Access</p>;
//     }
//   };

//   return (
//     <div className="min-h-screen bg-gray-100">
//       {/* Sidebar */}
//       <aside className={`fixed inset-0 lg:relative w-64 bg-white border-r ${sidebarOpen ? "block" : "hidden"}`}>
//         <div className="flex items-center justify-between h-16 px-4 border-b">
//           <span className="text-xl font-semibold">SL Healthcare</span>
//           <button onClick={() => setSidebarOpen(false)}><XMarkIcon className="w-6 h-6" /></button>
//         </div>
//         <nav className="p-4 space-y-2">
//           <a href="/dashboard" className="flex items-center px-4 py-2 hover:bg-gray-50"><ChartBarIcon className="w-5 h-5 mr-3" />Overview</a>
//           {user?.groups.includes("Super Admin") && <a href="/reports" className="flex items-center px-4 py-2 hover:bg-gray-50"><ClipboardIcon className="w-5 h-5 mr-3" />Reports</a>}
//         </nav>
//       </aside>

//       {/* Main Content */}
//       <div className="lg:pl-64 p-6">
//         <header className="flex items-center justify-between bg-white px-4 py-2 border-b">
//           <button onClick={() => setSidebarOpen(true)} className="lg:hidden"><Bars3Icon className="w-6 h-6" /></button>
//           <BellIcon className="w-6 h-6 text-gray-400" />
//         </header>

//         <main>
//           {loading ? <p>Loading data...</p> : error ? <p className="text-red-500">{error}</p> : renderDashboardContent()}
//         </main>
//       </div>
//     </div>
//   );
// };

// const StatCard = ({ title, value }) => (
//   <div className="bg-white p-4 rounded-lg shadow">
//     <h2 className="text-lg font-semibold">{title}</h2>
//     <p className="text-3xl font-bold">{value}</p>
//   </div>
// );

// const TopDiseasesChart = ({ data }) => (
//   <div className="bg-white p-4 rounded-lg shadow">
//     <h2 className="text-lg font-semibold">Top Diseases</h2>
//     <ResponsiveContainer width="100%" height={300}>
//       <BarChart data={data}>
//         <CartesianGrid strokeDasharray="3 3" />
//         <XAxis dataKey="name" />
//         <YAxis />
//         <Tooltip />
//         <Legend />
//         <Bar dataKey="cases" fill="#3b82f6" />
//       </BarChart>
//     </ResponsiveContainer>
//   </div>
// );

// const HospitalPerformanceChart = ({ data }) => (
//   <div className="bg-white p-4 rounded-lg shadow">
//     <h2 className="text-lg font-semibold">Top Hospitals</h2>
//     <ResponsiveContainer width="100%" height={300}>
//       <LineChart data={data}>
//         <CartesianGrid strokeDasharray="3 3" />
//         <XAxis dataKey="name" />
//         <YAxis />
//         <Tooltip />
//         <Legend />
//         <Line type="monotone" dataKey="total_cases" stroke="#3b82f6" />
//       </LineChart>
//     </ResponsiveContainer>
//   </div>
// );

// const PatientList = ({ data }) => (
//   <div className="bg-white p-4 rounded-lg shadow">
//     <h2 className="text-lg font-semibold">Patients Treated</h2>
//     <ul className="list-disc pl-5">
//       {data.map((patient, index) => (
//         <li key={index}>{patient.patient__first_name} {patient.patient__last_name}</li>
//       ))}
//     </ul>
//   </div>
// );




// const RecentCheckups = ({ data }) => (
//   <div className="bg-white p-4 rounded-lg shadow">
//     <h2 className="text-lg font-semibold">Recent Checkups</h2>
//     {data.length === 0 ? (
//       <p className="text-gray-500">No recent checkups.</p>
//     ) : (
//       <ul className="divide-y divide-gray-200">
//         {data.map((checkup, index) => (
//           <li key={index} className="py-2">
//             <p className="font-medium">
//               Checkup with Dr. {checkup.doctor__first_name} {checkup.doctor__last_name}
//             </p>
//             <p className="text-sm text-gray-500">Date: {new Date(checkup.date).toLocaleDateString()}</p>
//             <p className={`text-sm font-semibold ${checkup.status === "completed" ? "text-green-600" : "text-red-600"}`}>
//               Status: {checkup.status}
//             </p>
//           </li>
//         ))}
//       </ul>
//     )}
//   </div>
// );


// const RecentDiagnoses = ({ data }) => (
//   <div className="bg-white p-4 rounded-lg shadow">
//     <h2 className="text-lg font-semibold">Recent Diagnoses</h2>
//     {data.length === 0 ? (
//       <p className="text-gray-500">No recent diagnoses.</p>
//     ) : (
//       <ul className="divide-y divide-gray-200">
//         {data.map((diagnosis, index) => (
//           <li key={index} className="py-2">
//             <p className="font-medium">{diagnosis.name}</p>
//             <p className="text-sm text-gray-500">{diagnosis.note}</p>
//           </li>
//         ))}
//       </ul>
//     )}
//   </div>
// );


// export default DashboardLayout;



// import React, { useEffect, useState } from 'react';
// import { useNavigate } from 'react-router-dom';
// import AuthService from '../services/auth.service';


// const Home = () => {
//   const [user, setUser] = useState(null);
//   const navigate = useNavigate();

//   useEffect(() => {
//     const currentUser = AuthService.getCurrentUser();
//     if (currentUser) {
//       setUser(currentUser);
//     } else {
//       navigate('/login');
//     }
    

//   }, [navigate]);

//   const handleLogout = () => {
//     AuthService.logout();
//     navigate('/login');
//   };

//   if (!user) return <div>Loading...</div>;

//   return ( 
//     <div>
//       <h2>Home</h2>
//       <p>Welcome, {user.username}!</p>
//       {user.groups ? (
//         <p>Your group: {user.groups}</p>
//       ) : (
//         <p>You are not a member of any group.</p>
//       )}
//       <p>Profile Set: {user.profile_set === true ? 'Yes' : 'No'}</p>      
//       <p>Email: {user.email}</p>
//       <button onClick={handleLogout}>Logout</button>
//     </div>
//   );
// };

// export default Home;