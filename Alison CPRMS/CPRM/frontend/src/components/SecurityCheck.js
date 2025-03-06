import React, { useState } from 'react';

const SecurityCheck = ({ onSecurityCheck }) => {
  const [keyType, setKeyType] = useState('public');
  const [key, setKey] = useState('');
  const [patientId, setPatientId] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    onSecurityCheck(patientId, keyType, key);
  };

  return (
    <form onSubmit={handleSubmit} className="bg-FFFFFF p-4 rounded shadow-md">
      <input
        type="text"
        placeholder="Patient ID"
        value={patientId}
        onChange={(e) => setPatientId(e.target.value)}
        className="bg-A8C1E4 text-242424 p-2 rounded mb-2 w-full"
      />
      <select
        value={keyType}
        onChange={(e) => setKeyType(e.target.value)}
        className="bg-A8C1E4 text-242424 p-2 rounded mb-2 w-full"
      >
        <option value="public">Public Key</option>
        <option value="private">Private Key</option>
        <option value="admin">Admin Secret Key</option>
      </select>
      <input
        type="text"
        placeholder="Enter key"
        value={key}
        onChange={(e) => setKey(e.target.value)}
        className="bg-A8C1E4 text-242424 p-2 rounded mb-2 w-full"
      />
      <button type="submit" className="bg-146FEF text-white px-4 py-2 rounded w-full">
        Check
      </button>
    </form>
  );
};

export default SecurityCheck;