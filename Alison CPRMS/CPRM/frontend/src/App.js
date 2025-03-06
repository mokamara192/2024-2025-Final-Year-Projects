import React, { useEffect } from 'react';
import { BrowserRouter as Router, Route, Routes, Navigate, useLocation } from 'react-router-dom';
import Dashboard from './pages/Dashboard';
import Login from './pages/Login';
import Home from './pages/Home';
import CreateUserWithProfile from './components/CreateUpdateUserForm';
import UserList from './components/UserList';
import PatientMedicalHistory from './pages/PatientMedicalHistory';
import PatientDetailedView from './pages/PatientDetailedView';
import ProfileCreation from './components/ProfileCreation';
import RegionDistrictPage from './pages/RegionDistrictPage';
import AuthService from './services/auth.service';
import Hospital from './pages/hospital';
import {CreateTriageForm, TriageList} from './components/TriageComponents';
import UserProfile from './pages/UserProfile';
import RequestAccessPage from './pages/RequestAccessPage';
import RecordAccessPage from './pages/RecordAccessPage';
import DynamicUserTable from "./components/DynamicUserTable";
import UpdateUsernamePassword from './components/UpdateUsernamePassword';
import PatientTable from "./pages/PatientTable";
import CheckupDetails from './pages/CheckupDetails';
import DoctorMedicalHistoryView from './pages/DoctorMedicalHistoryView';
import DoctorAccess from './pages/DoctorAccess';
import DoctorCheckupDetails from './pages/DoctorCheckupDetails';
import { CreateCheckupForm, AddSymptomsForm, AddTestForm, AddDiagnosisForm, CreatePrescriptionForm } from './components/CheckupComponents';
import Forbidden from './pages/Forbidden';
// import UpdateMedicalHistory from "./pages/UpdateMedicalHistory";
import MedicalRecordUpdate from "./pages/UpdateMedicalHistory";

const ProtectedRoute = ({ element, path }) => {
  const user = AuthService.getCurrentUser();
  if (!user) return <Navigate to="/login" replace />;
  if (!canAccess(user.groups, path)) return <Navigate to="/403" replace />;
  return element;
};

const SessionMonitor = () => {
  const location = useLocation();
  
  useEffect(() => {
    if (location.pathname === "/login") {
      AuthService.logout();
    }
  }, [location]);
  
  return null;
};

function App() {
  return (
    <Router>
      <SessionMonitor />
      <Routes>
        <Route path="/login" element={<Login />} />
        <Route path="/403" element={<Forbidden />} />
        {/* <Route path="/403" element={<h1>403 - You Dont Have The Autorization To Access This Page</h1>} /> */}
        <Route path="/" element={<Dashboard />}>
          <Route index element={<Navigate replace to="/home" />} />
          <Route path="home" element={<ProtectedRoute path="/home" element={<Home />} />} />
          <Route path="profile/create" element={<ProtectedRoute path="/profile/create" element={<ProfileCreation />} />} />
          <Route path="users" element={<ProtectedRoute path="/users" element={<UserList />} />} />
          <Route path="users/create" element={<ProtectedRoute path="/users/create" element={<CreateUserWithProfile />} />} />
          <Route path="/users_profile" element={<ProtectedRoute path="/users_profile" element={<DynamicUserTable />} />} />
          <Route path="/update_username_password" element={<ProtectedRoute path="/update_username_password" element={<UpdateUsernamePassword />} />} />
          <Route path="/patients" element={<ProtectedRoute path="/patients" element={<PatientTable />} />} />
          <Route path="region-district" element={<ProtectedRoute path="/region-district" element={<RegionDistrictPage />} />} />
          <Route path="hospitals" element={<ProtectedRoute path="/hospitals" element={<Hospital />} />} />
          <Route path="/profile/:userId?" element={<ProtectedRoute path="/profile/:userId?" element={<UserProfile />} />} />
          <Route path="/patient_medical_history_list" element={<ProtectedRoute path="/patient_medical_history_list" element={<PatientMedicalHistory />} />} />
          <Route path="/details/:checkupId" element={<ProtectedRoute path="/details/:checkupId" element={<PatientDetailedView />} />} />
          <Route path="/doctor-history/:patientId" element={<ProtectedRoute path="/doctor-history/:patientId" element={<DoctorMedicalHistoryView />} />} />
          <Route path="/diagnostics_details/:checkupId" element={<ProtectedRoute path="/diagnostics_details/:checkupId" element={<DoctorCheckupDetails />} />} />
          <Route path="/checkup-details/:checkupId" element={<ProtectedRoute path="/checkup-details/:checkupId" element={<CheckupDetails />} />} />
          <Route path="/doctor_access" element={<ProtectedRoute path="/doctor_access" element={<DoctorAccess />} />} />
          <Route path="/request-access" element={<ProtectedRoute path="/request-access" element={<RequestAccessPage />} />} />
          <Route path="/record-access" element={<ProtectedRoute path="/record-access" element={<RecordAccessPage />} />} />
          <Route path="/create-triage" element={<ProtectedRoute path="/create-triage" element={<CreateTriageForm />} />} />
          <Route path="/triage-list" element={<ProtectedRoute path="/triage-list" element={<TriageList />} />} />
          <Route path="/create-checkup/:triageId" element={<ProtectedRoute path="/create-checkup/:triageId" element={<CreateCheckupForm />} />} />
          <Route path="/checkup/:checkupId/symptoms" element={<ProtectedRoute path="/checkup/:checkupId/symptoms" element={<AddSymptomsForm />} />} />
          <Route path="/checkup/:checkupId/tests" element={<ProtectedRoute path="/checkup/:checkupId/tests" element={<AddTestForm />} />} />
          <Route path="/checkup/:checkupId/diagnosis" element={<ProtectedRoute path="/checkup/:checkupId/diagnosis" element={<AddDiagnosisForm />} />} />
          <Route path="/checkup/:checkupId/prescription" element={<ProtectedRoute path="/checkup/:checkupId/prescription" element={<CreatePrescriptionForm />} />} />
          {/* <Route path="/update-medical-history/:checkupId" element={<ProtectedRoute path="/update-medical-history/:checkupId"element={<UpdateMedicalHistory />} />} /> */}
          <Route path="/update-medical-history/:checkupId" element={<ProtectedRoute path="/update-medical-history/:checkupId"element={<MedicalRecordUpdate />} />} />
        </Route>
      </Routes>
    </Router>
  );
}

export default App;

