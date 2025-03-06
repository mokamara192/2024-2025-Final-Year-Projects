// src/pages/CheckupDetails.js
import React, { useEffect, useState } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import MedicalHistoryService from '../utils/medical_history';

const CheckupDetails = () => {
  const { checkupId } = useParams();
  const navigate = useNavigate();
  const [details, setDetails] = useState(null);
  const [error, setError] = useState(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchDetails = async () => {
      try {
        setLoading(true);
        const response = await MedicalHistoryService.getCheckupDetails(checkupId);
        setDetails(response);
      } catch (err) {
        setError('Failed to load checkup details.');
      } finally {
        setLoading(false);
      }
    };

    fetchDetails();
  }, [checkupId]);

  if (loading) return <p>Loading...</p>;
  if (error) return <p className="text-red-500">{error}</p>;

  return (
    <div className="p-6">
      <button
        className="mb-4 px-4 py-2 bg-blue-500 text-white rounded hover:bg-blue-600"
        onClick={() => navigate(-1)}
      >
        Back
      </button>
      <h1 className="text-2xl font-bold mb-6">Checkup Details</h1>
      {details ? (
        <div className="space-y-4">
          <section>
            <h2 className="text-xl font-semibold">Triage</h2>
            {/* Render triage details */}
          </section>
          <section>
            <h2 className="text-xl font-semibold">Symptoms</h2>
            {/* Render symptoms list */}
          </section>
          {/* Add other sections for Tests, Diagnoses, etc. */}
        </div>
      ) : (
        <p>No details available.</p>
      )}
    </div>
  );
};

export default CheckupDetails;
