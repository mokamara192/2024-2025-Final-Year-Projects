import React from 'react';

const CustomAlertDialog = ({ isOpen, onClose, title, messages }) => {
  if (!isOpen) return null;

  return (
    <div className="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50">
      <div className="bg-white rounded-lg p-6 max-w-md w-full mx-4">
        <div className="mb-4">
          <h2 className="text-xl font-bold text-gray-800">{title}</h2>
        </div>
        <div className="mb-6">
          <ul className="list-disc pl-5 space-y-1">
            {messages.map((message, index) => (
              <li key={index} className="text-red-500">{message}</li>
            ))}
          </ul>
        </div>
        <div className="flex justify-end">
          <button
            onClick={onClose}
            className="px-4 py-2 bg-blue-500 text-white rounded hover:bg-blue-600 transition-colors"
          >
            Close
          </button>
        </div>
      </div>
    </div>
  );
};

export default CustomAlertDialog;