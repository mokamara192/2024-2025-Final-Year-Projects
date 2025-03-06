import React, { useEffect, useState } from "react";
import RequestAccessService from "../utils/requestAccessService";
import { toast } from "react-toastify";

const RequestAccessPage = () => {
  const [requests, setRequests] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetchRequests();
  }, []);

  const fetchRequests = async () => {
    try {
      const data = await RequestAccessService.getRequests();
      setRequests(data);
    } catch (error) {
      toast.error("Failed to fetch requests");
    } finally {
      setLoading(false);
    }
  };

  const handleStatusChange = async (requestId, newStatus) => {
    try {
      await RequestAccessService.updateRequestStatus(requestId, newStatus);
      setRequests((prev) =>
        prev.map((req) =>
          req.id === requestId ? { ...req, status: newStatus } : req
        )
      );
      toast.success("Status updated successfully");
    } catch (error) {
      toast.error("Failed to update status");
    }
  };

  return (
    <div className="p-6">
      <h1 className="text-2xl font-semibold mb-4">Request Access Management</h1>
      {loading ? (
        <p>Loading...</p>
      ) : (
        <table className="w-full border-collapse border border-gray-200">
          <thead>
            <tr className="bg-gray-100">
              <th className="border p-2">Doctor</th>
              <th className="border p-2">Patient</th>
              <th className="border p-2">Status</th>
              <th className="border p-2">Action</th>
            </tr>
          </thead>
          <tbody>
            {requests.map((request) => (
              <tr key={request.id} className="text-center">
                <td className="border p-2">{request.doctor.first_name} {request.doctor.last_name}</td>
                <td className="border p-2">{request.patient.first_name} {request.patient.last_name}</td>
                <td className="border p-2">{request.status}</td>
                <td className="border p-2">
                  <button
                    className="bg-green-500 text-white px-4 py-1 rounded mx-2"
                    onClick={() => handleStatusChange(request.id, "approved")}
                    disabled={request.status === "approved"}
                  >
                    Approve
                  </button>
                  <button
                    className="bg-red-500 text-white px-4 py-1 rounded mx-2"
                    onClick={() => handleStatusChange(request.id, "denied")}
                  >
                    Deny
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

export default RequestAccessPage;
