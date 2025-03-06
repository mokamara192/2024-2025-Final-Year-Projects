import { useState, useEffect } from "react";
import axios from "axios";

const EditProfileModal = ({ user, onClose }) => {
    const [formData, setFormData] = useState({});
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState(null);
    const isSuperAdmin = JSON.parse(localStorage.getItem("user")).groups.includes("Super Admin");
    
    useEffect(() => {
        setFormData({
            first_name: user.first_name || "",
            last_name: user.last_name || "",
            phone_number: user.phone_number || "",
            address: user.address || "",
            specialty: user.specialty || "",
        });
    }, [user]);
    
    const handleChange = (e) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };
    
    const handleUpdate = async () => {
        setLoading(true);
        setError(null);
        try {
            const profileType = isSuperAdmin ? "hospital_head" : "staff";
            await axios.patch(`http://localhost:8000/api/update-profile/${profileType}/${user.id}/`, formData, {
                headers: { Authorization: `Bearer ${JSON.parse(localStorage.getItem("user")).accessToken}` }
            });
            onClose();
        } catch (err) {
            setError("Failed to update profile");
        } finally {
            setLoading(false);
        }
    };
    
    return (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex justify-center items-center">
            <div className="bg-white p-6 rounded-lg shadow-lg w-96">
                <h2 className="text-lg font-bold mb-4">Edit Profile</h2>
                {error && <p className="text-red-500">{error}</p>}
                <label className="block mb-2">First Name</label>
                <input type="text" name="first_name" value={formData.first_name} onChange={handleChange} className="border p-2 w-full rounded-lg mb-4" />
                <label className="block mb-2">Last Name</label>
                <input type="text" name="last_name" value={formData.last_name} onChange={handleChange} className="border p-2 w-full rounded-lg mb-4" />
                <label className="block mb-2">Phone Number</label>
                <input type="text" name="phone_number" value={formData.phone_number} onChange={handleChange} className="border p-2 w-full rounded-lg mb-4" />
                <label className="block mb-2">Address</label>
                <input type="text" name="address" value={formData.address} onChange={handleChange} className="border p-2 w-full rounded-lg mb-4" />
                {!isSuperAdmin && (
                    <>
                        <label className="block mb-2">Specialty</label>
                        <input type="text" name="specialty" value={formData.specialty} onChange={handleChange} className="border p-2 w-full rounded-lg mb-4" />
                    </>
                )}
                <div className="flex justify-end space-x-2">
                    <button onClick={onClose} className="bg-gray-400 text-white px-4 py-2 rounded-lg">Cancel</button>
                    <button onClick={handleUpdate} disabled={loading} className="bg-blue-500 text-white px-4 py-2 rounded-lg">
                        {loading ? "Updating..." : "Save"}
                    </button>
                </div>
            </div>
        </div>
    );
};

export default EditProfileModal;
