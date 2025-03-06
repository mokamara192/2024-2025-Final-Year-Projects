// Login.js
import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { 
  UserIcon, 
  LockClosedIcon, 
  EyeIcon, 
  EyeSlashIcon,
  ExclamationTriangleIcon,
  ArrowRightIcon
} from '@heroicons/react/24/outline';
import AuthService from '../services/auth.service';

const Input = ({ icon: Icon, type, placeholder, value, onChange }) => {
  const [showPassword, setShowPassword] = useState(false);
  const [isFocused, setIsFocused] = useState(false);

  return (
    <div className="relative mb-4 group">
      <div className="absolute inset-y-0 left-0 flex items-center pl-3 pointer-events-none">
        <Icon className={`h-5 w-5 transition-colors duration-200 ${
          isFocused ? 'text-sky-500' : 'text-gray-400'
        }`} />
      </div>
      <input
        type={type === 'password' && showPassword ? 'text' : type}
        className="w-full pl-10 pr-10 py-4 border-2 border-sky-100 rounded-xl focus:outline-none focus:ring-2 focus:ring-sky-300 focus:border-transparent bg-white/90 backdrop-blur-sm transition-all duration-200 hover:border-sky-200"
        placeholder={placeholder}
        value={value}
        onChange={onChange}
        onFocus={() => setIsFocused(true)}
        onBlur={() => setIsFocused(false)}
      />
      {type === 'password' && (
        <button
          type="button"
          className="absolute inset-y-0 right-0 flex items-center pr-3 hover:text-sky-500 transition-colors duration-200"
          onClick={() => setShowPassword(!showPassword)}
        >
          {showPassword ? (
            <EyeSlashIcon className="h-5 w-5 text-gray-400" />
          ) : (
            <EyeIcon className="h-5 w-5 text-gray-400" />
          )}
        </button>
      )}
    </div>
  );
};

const Login = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState('');
  const [isLoading, setIsLoading] = useState(false);
  const navigate = useNavigate();

  const handleLogin = async (e) => {
    e.preventDefault();
    setError('');
    setIsLoading(true);

    try {
      const userData = await AuthService.login(username, password);
      if (userData.profile_set) {
        navigate('/home');
      } else {
        setError('Your profile is not set. Please contact an authorized user to create your profile.');
      }
    } catch (error) {
      console.error("Login error:", error);
      setError('Invalid credentials. Please check your username and password.');
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <div className="min-h-screen bg-gradient-to-br from-sky-100 via-sky-200 to-white flex items-center justify-center px-4 sm:px-6 lg:px-8 relative overflow-hidden">
      {/* Decorative elements */}
      <div className="absolute inset-0 overflow-hidden">
        <div className="absolute -top-40 -right-40 w-80 h-80 bg-sky-200 rounded-full filter blur-3xl opacity-50"></div>
        <div className="absolute -bottom-40 -left-40 w-80 h-80 bg-sky-100 rounded-full filter blur-3xl opacity-50"></div>
        <div className="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 w-full h-full bg-gradient-to-br from-transparent via-white/50 to-transparent"></div>
      </div>

      <div className="max-w-md w-full space-y-8">
        {/* Left decorative card */}
        <div className="absolute -left-4 top-1/2 transform -translate-y-1/2 w-24 h-48 bg-white/40 backdrop-blur-lg rounded-r-2xl hidden lg:block"></div>
        
        {/* Right decorative card */}
        <div className="absolute -right-4 top-1/2 transform -translate-y-1/2 w-24 h-48 bg-white/40 backdrop-blur-lg rounded-l-2xl hidden lg:block"></div>

        {/* Main login card */}
        <div className="relative bg-white/70 backdrop-blur-xl p-8 rounded-2xl shadow-xl border border-white">
          <div className="flex flex-col items-center space-y-6">
            <div className="relative">
              <div className="absolute -inset-0.5 bg-gradient-to-r from-sky-300 to-sky-400 rounded-full blur opacity-75 group-hover:opacity-100 transition duration-1000 group-hover:duration-200 animate-tilt"></div>
              <div className="relative w-24 h-24 rounded-full bg-white shadow-lg flex items-center justify-center p-4 border-2 border-sky-100">
                <img
                  src="/static/logo/welbodi padi.svg"
                  alt="Wellbodo Padi"
                  className="h-16 w-16 object-contain"
                />
              </div>
            </div>
            
            <div className="text-center space-y-2">
              <h2 className="text-3xl font-bold text-gray-900">
                Welcome Back
              </h2>
              <p className="text-gray-600">
                Sign in to access your account
              </p>
            </div>
          </div>

          {error && (
            <div className="mt-6 bg-red-50 border border-red-100 rounded-xl p-4 flex items-center space-x-3">
              <ExclamationTriangleIcon className="h-5 w-5 text-red-400 flex-shrink-0" />
              <p className="text-sm text-red-600">{error}</p>
            </div>
          )}

          <form className="mt-8 space-y-6" onSubmit={handleLogin}>
            <Input
              icon={UserIcon}
              type="text"
              placeholder="Username"
              value={username}
              onChange={(e) => setUsername(e.target.value)}
            />
            <Input
              icon={LockClosedIcon}
              type="password"
              placeholder="Password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />
            
            <button
              type="submit"
              disabled={isLoading}
              className="group relative w-full flex justify-center py-4 px-4 border border-transparent rounded-xl text-white bg-sky-500 hover:bg-sky-600 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-sky-400 transition-all duration-200 disabled:opacity-50 disabled:cursor-not-allowed overflow-hidden"
            >
              <span className="absolute inset-y-0 left-0 flex items-center pl-3">
                <LockClosedIcon className="h-5 w-5 text-sky-300 group-hover:text-sky-200" />
              </span>
              <span className="flex items-center">
                {isLoading ? (
                  <svg className="animate-spin h-5 w-5 text-white" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24">
                    <circle className="opacity-25" cx="12" cy="12" r="10" stroke="currentColor" strokeWidth="4"></circle>
                    <path className="opacity-75" fill="currentColor" d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4zm2 5.291A7.962 7.962 0 014 12H0c0 3.042 1.135 5.824 3 7.938l3-2.647z"></path>
                  </svg>
                ) : (
                  <>
                    Sign in
                    <ArrowRightIcon className="ml-2 h-5 w-5 group-hover:translate-x-1 transition-transform duration-200" />
                  </>
                )}
              </span>
            </button>
          </form>
        </div>
      </div>
    </div>
  );
};
export default Login;


