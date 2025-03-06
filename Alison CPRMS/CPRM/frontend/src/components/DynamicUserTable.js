import { useState, useEffect } from "react";
import axios from "axios";
import { TrashIcon, PencilSquareIcon, MagnifyingGlassIcon } from "@heroicons/react/24/outline";
// import EditAuthModal from "./EditAuthModal";
// import EditProfileModal from "./EditProfileModal";
import EditAuthModal from "./EditAuthModal";
import EditProfileModal from "./EditProfileModal";


const DynamicUserTable = () => {
    const [users, setUsers] = useState([]);
    const [searchId, setSearchId] = useState("");
    const [selectedUser, setSelectedUser] = useState(null);
    const [isAuthModalOpen, setIsAuthModalOpen] = useState(false);
    const [isProfileModalOpen, setIsProfileModalOpen] = useState(false);
    const user = JSON.parse(localStorage.getItem("user"));
    const isSuperAdmin = user.groups.includes("Super Admin");
    const isHospitalAdmin = user.groups.includes("Hospital Admin");
    const isHospitalHead = user.groups.includes("Hospital Head");

    useEffect(() => {
        fetchUsers();
    }, []);

    const fetchUsers = async () => {
        try {
            const response = await axios.get("http://localhost:8000/api/get-users/", {
                headers: { Authorization: `Bearer ${user.accessToken}` },
            });
            setUsers(response.data);
        } catch (error) {
            console.error("Error fetching users:", error);
            console.log("Full error:", error);
        }
    };

   // Helper function with extensive logging to identify hospital data structure
    // Simple function to get hospital name
    const getHospitalName = (user) => {
        if (user.hospital && user.hospital.name) {
            return user.hospital.name;
        }
        return "N/A";
    };

    const handleDelete = async (id) => {
        try {
            await axios.delete(`http://localhost:8000/api/delete-user/${id}/`, {
                headers: { Authorization: `Bearer ${user.accessToken}` },
            });
            setUsers(users.filter(user => user.id !== id));
        } catch (error) {
            console.error("Error deleting user:", error);
        }
    };

    const handleSearch = async () => {
        try {
            const response = await axios.get(`http://localhost:8000/api/search-profile/?profile_id=${searchId}`, {
                headers: { Authorization: `Bearer ${user.accessToken}` },
            });
            setUsers([response.data]);
        } catch (error) {
            console.error("Error searching user:", error);
        }
    };

    return (
        <div className="p-4 bg-white shadow-lg rounded-lg">
            <div className="flex justify-between items-center mb-4">
                <div className="flex items-center space-x-2">
                    <input 
                        type="text" 
                        placeholder="Search by Profile ID" 
                        value={searchId} 
                        onChange={(e) => setSearchId(e.target.value)}
                        className="border p-2 rounded-lg"
                    />
                    <button onClick={handleSearch} className="bg-blue-500 text-white p-2 rounded-lg flex items-center">
                        <MagnifyingGlassIcon className="h-5 w-5" />
                    </button>
                </div>
            </div>

            <table className="w-full border-collapse border border-gray-300">
                <thead>
                    <tr className="bg-gray-100">
                        <th className="border p-2">ID</th>
                        <th className="border p-2">Name</th>
                        {isSuperAdmin ? <th className="border p-2">Hospital</th> : <th className="border p-2">Specialty</th>}
                        <th className="border p-2">Phone</th>
                        {/* <th className="border p-2">Hire Date</th> */}
                        <th className="border p-2">Address</th>
                        <th className="border p-2">Actions</th>
                    </tr>
                </thead>
                <tbody>
                    {users.map((user) => (
                        <tr key={user.id} className="border">
                            <td className="p-2">{user.id}</td>
                            <td className="p-2">{user.first_name} {user.last_name}</td>
                            {isSuperAdmin ? (
                                <td className="p-2">{getHospitalName(user)}</td>
                            ) : (
                                <td className="p-2">{user.specialty || "N/A"}</td>
                            )}
                            {/* {isSuperAdmin ? (
                                <td className="p-2">{user.hospital ? user.hospital.name : "N/A"}</td>
                            ) : (
                                <td className="p-2">{user.specialty || "N/A"}</td>
                            )} */}
                            <td className="p-2">{user.phone_number}</td>
                            {/* <td className="p-2">{user.hire_date || "N/A"}</td> */}
                            <td className="p-2">{user.address}</td>
                            <td className="p-2 flex space-x-2">
                                <button onClick={() => { setSelectedUser(user.user); setIsAuthModalOpen(true); }} className="text-blue-500">
                                    <PencilSquareIcon className="h-5 w-5" />
                                </button>
                                <button onClick={() => { setSelectedUser(user); setIsProfileModalOpen(true); }} className="text-green-500">
                                    <PencilSquareIcon className="h-5 w-5" />
                                </button>
                                <button onClick={() => handleDelete(user.user.id)} className="text-red-500">
                                    <TrashIcon className="h-5 w-5" />
                                </button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>

            {isAuthModalOpen && <EditAuthModal user={selectedUser} onClose={() => setIsAuthModalOpen(false)} />}
            {isProfileModalOpen && <EditProfileModal user={selectedUser} onClose={() => setIsProfileModalOpen(false)} />}
        </div>
    );
};

export default DynamicUserTable;
