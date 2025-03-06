import { useState } from "react";
import axios from "axios";

const EditAuthModal = ({ user, onClose }) => {
    const [username, setUsername] = useState(user?.username || "");
    const [password, setPassword] = useState("");
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState(null);
    
    const handleUpdate = async () => {
        setLoading(true);
        setError(null);
        try {
            await axios.patch(`http://localhost:8000/api/update-auth/${user.id}/`, {
                username: username.trim(),
                password: password.trim(),
            }, {
                headers: { Authorization: `Bearer ${JSON.parse(localStorage.getItem("user")).accessToken}` }
            });
            alert("User credentials updated successfully");
            onClose();
        } catch (err) {
            setError("Failed to update credentials");
        } finally {
            setLoading(false);
        }
    };

    return (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex justify-center items-center">
            <div className="bg-white p-6 rounded-lg shadow-lg w-96">
                <h2 className="text-lg font-bold mb-4">Edit Authentication</h2>
                {error && <p className="text-red-500">{error}</p>}
                <label className="block mb-2">Username</label>
                <input 
                    type="text" 
                    value={username} 
                    onChange={(e) => setUsername(e.target.value)}
                    className="border p-2 w-full rounded-lg mb-4"
                />
                <label className="block mb-2">New Password</label>
                <input 
                    type="password" 
                    value={password} 
                    onChange={(e) => setPassword(e.target.value)}
                    className="border p-2 w-full rounded-lg mb-4"
                    placeholder="Enter new password"
                />
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

export default EditAuthModal;
