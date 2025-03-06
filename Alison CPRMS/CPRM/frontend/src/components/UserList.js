import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import UserService from '../services/userService';

const UserList = () => {
  const [users, setUsers] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchUsers = async () => {
      try {
        setLoading(true);
        const fetchedUsers = await UserService.getAllUsers();
        setUsers(fetchedUsers);
        setError(null);
      } catch (error) {
        console.error('Error fetching users:', error);
        setError('Failed to fetch users. Please try again later.');
      } finally {
        setLoading(false);
      }
    };
    fetchUsers();
  }, []);

  if (loading) {
    return <div>Loading users...</div>;
  }

  if (error) {
    return <div className="text-red-500">{error}</div>;
  }

  return (
    <div>
      <h2 className="text-2xl font-bold mb-4">User List</h2>
      {users.length === 0 ? (
        <p>No users found.</p>
      ) : (
        <ul>
          {users.map(user => (
            <li key={user.id} className="mb-2">
             {user.id} - {user.username} - {user.email}
              <Link to={`/users/${user.id}/update`} className="ml-2 text-blue-600 hover:text-blue-800">
                Update
              </Link>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
};

export default UserList;