import React, { useEffect, useState } from "react";
import RecordAccessService from "../utils/recordAccessService";
import { toast } from "react-toastify";
import { EyeIcon, EyeSlashIcon} from '@heroicons/react/24/outline';

const RecordAccessPage = () => {
  const [records, setRecords] = useState([]);
  const [loading, setLoading] = useState(true);
  const [visibleKeys, setVisibleKeys] = useState({});

  useEffect(() => {
    fetchRecords();
  }, []);

  const fetchRecords = async () => {
    try {
      const data = await RecordAccessService.getRecords();
      setRecords(data);
    } catch (error) {
      toast.error("Failed to fetch record access");
    } finally {
      setLoading(false);
    }
  };

  const toggleVisibility = (id) => {
    setVisibleKeys((prev) => ({ ...prev, [id]: !prev[id] }));
  };

  return (
    <div className="p-6">
      <h1 className="text-2xl font-semibold mb-4">Record Access Management</h1>
      {loading ? (
        <p>Loading...</p>
      ) : (
        <table className="w-full border-collapse border border-gray-200">
          <thead>
            <tr className="bg-gray-100">
              <th className="border p-2">Doctor</th>
              <th className="border p-2">Patient</th>
              <th className="border p-2">Secret Key</th>
              <th className="border p-2">Action</th>
            </tr>
          </thead>
          <tbody>
            {records.map((record) => (
              <tr key={record.id} className="text-center">
                <td className="border p-2">{record.doctor.first_name} {record.doctor.last_name}</td>
                <td className="border p-2">{record.patient.first_name} {record.patient.last_name}</td>
                <td className="border p-2">
                  {visibleKeys[record.id] ? record.secret_key : "******"}
                </td>
                <td className="border p-2">
                  <button
                    className="bg-gray-500 text-white px-4 py-1 rounded mx-2"
                    onClick={() => toggleVisibility(record.id)}
                  >
                    {visibleKeys[record.id] ? <EyeSlashIcon className="h-5 w-5 inline" /> : <EyeIcon className="h-5 w-5 inline" />}
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
};

export default RecordAccessPage;
