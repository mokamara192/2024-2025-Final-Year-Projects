import React, { useEffect } from 'react';
import { useHospitalLogic } from '../utils/hospitalLogic';

import { 
  ArrowPathIcon, 
  TrashIcon,
  BuildingOfficeIcon,
  MagnifyingGlassIcon,
  PlusIcon
} from '@heroicons/react/24/outline';
// import { Alert, AlertDescription } from "@/components/ui/alert";

export default function Hospital() {
  const {
        hospitals,districts,formData,setFormData,isUpdateMode,setIsUpdateMode,handleSubmit,handleDelete,handleRowClick,fetchHospitals,fetchDistricts,handleFilter,
        message,
      } = useHospitalLogic();
    
      useEffect(() => {
        fetchHospitals();
        fetchDistricts();
      }, [fetchHospitals, fetchDistricts]);

  return (
    <div className="bg-gray-50 min-h-screen p-6">
      <div className="max-w-7xl mx-auto space-y-6">
        {/* Header */}
        <div className="flex items-center justify-between">
          <div className="flex items-center gap-3">
            <BuildingOfficeIcon className="h-8 w-8 text-blue-600" />
            <h1 className="text-2xl font-semibold text-gray-900">Hospital Management</h1>
          </div>
        </div>

        {/* Alert Message */}
        {message.text && (
          <div className={`p-4 rounded-lg ${
            message.type === 'error' 
              ? 'bg-red-50 text-red-600 border border-red-200' 
              : 'bg-green-50 text-green-600 border border-green-200'
          }`}>
            {message.text}
          </div>
        )}

        <div className="flex gap-6 flex-col lg:flex-row">
          {/* Form Card */}
          <div className="lg:w-1/3 bg-white rounded-xl shadow-sm border border-gray-200">
            <div className="p-6">
              <div className="flex items-center justify-between mb-6">
                <h2 className="text-lg font-semibold text-gray-900">
                  {isUpdateMode ? 'Update Hospital' : 'Add New Hospital'}
                </h2>
                <button
                  type="button"
                  onClick={() => {
                    setIsUpdateMode(false);
                    setFormData({ name: '', district_id: '', hhead_id: '', emergency_number: '', address: '' });
                  }}
                  className="p-2 text-gray-400 hover:text-gray-500 rounded-full hover:bg-gray-50"
                >
                  <ArrowPathIcon className="h-5 w-5" />
                </button>
              </div>

              <form onSubmit={handleSubmit} className="space-y-4">
                <div className="space-y-2">
                  <label className="text-sm font-medium text-gray-700">Hospital Name</label>
                  <input
                    type="text"
                    placeholder="Enter hospital name"
                    value={formData.name}
                    onChange={(e) => setFormData({ ...formData, name: e.target.value })}
                    className="w-full p-2.5 bg-gray-50 border border-gray-300 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                  />
                </div>

                <div className="space-y-2">
                  <label className="text-sm font-medium text-gray-700">District</label>
                  <select
                    value={formData.district_id}
                    onChange={(e) => setFormData({ ...formData, district_id: e.target.value })}
                    className="w-full p-2.5 bg-gray-50 border border-gray-300 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                  >
                    <option value="">Select District</option>
                    {districts.map((district) => (
                      <option key={district.id} value={district.id}>{district.name}</option>
                    ))}
                  </select>
                </div>

                <div className="grid grid-cols-2 gap-4">
                  <div className="space-y-2">
                    <label className="text-sm font-medium text-gray-700">Head ID</label>
                    <input
                      type="text"
                      placeholder="Head ID"
                      value={formData.hhead_id}
                      onChange={(e) => setFormData({ ...formData, hhead_id: e.target.value })}
                      className="w-full p-2.5 bg-gray-50 border border-gray-300 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                    />
                  </div>
                  <div className="space-y-2">
                    <label className="text-sm font-medium text-gray-700">Emergency</label>
                    <input
                      type="tel"
                      placeholder="Emergency #"
                      value={formData.emergency_number}
                      onChange={(e) => setFormData({ ...formData, emergency_number: e.target.value })}
                      className="w-full p-2.5 bg-gray-50 border border-gray-300 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                    />
                  </div>
                </div>

                <div className="space-y-2">
                  <label className="text-sm font-medium text-gray-700">Address</label>
                  <input
                    type="text"
                    placeholder="Enter address"
                    value={formData.address}
                    onChange={(e) => setFormData({ ...formData, address: e.target.value })}
                    className="w-full p-2.5 bg-gray-50 border border-gray-300 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                  />
                </div>

                <button
                  type="submit"
                  className="w-full bg-blue-600 text-white px-4 py-2.5 rounded-lg hover:bg-blue-700 focus:ring-4 focus:ring-blue-200 font-medium flex items-center justify-center gap-2"
                >
                  {isUpdateMode ? (
                    <>Update Hospital</>
                  ) : (
                    <>
                      <PlusIcon className="h-5 w-5" />
                      Add Hospital
                    </>
                  )}
                </button>
              </form>
            </div>
          </div>

          {/* Table Card */}
          <div className="lg:w-2/3 bg-white rounded-xl shadow-sm border border-gray-200">
            <div className="p-6">
              <div className="flex flex-col sm:flex-row justify-between items-start sm:items-center gap-4 mb-6">
                <h2 className="text-lg font-semibold text-gray-900">Hospital List</h2>
                <div className="flex items-center gap-2">
                  <div className="relative">
                    <MagnifyingGlassIcon className="h-5 w-5 text-gray-400 absolute left-3 top-1/2 transform -translate-y-1/2" />
                    <select
                      onChange={(e) => handleFilter(e.target.value)}
                      className="pl-10 pr-4 py-2 bg-gray-50 border border-gray-300 rounded-lg focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                    >
                      <option value="">All Districts</option>
                      {districts.map((district) => (
                        <option key={district.id} value={district.id}>{district.name}</option>
                      ))}
                    </select>
                  </div>
                </div>
              </div>

              <div className="overflow-x-auto">
                <table className="w-full">
                  <thead>
                    <tr className="bg-gray-50 border-y border-gray-200">
                      <th className="text-left p-3 text-xs font-medium text-gray-500 uppercase tracking-wider">ID</th>
                      <th className="text-left p-3 text-xs font-medium text-gray-500 uppercase tracking-wider">Hospital Name</th>
                      <th className="text-left p-3 text-xs font-medium text-gray-500 uppercase tracking-wider">District</th>
                      <th className="text-left p-3 text-xs font-medium text-gray-500 uppercase tracking-wider">Emergency</th>
                      <th className="text-left p-3 text-xs font-medium text-gray-500 uppercase tracking-wider">Head</th>
                      <th className="text-right p-3 text-xs font-medium text-gray-500 uppercase tracking-wider">Actions</th>
                    </tr>
                  </thead>
                  <tbody className="divide-y divide-gray-200">
                    {hospitals.map((hospital) => (
                      <tr 
                        key={hospital.id} 
                        onClick={() => handleRowClick(hospital)} 
                        className="hover:bg-gray-50 cursor-pointer transition-colors"
                      >
                        <td className="p-3 text-sm text-gray-500">{hospital.id}</td>
                        <td className="p-3 text-sm font-medium text-gray-900">{hospital.name}</td>
                        <td className="p-3 text-sm text-gray-500">{hospital.district.name}</td>
                        <td className="p-3 text-sm text-gray-500">{hospital.emergency_number}</td>
                        <td className="p-3 text-sm text-gray-500">{hospital.hhead.first_name}</td>
                        <td className="p-3 text-right">
                          <button 
                            onClick={(e) => { 
                              e.stopPropagation(); 
                              handleDelete(hospital.id); 
                            }} 
                            className="text-gray-400 hover:text-red-500 p-2 hover:bg-red-50 rounded-full transition-colors"
                          >
                            <TrashIcon className="h-5 w-5" />
                          </button>
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}





// import React, { useEffect } from 'react';
// import { useHospitalLogic } from '../utils/hospitalLogic';
// import { ArrowPathIcon, TrashIcon } from '@heroicons/react/24/outline';

// export default function Hospital() {
//   const {
//     hospitals,districts,formData,setFormData,isUpdateMode,setIsUpdateMode,handleSubmit,handleDelete,handleRowClick,fetchHospitals,fetchDistricts,handleFilter,
//     message,
//   } = useHospitalLogic();

//   useEffect(() => {
//     fetchHospitals();
//     fetchDistricts();
//   }, [fetchHospitals, fetchDistricts]);

//   return (
//     <div className="bg-[#EAECF0] min-h-screen p-6">
//       <h1 className="text-3xl font-bold mb-6">Hospital</h1>
//       {message.text && (
//         <div className={`mb-4 p-4 rounded ${message.type === 'error' ? 'bg-red-100 text-red-700' : 'bg-green-100 text-green-700'}`}>
//           {message.text}
//         </div>
//       )}
//       <div className="flex gap-6">
//         <div className="w-1/3 bg-white rounded-lg shadow p-6">
//           <h2 className="text-xl font-semibold mb-4">{isUpdateMode ? 'Update' : 'Create'}</h2>
//           <form onSubmit={handleSubmit} className="space-y-4">
//             <input
//               type="text"
//               placeholder="Hospital Name"
//               value={formData.name}
//               onChange={(e) => setFormData({ ...formData, name: e.target.value })}
//               className="w-full p-2 bg-[#A8C1E4] rounded"
//             />
//             <select
//               value={formData.district_id}
//               onChange={(e) => setFormData({ ...formData, district_id: e.target.value })}
//               className="w-full p-2 bg-[#A8C1E4] rounded"
//             >
//               <option value="">Select District</option>
//               {districts.map((district) => (
//                 <option key={district.id} value={district.id}>{district.name}</option>
//               ))}
//             </select>
//             <div className="flex gap-2">
//               <input
//                 type="text"
//                 placeholder="Hospital Head ID"
//                 value={formData.hhead_id}
//                 onChange={(e) => setFormData({ ...formData, hhead_id: e.target.value })}
//                 className="w-1/2 p-2 bg-[#A8C1E4] rounded"
//               />
//               <input
//                 type="tel"
//                 placeholder="Emg Phone"
//                 value={formData.emergency_number}
//                 onChange={(e) => setFormData({ ...formData, emergency_number: e.target.value })}
//                 className="w-1/2 p-2 bg-[#A8C1E4] rounded"
//               />
//             </div>
//             <input
//               type="text"
//               placeholder="Address"
//               value={formData.address}
//               onChange={(e) => setFormData({ ...formData, address: e.target.value })}
//               className="w-full p-2 bg-[#A8C1E4] rounded"
//             />
//             <div className="flex justify-between items-center">
//               <button
//                 type="button"
//                 onClick={() => {
//                   setIsUpdateMode(false);
//                   setFormData({ name: '', district_id: '', hhead_id: '', emergency_number: '', address: '' });
//                 }}
//                 className="text-[#242424]"
//               >
//                 <ArrowPathIcon className="h-5 w-5" />
//               </button>
//               <button
//                 type="submit"
//                 className="bg-[#146FEF] text-white px-4 py-2 rounded"
//               >
//                 {isUpdateMode ? 'Update' : 'Create'}
//               </button>
//             </div>
//           </form>
//         </div>
//         <div className="w-2/3 bg-white rounded-lg shadow p-6">
//           <div className="flex justify-between items-center mb-4">
//             <h2 className="text-xl font-semibold">Hospital List</h2>
//             <select
//               onChange={(e) => handleFilter(e.target.value)}
//               className="p-2 bg-[#A8C1E4] rounded"
//             >
//               <option value="">All Districts</option>
//               {districts.map((district) => (
//                 <option key={district.id} value={district.id}>{district.name}</option>
//               ))}
//             </select>
//           </div>
//           <div className="overflow-x-auto">
//             <table className="w-full">
//               <thead>
//                 <tr className="border-b">
//                   <th className="text-left p-2">ID</th>
//                   <th className="text-left p-2">Hospital Name</th>
//                   <th className="text-left p-2">District</th>
//                   <th className="text-left p-2">Emg Phone</th>
//                   <th className="text-left p-2">Hospital Head</th>
//                   <th className="text-left p-2">Actions</th>
//                 </tr>
//               </thead>
//               <tbody>
//                 {hospitals.map((hospital) => (
//                   <tr key={hospital.id} onClick={() => handleRowClick(hospital)} className="hover:bg-gray-100 cursor-pointer">
//                     <td className="p-2">{hospital.id}</td>
//                     <td className="p-2">{hospital.name}</td>
//                     <td className="p-2">{hospital.district.name}</td>
//                     <td className="p-2">{hospital.emergency_number}</td>
//                     <td className="p-2">{hospital.hhead.first_name}</td>
//                     <td className="p-2">
//                       <button onClick={(e) => { e.stopPropagation(); handleDelete(hospital.id); }} className="text-[#FF0000]">
//                         <TrashIcon className="h-5 w-5" />
//                       </button>
//                     </td>
//                   </tr>
//                 ))}
//               </tbody>
//             </table>
//           </div>
//         </div>
//       </div>
//     </div>
//   );
// }
