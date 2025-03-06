import React from 'react';
import { useNavigate } from 'react-router-dom';
import { ShieldExclamationIcon, ArrowLeftIcon } from '@heroicons/react/24/outline';

const Forbidden = () => {
  const navigate = useNavigate();

  return (
    <div className="min-h-screen bg-gradient-to-br from-sky-100 via-sky-200 to-white flex items-center justify-center px-4 sm:px-6 lg:px-8 relative overflow-hidden">
      {/* Decorative elements */}
      <div className="absolute inset-0 overflow-hidden">
        <div className="absolute -top-40 -right-40 w-80 h-80 bg-sky-200 rounded-full filter blur-3xl opacity-50"></div>
        <div className="absolute -bottom-40 -left-40 w-80 h-80 bg-sky-100 rounded-full filter blur-3xl opacity-50"></div>
        <div className="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 w-full h-full bg-gradient-to-br from-transparent via-white/50 to-transparent"></div>
      </div>

      <div className="max-w-lg w-full">
        <div className="relative bg-white/70 backdrop-blur-xl p-8 rounded-2xl shadow-xl border border-white text-center">
          <div className="flex flex-col items-center space-y-6">
            <div className="relative">
              <div className="absolute -inset-0.5 bg-gradient-to-r from-sky-300 to-sky-400 rounded-full blur opacity-75 group-hover:opacity-100 transition duration-1000 group-hover:duration-200 animate-tilt"></div>
              <div className="relative w-24 h-24 rounded-full bg-sky-50 backdrop-blur-sm flex items-center justify-center">
                <ShieldExclamationIcon className="h-12 w-12 text-sky-500" />
              </div>
            </div>
            
            <div className="space-y-4">
              <h2 className="text-4xl font-bold text-gray-900">
                Access Denied
              </h2>
              <p className="text-gray-600 max-w-sm mx-auto">
                Oops! Looks like you've wandered into restricted territory. You don't have permission to access this area.
              </p>
            </div>

            <button
              onClick={() => navigate(-1)}
              className="group inline-flex items-center px-6 py-3 bg-sky-500 rounded-xl text-white hover:bg-sky-600 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-sky-400 transition-all duration-200"
            >
              <ArrowLeftIcon className="h-5 w-5 mr-2 group-hover:-translate-x-1 transition-transform duration-200" />
              Return to Safety
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Forbidden;