// //Login.js
// import React, { useState } from 'react';
// import { useNavigate } from 'react-router-dom';
// import AuthService from '../services/auth.service';
// import { UserIcon, LockClosedIcon, EyeIcon, EyeSlashIcon } from '@heroicons/react/24/outline';

// const Input = ({ icon: Icon, type, placeholder, value, onChange }) => {
//   const [showPassword, setShowPassword] = useState(false);

//   return (
//     <div className="relative mb-4">
//       <div className="absolute inset-y-0 left-0 flex items-center pl-3 pointer-events-none">
//         <Icon className="h-5 w-5 text-gray-400" />
//       </div>
//       <input
//         type={type === 'password' && showPassword ? 'text' : type}
//         className="w-full pl-10 pr-10 py-2 border rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
//         placeholder={placeholder}
//         value={value}
//         onChange={onChange}
//       />
//       {type === 'password' && (
//         <button
//           type="button"
//           className="absolute inset-y-0 right-0 flex items-center pr-3"
//           onClick={() => setShowPassword(!showPassword)}
//         >
//           {showPassword ? (
//             <EyeSlashIcon className="h-5 w-5 text-gray-400" />
//           ) : (
//             <EyeIcon className="h-5 w-5 text-gray-400" />
//           )}
//         </button>
//       )}
//     </div>
//   );
// };

// const Login = () => {
//   const [username, setUsername] = useState('');
//   const [password, setPassword] = useState('');
//   const [error, setError] = useState('');
//   const navigate = useNavigate();

//   const handleLogin = async (e) => {
//     e.preventDefault();
//     setError('');
//     try {
//       const userData = await AuthService.login(username, password);
//       if (userData.profile_set) {
//         navigate('/home');
//       } else {
//         setError('Your profile is not set. Please contact an authorized user to create your profile.');
//       }
//     } catch (error) {
//       console.error("Login error:", error);
//       setError('An error occurred during login. Please try again later.');
//     }
//   };

//   return (
//     <div className="min-h-screen bg-gradient-to-b from-blue-100 to-blue-300 flex items-center justify-center px-4 sm:px-6 lg:px-8">
//       <div className="max-w-md w-full space-y-8 bg-white bg-opacity-30 backdrop-blur-md p-8 rounded-xl shadow-glass">
//         <div className="flex flex-col items-center">
//           <img
//             src="/static/logo/welbodi padi.svg"
//             alt="Wellbodo Padi"
//             className="h-20 w-20"
//           />
//           <h2 className="mt-6 text-center text-2xl sm:text-3xl lg:text-4xl font-extrabold text-gray-900">
//             Sign in to your account
//           </h2>
//         </div>
//         {error && <p className="text-red-500 text-center">{error}</p>}
//         <form className="mt-8 space-y-6" onSubmit={handleLogin}>
//           <Input
//             icon={UserIcon}
//             type="text"
//             placeholder="Username"
//             value={username}
//             onChange={(e) => setUsername(e.target.value)}
//           />
//           <Input
//             icon={LockClosedIcon}
//             type="password"
//             placeholder="Password"
//             value={password}
//             onChange={(e) => setPassword(e.target.value)}
//           />
//           <div>
//             <button
//               type="submit"
//               className="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm sm:text-md font-medium text-white bg-blue-600 hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500"
//             >
//               Sign in
//             </button>
//           </div>
//         </form>
//       </div>
//     </div>
//   );
// };

// export default Login;