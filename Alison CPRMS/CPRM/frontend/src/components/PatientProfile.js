import React from 'react';

const PatientProfile = ({ patient }) => {
  return (
    <div className="bg-FFFFFF p-4 rounded shadow-md mb-4">
      <h2 className="text-xl font-bold mb-2">{patient.first_name} {patient.last_name}</h2>
      <p>ID: {patient.id}</p>
      <p>Age: {patient.age}</p>
      <p>Gender: {patient.gender}</p>
      <p>Phone: {patient.phone}</p>
      <p>Address: {patient.address}</p>
      <p>Public Key: {patient.public_key}</p>
      <p>Emergency Contact: {patient.emergency_contact}</p>
      <p>Emergency Phone: {patient.emergency_phone}</p>
    </div>
  );
};

export default PatientProfile;