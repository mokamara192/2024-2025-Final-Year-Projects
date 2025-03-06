import React from 'react';
import useRegionDistrictLogic from '../utils/regionDistrict';
import { ArrowPathIcon, TrashIcon } from '@heroicons/react/24/outline';

const Notification = ({ message, type }) => (
  <div className={`fixed top-4 right-4 p-4 rounded-md shadow-md ${type === 'error' ? 'bg-red-500' : 'bg-green-500'} text-white`}>
    {message}
  </div>
);

const RegionDistrictPage = () => {
  const {
    regions,
    districts,
    regionForm,
    districtForm,
    isUpdatingRegion,
    isUpdatingDistrict,
    notification,
    setRegionForm,
    setDistrictForm,
    handleRegionSubmit,
    handleDistrictSubmit,
    handleRegionDelete,
    handleDistrictDelete,
    selectRegionForUpdate,
    selectDistrictForUpdate,
    resetRegionForm,
    resetDistrictForm
  } = useRegionDistrictLogic();

  return (
    <div className="bg-[#EAECF0] min-h-screen p-8">
      {notification && <Notification message={notification.message} type={notification.type} />}
      <h1 className="text-3xl font-bold mb-8">Region/District</h1>
      <div className="grid grid-cols-1 md:grid-cols-2 gap-8">
        {/* Region Form */}
        <div className="bg-white p-6 rounded-lg shadow">
          <h2 className="text-xl font-semibold mb-4">Region</h2>
          <form onSubmit={handleRegionSubmit} className="space-y-4">
            <input
              type="text"
              value={regionForm.name}
              onChange={(e) => setRegionForm({ ...regionForm, name: e.target.value })}
              placeholder="Region"
              className="w-full p-2 border rounded bg-[#A8C1E4] placeholder-[#EEF4FD]"
            />
            <div className="flex justify-between items-center">
              <button
                type="button"
                onClick={resetRegionForm}
                className="text-[#242424]"
              >
                <ArrowPathIcon className="h-5 w-5" />
              </button>
              <button
                type="submit"
                className="bg-[#146FEF] text-white px-4 py-2 rounded"
              >
                {isUpdatingRegion ? 'Update' : 'Create'}
              </button>
            </div>
          </form>
        </div>

        {/* District Form */}
        <div className="bg-white p-6 rounded-lg shadow">
          <h2 className="text-xl font-semibold mb-4">District</h2>
          <form onSubmit={handleDistrictSubmit} className="space-y-4">
            <select
              value={districtForm.region_id}
              onChange={(e) => setDistrictForm({ ...districtForm, region_id: e.target.value })}
              className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424]"
            >
              <option value="">Select Region</option>
              {regions.map((region) => (
                <option key={region.id} value={region.id}>{region.name}</option>
              ))}
            </select>
            <input
              type="text"
              value={districtForm.name}
              onChange={(e) => setDistrictForm({ ...districtForm, name: e.target.value })}
              placeholder="District"
              className="w-full p-2 border rounded bg-[#A8C1E4] placeholder-[#EEF4FD]"
            />
            <div className="flex justify-between items-center">
              <button
                type="button"
                onClick={resetDistrictForm}
                className="text-[#242424]"
              >
                <ArrowPathIcon className="h-5 w-5" />
              </button>
              <button
                type="submit"
                className="bg-[#146FEF] text-white px-4 py-2 rounded"
              >
                {isUpdatingDistrict ? 'Update' : 'Create'}
              </button>
            </div>
          </form>
        </div>
      </div>

      {/* Region List */}
      <div className="mt-8 bg-white p-6 rounded-lg shadow">
        <h2 className="text-xl font-semibold mb-4">Region List</h2>
        <ul className="space-y-2">
          {regions.map((region) => (
            <li key={region.id} className="flex justify-between items-center">
              <span onClick={() => selectRegionForUpdate(region)} className="cursor-pointer">
                {region.name}
              </span>
              <button onClick={() => handleRegionDelete(region.id)} className="text-[#FF0000]">
                <TrashIcon className="h-5 w-5" />
              </button>
            </li>
          ))}
        </ul>
      </div>

      {/* District List */}
      <div className="mt-8 bg-white p-6 rounded-lg shadow">
        <h2 className="text-xl font-semibold mb-4">District List</h2>
        <ul className="space-y-2">
          {districts.map((district) => (
            <li key={district.id} className="flex justify-between items-center">
              <span onClick={() => selectDistrictForUpdate(district)} className="cursor-pointer">
                {district.name}
              </span>
              <button onClick={() => handleDistrictDelete(district.id)} className="text-[#FF0000]">
                <TrashIcon className="h-5 w-5" />
              </button>
            </li>
          ))}
        </ul>
      </div>
    </div>
  );
};

export default RegionDistrictPage;