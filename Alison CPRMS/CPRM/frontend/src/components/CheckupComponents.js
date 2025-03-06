import React, { useState } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { 
  createCheckup, 
  addSymptom, 
  addTest, 
  addDiagnosis, 
  createPrescription, 
  addMedicine 
} from '../utils/checkupUtils';
import { 
  PlusCircleIcon, 
  XCircleIcon, 
  ChevronRightIcon,
  ClipboardDocumentCheckIcon,
  // HeartPulseIcon,
  HeartIcon,
  BeakerIcon,
  ClipboardDocumentListIcon,
  DocumentTextIcon
} from '@heroicons/react/24/outline';

// Progress Steps Component
const ProgressSteps = ({ currentStep }) => {
  const steps = [
    { name: 'Checkup', icon: ClipboardDocumentCheckIcon },
    { name: 'Symptoms', icon: HeartIcon },
    { name: 'Tests', icon: BeakerIcon },
    { name: 'Diagnosis', icon: ClipboardDocumentListIcon },
    { name: 'Prescription', icon: DocumentTextIcon }
  ];

  return (
    <div className="flex justify-between mb-8 px-4">
      {steps.map((step, index) => (
        <div key={index} className="flex flex-col items-center">
          <div className={`w-10 h-10 rounded-full flex items-center justify-center ${
            index <= currentStep ? 'bg-blue-500 text-white' : 'bg-gray-200'
          }`}>
            <step.icon className="w-5 h-5" />
          </div>
          <span className={`text-xs mt-2 ${
            index <= currentStep ? 'text-blue-500' : 'text-gray-500'
          }`}>{step.name}</span>
        </div>
      ))}
    </div>
  );
};

export const CreateCheckupForm = () => {
  const { triageId } = useParams();
  const navigate = useNavigate();
  const [checkupStatus, setCheckupStatus] = useState('');
  const [isLoading, setIsLoading] = useState(false);

  const handleSubmit = async (e) => {
    e.preventDefault();
    setIsLoading(true);
    try {
      const checkup = await createCheckup(triageId);
      navigate(`/checkup/${checkup.id}/symptoms`);
    } catch (error) {
      console.error('Error creating checkup:', error);
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <div className="max-w-2xl mx-auto">
      <ProgressSteps currentStep={0} />
      <div className="bg-white rounded-xl shadow-lg p-6">
        <div className="flex items-center gap-3 mb-6">
          <ClipboardDocumentCheckIcon className="h-6 w-6 text-blue-500" />
          <h2 className="text-2xl font-semibold text-gray-800">Create Check-Up</h2>
        </div>
        <form onSubmit={handleSubmit} className="space-y-6">
          <div className="space-y-2">
            <label className="block text-sm font-medium text-gray-700">Checkup Status</label>
            <select
              value={checkupStatus}
              onChange={(e) => setCheckupStatus(e.target.value)}
              className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500 transition-colors"
            >
              <option value="">Select Check-Up Status</option>
              <option value="ongoing">Ongoing</option>
              <option value="completed">Completed</option>
              <option value="cancelled">Cancelled</option>
            </select>
          </div>
          <button
            type="submit"
            disabled={isLoading}
            className="w-full flex items-center justify-center gap-2 px-6 py-3 bg-blue-500 text-white rounded-lg hover:bg-blue-600 focus:ring-4 focus:ring-blue-200 transition-colors disabled:opacity-50"
          >
            {isLoading ? (
              <div className="animate-spin rounded-full h-5 w-5 border-b-2 border-white"></div>
            ) : (
              <>
                <PlusCircleIcon className="h-5 w-5" />
                Create Checkup
              </>
            )}
          </button>
        </form>
      </div>
    </div>
  );
};

export const AddSymptomsForm = () => {
  const { checkupId } = useParams();
  const navigate = useNavigate();
  const [symptoms, setSymptoms] = useState([]);
  const [currentSymptom, setCurrentSymptom] = useState({ name: '', severity: '', note: '' });
  const [isSubmitting, setIsSubmitting] = useState(false);

  const handleAddSymptom = async () => {
    if (!currentSymptom.name.trim()) return;
    
    try {
      await addSymptom(checkupId, currentSymptom);
      setSymptoms([...symptoms, currentSymptom]);
      setCurrentSymptom({ name: '', severity: '', note: '' });
    } catch (error) {
      console.error('Error adding symptom:', error);
    }
  };

  const handleRemoveSymptom = (index) => {
    setSymptoms(symptoms.filter((_, i) => i !== index));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setIsSubmitting(true);
    try {
      navigate(`/checkup/${checkupId}/tests`);
    } catch (error) {
      console.error('Error:', error);
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <div className="max-w-2xl mx-auto">
      <ProgressSteps currentStep={1} />
      <div className="bg-white rounded-xl shadow-lg p-6">
        <div className="flex items-center gap-3 mb-6">
          <HeartIcon className="h-6 w-6 text-blue-500" />
          <h2 className="text-2xl font-semibold text-gray-800">Add Symptoms</h2>
        </div>

        <div className="space-y-6">
          <div className="bg-gray-50 p-4 rounded-lg space-y-4">
            <input
              type="text"
              value={currentSymptom.name}
              onChange={(e) => setCurrentSymptom({...currentSymptom, name: e.target.value})}
              placeholder="Symptom Name"
              className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
            />
            
            <select
              value={currentSymptom.severity}
              onChange={(e) => setCurrentSymptom({...currentSymptom, severity: e.target.value})}
              className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
            >
              <option value="">Select Severity</option>
              <option value="mild">Mild</option>
              <option value="moderate">Moderate</option>
              <option value="severe">Severe</option>
            </select>

            <textarea
              value={currentSymptom.note}
              onChange={(e) => setCurrentSymptom({...currentSymptom, note: e.target.value})}
              placeholder="Additional Notes"
              className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
              rows="3"
            />

            <button
              type="button"
              onClick={handleAddSymptom}
              className="w-full flex items-center justify-center gap-2 px-4 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors"
            >
              <PlusCircleIcon className="h-5 w-5" />
              Add Symptom
            </button>
          </div>

          {symptoms.length > 0 && (
            <div className="space-y-3">
              <h3 className="font-medium text-gray-700">Added Symptoms</h3>
              {symptoms.map((symptom, index) => (
                <div key={index} className="flex items-start justify-between bg-blue-50 p-3 rounded-lg">
                  <div>
                    <div className="font-medium">{symptom.name}</div>
                    <div className="text-sm text-gray-600">Severity: {symptom.severity}</div>
                    {symptom.note && <div className="text-sm text-gray-500 mt-1">{symptom.note}</div>}
                  </div>
                  <button
                    onClick={() => handleRemoveSymptom(index)}
                    className="text-gray-400 hover:text-red-500 transition-colors"
                  >
                    <XCircleIcon className="h-5 w-5" />
                  </button>
                </div>
              ))}
            </div>
          )}

          <div className="flex justify-between pt-4">
            <button
              onClick={() => navigate(-1)}
              className="px-4 py-2 text-gray-600 hover:text-gray-800 transition-colors"
            >
              Back
            </button>
            <button
              onClick={handleSubmit}
              disabled={isSubmitting}
              className="flex items-center gap-2 px-6 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors disabled:opacity-50"
            >
              {isSubmitting ? (
                <div className="animate-spin rounded-full h-5 w-5 border-b-2 border-white"></div>
              ) : (
                <>
                  Next
                  <ChevronRightIcon className="h-5 w-5" />
                </>
              )}
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};
export const AddTestForm = () => {
  const { checkupId } = useParams();
  const navigate = useNavigate();
  const [tests, setTests] = useState([]);
  const [currentTest, setCurrentTest] = useState({
    testType: '',
    testResult: null,
    notes: ''
  });
  const [isSubmitting, setIsSubmitting] = useState(false);

  const handleTestAdd = () => {
    if (currentTest.testType.trim()) {
      setTests([...tests, currentTest]);
      setCurrentTest({
        testType: '',
        testResult: null,
        notes: ''
      });
    }
  };

  const handleRemoveTest = (index) => {
    setTests(tests.filter((_, i) => i !== index));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setIsSubmitting(true);
    try {
      if (tests.length > 0) {
        for (const test of tests) {
          await addTest(checkupId, test);
        }
      }
      navigate(`/checkup/${checkupId}/diagnosis`);
    } catch (error) {
      console.error('Error adding tests:', error);
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <div className="max-w-2xl mx-auto">
      <ProgressSteps currentStep={2} />
      <div className="bg-white rounded-xl shadow-lg p-6">
        <div className="flex items-center justify-between mb-6">
          <div className="flex items-center gap-3">
            <BeakerIcon className="h-6 w-6 text-blue-500" />
            <h2 className="text-2xl font-semibold text-gray-800">Add Tests</h2>
          </div>
          <button
            onClick={() => navigate(`/checkup/${checkupId}/diagnosis`)}
            className="text-sm text-gray-500 hover:text-gray-700 underline"
          >
            Skip Tests →
          </button>
        </div>

        <div className="space-y-6">
          <div className="bg-gray-50 p-4 rounded-lg space-y-4">
            <input
              type="text"
              value={currentTest.testType}
              onChange={(e) => setCurrentTest({...currentTest, testType: e.target.value})}
              placeholder="Test Type"
              className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
            />
            
            <input
              type="file"
              onChange={(e) => setCurrentTest({...currentTest, testResult: e.target.files[0]})}
              className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
            />

            <textarea
              value={currentTest.notes}
              onChange={(e) => setCurrentTest({...currentTest, notes: e.target.value})}
              placeholder="Test Notes"
              className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
              rows="3"
            />

            <button
              type="button"
              onClick={handleTestAdd}
              className="w-full flex items-center justify-center gap-2 px-4 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors"
            >
              <PlusCircleIcon className="h-5 w-5" />
              Add Test
            </button>
          </div>

          {tests.length > 0 && (
            <div className="space-y-3">
              <h3 className="font-medium text-gray-700">Added Tests</h3>
              {tests.map((test, index) => (
                <div key={index} className="flex items-start justify-between bg-blue-50 p-3 rounded-lg">
                  <div>
                    <div className="font-medium">{test.testType}</div>
                    {test.testResult && (
                      <div className="text-sm text-gray-600">
                        File: {test.testResult.name}
                      </div>
                    )}
                    {test.notes && <div className="text-sm text-gray-500 mt-1">{test.notes}</div>}
                  </div>
                  <button
                    onClick={() => handleRemoveTest(index)}
                    className="text-gray-400 hover:text-red-500 transition-colors"
                  >
                    <XCircleIcon className="h-5 w-5" />
                  </button>
                </div>
              ))}
            </div>
          )}

          <div className="flex justify-between pt-4">
            <button
              type="button"
              onClick={() => navigate(-1)}
              className="px-4 py-2 text-gray-600 hover:text-gray-800 transition-colors"
            >
              Back
            </button>
            <button
              type="submit"
              onClick={handleSubmit}
              disabled={isSubmitting}
              className="flex items-center gap-2 px-6 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors disabled:opacity-50"
            >
              {isSubmitting ? (
                <div className="animate-spin rounded-full h-5 w-5 border-b-2 border-white"></div>
              ) : (
                <>
                  Next
                  <ChevronRightIcon className="h-5 w-5" />
                </>
              )}
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export const AddDiagnosisForm = () => {
  const { checkupId } = useParams();
  const navigate = useNavigate();
  const [diagnosis, setDiagnosis] = useState({ name: '', note: '' });
  const [isSubmitting, setIsSubmitting] = useState(false);

  const handleSubmit = async (e) => {
    e.preventDefault();
    setIsSubmitting(true);
    try {
      await addDiagnosis(checkupId, diagnosis);
      navigate(`/checkup/${checkupId}/prescription`);
    } catch (error) {
      console.error('Error adding diagnosis:', error);
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <div className="max-w-2xl mx-auto">
      <ProgressSteps currentStep={3} />
      <div className="bg-white rounded-xl shadow-lg p-6">
        <div className="flex items-center gap-3 mb-6">
          <ClipboardDocumentListIcon className="h-6 w-6 text-blue-500" />
          <h2 className="text-2xl font-semibold text-gray-800">Add Diagnosis</h2>
        </div>

        <form onSubmit={handleSubmit} className="space-y-6">
          <div className="space-y-4">
            <div className="space-y-2">
              <label className="block text-sm font-medium text-gray-700">Diagnosis Name</label>
              <input
                type="text"
                value={diagnosis.name}
                onChange={(e) => setDiagnosis({...diagnosis, name: e.target.value})}
                placeholder="Enter diagnosis"
                className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
              />
            </div>

            <div className="space-y-2">
              <label className="block text-sm font-medium text-gray-700">Diagnosis Notes</label>
              <textarea
                value={diagnosis.note}
                onChange={(e) => setDiagnosis({...diagnosis, note: e.target.value})}
                placeholder="Add detailed notes about the diagnosis"
                className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                rows="4"
              />
            </div>
          </div>

          <div className="flex justify-between pt-4">
            <button
              type="button"
              onClick={() => navigate(-1)}
              className="px-4 py-2 text-gray-600 hover:text-gray-800 transition-colors"
            >
              Back
            </button>
            <button
              type="submit"
              disabled={isSubmitting || !diagnosis.name.trim()}
              className="flex items-center gap-2 px-6 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors disabled:opacity-50"
            >
              {isSubmitting ? (
                <div className="animate-spin rounded-full h-5 w-5 border-b-2 border-white"></div>
              ) : (
                <>
                  Next
                  <ChevronRightIcon className="h-5 w-5" />
                </>
              )}
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};

export const CreatePrescriptionForm = () => {
  const { checkupId } = useParams();
  const navigate = useNavigate();
  const [prescription, setPrescription] = useState({ status: 'active', note: '' });
  const [medicines, setMedicines] = useState([]);
  const [currentMedicine, setCurrentMedicine] = useState({
    name: '',
    dosage: '',
    frequency: '',
    duration: '',
    note: ''
  });
  const [isSubmitting, setIsSubmitting] = useState(false);

  const handleAddMedicine = () => {
    if (currentMedicine.name.trim() && currentMedicine.dosage.trim()) {
      setMedicines([...medicines, currentMedicine]);
      setCurrentMedicine({
        name: '',
        dosage: '',
        frequency: '',
        duration: '',
        note: ''
      });
    }
  };

  const handleRemoveMedicine = (index) => {
    setMedicines(medicines.filter((_, i) => i !== index));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setIsSubmitting(true);
    try {
      const createdPrescription = await createPrescription(checkupId, prescription);
      for (let medicine of medicines) {
        await addMedicine(createdPrescription.id, medicine);
      }
      navigate('/triage-list');
    } catch (error) {
      console.error('Error creating prescription:', error);
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <div className="max-w-2xl mx-auto">
      <ProgressSteps currentStep={4} />
      <div className="bg-white rounded-xl shadow-lg p-6">
        <div className="flex items-center gap-3 mb-6">
          <DocumentTextIcon className="h-6 w-6 text-blue-500" />
          <h2 className="text-2xl font-semibold text-gray-800">Create Prescription</h2>
        </div>

        <form onSubmit={handleSubmit} className="space-y-6">
          <div className="space-y-4">
            <div className="space-y-2">
              <label className="block text-sm font-medium text-gray-700">Prescription Status</label>
              <select
                value={prescription.status}
                onChange={(e) => setPrescription({...prescription, status: e.target.value})}
                className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
              >
                <option value="active">Active</option>
                <option value="inactive">Inactive</option>
              </select>
            </div>

            <div className="space-y-2">
              <label className="block text-sm font-medium text-gray-700">Prescription Notes</label>
              <textarea
                value={prescription.note}
                onChange={(e) => setPrescription({...prescription, note: e.target.value})}
                placeholder="Add general prescription notes"
                className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                rows="3"
              />
            </div>

            <div className="bg-gray-50 p-4 rounded-lg space-y-4">
              <h3 className="font-medium text-gray-700">Add Medicine</h3>
              <div className="grid grid-cols-2 gap-4">
                <input
                  type="text"
                  value={currentMedicine.name}
                  onChange={(e) => setCurrentMedicine({...currentMedicine, name: e.target.value})}
                  placeholder="Medicine Name"
                  className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                />
                <input
                  type="text"
                  value={currentMedicine.dosage}
                  onChange={(e) => setCurrentMedicine({...currentMedicine, dosage: e.target.value})}
                  placeholder="Dosage"
                  className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                />
              </div>
              <div className="grid grid-cols-2 gap-4">
                <input
                  type="text"
                  value={currentMedicine.frequency}
                  onChange={(e) => setCurrentMedicine({...currentMedicine, frequency: e.target.value})}
                  placeholder="Frequency (e.g., 3 times daily)"
                  className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                />
                <input
                  type="text"
                  value={currentMedicine.duration}
                  onChange={(e) => setCurrentMedicine({...currentMedicine, duration: e.target.value})}
                  placeholder="Duration (e.g., 7 days)"
                  className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                />
              </div>
              <textarea
                value={currentMedicine.note}
                onChange={(e) => setCurrentMedicine({...currentMedicine, note: e.target.value})}
                placeholder="Additional instructions or notes"
                className="w-full p-3 rounded-lg border border-gray-200 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
                rows="2"
              />
              <button
                type="button"
                onClick={handleAddMedicine}
                className="w-full flex items-center justify-center gap-2 px-4 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors"
              >
                <PlusCircleIcon className="h-5 w-5" />
                Add Medicine
              </button>
            </div>

            {medicines.length > 0 && (
              <div className="space-y-3">
                <h3 className="font-medium text-gray-700">Prescribed Medicines</h3>
                {medicines.map((medicine, index) => (
                  <div key={index} className="flex items-start justify-between bg-blue-50 p-3 rounded-lg">
                    <div className="flex-1">
                      <div className="font-medium">{medicine.name}</div>
                      <div className="text-sm text-gray-600">
                        Dosage: {medicine.dosage}
                        {medicine.frequency && ` • ${medicine.frequency}`}
                        {medicine.duration && ` • ${medicine.duration}`}
                      </div>
                      {medicine.note && (
                        <div className="text-sm text-gray-500 mt-1">{medicine.note}</div>
                      )}
                    </div>
                    <button
                      type="button"
                      onClick={() => handleRemoveMedicine(index)}
                      className="text-gray-400 hover:text-red-500 transition-colors"
                    >
                      <XCircleIcon className="h-5 w-5" />
                    </button>
                  </div>
                ))}
              </div>
            )}
          </div>

          <div className="flex justify-between pt-4">
            <button
              type="button"
              onClick={() => navigate(-1)}
              className="px-4 py-2 text-gray-600 hover:text-gray-800 transition-colors"
            >
              Back
            </button>
            <button
              type="submit"
              disabled={isSubmitting || medicines.length === 0}
              className="flex items-center gap-2 px-6 py-2 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors disabled:opacity-50"
            >
              {isSubmitting ? (
                <div className="animate-spin rounded-full h-5 w-5 border-b-2 border-white"></div>
              ) : (
                'Complete Checkup'
              )}
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};




















// import React, { useState } from 'react';
// import { useParams, useNavigate } from 'react-router-dom';
// import { createCheckup, addSymptom, addTest, addDiagnosis, createPrescription, addMedicine } from '../utils/checkupUtils';

// export const CreateCheckupForm = () => {
//   const { triageId } = useParams();
//   const navigate = useNavigate();
//   const [checkupStatus, setCheckupStatus] = useState('');

//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     try {
//       const checkup = await createCheckup(triageId);
//       navigate(`/checkup/${checkup.id}/symptoms`);
//     } catch (error) {
//       console.error('Error creating checkup:', error);
//     }
//   };

//   return (
//     <div className="bg-white p-4 rounded-lg shadow">
//       <h2 className="text-2xl font-bold mb-4">Create Check-Up</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <select
//           value={checkupStatus}
//           onChange={(e) => setCheckupStatus(e.target.value)}
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424]"
//         >
//           <option value="">Select Check-Up Status</option>
//           <option value="ongoing">Ongoing</option>
//           <option value="completed">Completed</option>
//           <option value="cancelled">Cancelled</option>
//         </select>
//         <button type="submit" className="w-full p-2 bg-[#146FEF] text-white rounded">Create</button>
//       </form>
//     </div>
//   );
// };

// export const AddSymptomsForm = () => {
//   const { checkupId } = useParams();
//   const navigate = useNavigate();
//   const [symptoms, setSymptoms] = useState([]);
//   const [currentSymptom, setCurrentSymptom] = useState({ name: '', severity: '', note: '' });

//   const handleAddSymptom = async () => {
//     try {
//       await addSymptom(checkupId, currentSymptom);
//       setSymptoms([...symptoms, currentSymptom]);
//       setCurrentSymptom({ name: '', severity: '', note: '' });
//     } catch (error) {
//       console.error('Error adding symptom:', error);
//     }
//   };

//   const handleSubmit = (e) => {
//     e.preventDefault();
//     navigate(`/checkup/${checkupId}/tests`);
//   };

//   return (
//     <div className="bg-white p-4 rounded-lg shadow">
//       <h2 className="text-2xl font-bold mb-4">Add Symptoms</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <input
//           type="text"
//           value={currentSymptom.name}
//           onChange={(e) => setCurrentSymptom({...currentSymptom, name: e.target.value})}
//           placeholder="Symptom Name"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         />
//         <select
//           value={currentSymptom.severity}
//           onChange={(e) => setCurrentSymptom({...currentSymptom, severity: e.target.value})}
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424]"
//         >
//           <option value="">Select Severity</option>
//           <option value="mild">Mild</option>
//           <option value="moderate">Moderate</option>
//           <option value="severe">Severe</option>
//         </select>
//         <textarea
//           value={currentSymptom.note}
//           onChange={(e) => setCurrentSymptom({...currentSymptom, note: e.target.value})}
//           placeholder="Note"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         ></textarea>
//         <button type="button" onClick={handleAddSymptom} className="w-full p-2 bg-[#146FEF] text-white rounded">Add Symptom</button>
//         <div className="space-y-2">
//           {symptoms.map((symptom, index) => (
//             <div key={index} className="bg-[#EEF4FD] p-2 rounded">
//               <p>{symptom.name} - {symptom.severity}</p>
//               <p>{symptom.note}</p>
//             </div>
//           ))}
//         </div>
//         <button type="submit" className="w-full p-2 bg-[#146FEF] text-white rounded">Next</button>
//       </form>
//     </div>
//   );
// };

// export const AddTestForm = () => {
//   const { checkupId } = useParams();
//   const navigate = useNavigate();
//   const [testResult, setTestResult] = useState(null);
//   const [testType, setTestType] = useState('');

//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     try {
//       await addTest(checkupId, { testResult, testType });
//       navigate(`/checkup/${checkupId}/diagnosis`);
//     } catch (error) {
//       console.error('Error adding test:', error);
//     }
//   };

//   return (
//     <div className="bg-white p-4 rounded-lg shadow">
//       <h2 className="text-2xl font-bold mb-4">Add Test</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <input
//           type="file"
//           onChange={(e) => setTestResult(e.target.files[0])}
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424]"
//         />
//         <input
//           type="text"
//           value={testType}
//           onChange={(e) => setTestType(e.target.value)}
//           placeholder="Test Type"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         />
//         <button type="submit" className="w-full p-2 bg-[#146FEF] text-white rounded">Add Test</button>
//       </form>
//     </div>
//   );
// };

// export const AddDiagnosisForm = () => {
//   const { checkupId } = useParams();
//   const navigate = useNavigate();
//   const [diagnosis, setDiagnosis] = useState({ name: '', note: '' });

//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     try {
//       await addDiagnosis(checkupId, diagnosis);
//       navigate(`/checkup/${checkupId}/prescription`);
//     } catch (error) {
//       console.error('Error adding diagnosis:', error);
//     }
//   };

//   return (
//     <div className="bg-white p-4 rounded-lg shadow">
//       <h2 className="text-2xl font-bold mb-4">Add Diagnosis</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <input
//           type="text"
//           value={diagnosis.name}
//           onChange={(e) => setDiagnosis({...diagnosis, name: e.target.value})}
//           placeholder="Diagnosis Name"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         />
//         <textarea
//           value={diagnosis.note}
//           onChange={(e) => setDiagnosis({...diagnosis, note: e.target.value})}
//           placeholder="Diagnosis Note"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         ></textarea>
//         <button type="submit" className="w-full p-2 bg-[#146FEF] text-white rounded">Add Diagnosis</button>
//       </form>
//     </div>
//   );
// };

// export const CreatePrescriptionForm = () => {
//   const { checkupId } = useParams();
//   const navigate = useNavigate();
//   const [prescription, setPrescription] = useState({ status: 'active', note: '' });
//   const [medicines, setMedicines] = useState([]);
//   const [currentMedicine, setCurrentMedicine] = useState({ name: '', dosage: '', frequency: '', duration: '', note: '' });

//   const handleAddMedicine = () => {
//     setMedicines([...medicines, currentMedicine]);
//     setCurrentMedicine({ name: '', dosage: '', frequency: '', duration: '', note: '' });
//   };

//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     try {
//       const createdPrescription = await createPrescription(checkupId, prescription);
//       for (let medicine of medicines) {
//         await addMedicine(createdPrescription.id, medicine);
//       }
//       navigate('/triage-list'); // Or wherever you want to redirect after completing the checkup
//     } catch (error) {
//       console.error('Error creating prescription:', error);
//     }
//   };

//   return (
//     <div className="bg-white p-4 rounded-lg shadow">
//       <h2 className="text-2xl font-bold mb-4">Create Prescription</h2>
//       <form onSubmit={handleSubmit} className="space-y-4">
//         <select
//           value={prescription.status}
//           onChange={(e) => setPrescription({...prescription, status: e.target.value})}
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424]"
//         >
//           <option value="active">Active</option>
//           <option value="inactive">Inactive</option>
//         </select>
//         <textarea
//           value={prescription.note}
//           onChange={(e) => setPrescription({...prescription, note: e.target.value})}
//           placeholder="Prescription Note"
//           className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//         ></textarea>
//         <div className="space-y-2">
//           <input
//             type="text"
//             value={currentMedicine.name}
//             onChange={(e) => setCurrentMedicine({...currentMedicine, name: e.target.value})}
//             placeholder="Medicine Name"
//             className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//           />
//           <input
//             type="text"
//             value={currentMedicine.dosage}
//             onChange={(e) => setCurrentMedicine({...currentMedicine, dosage: e.target.value})}
//             placeholder="Dosage"
//             className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//           />
//           <input
//             type="text"
//             value={currentMedicine.frequency}
//             onChange={(e) => setCurrentMedicine({...currentMedicine, frequency: e.target.value})}
//             placeholder="Frequency"
//             className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//           />
//           <input
//             type="text"
//             value={currentMedicine.duration}
//             onChange={(e) => setCurrentMedicine({...currentMedicine, duration: e.target.value})}
//             placeholder="Duration"
//             className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//           />
//           <textarea
//             value={currentMedicine.note}
//             onChange={(e) => setCurrentMedicine({...currentMedicine, note: e.target.value})}
//             placeholder="Medicine Note"
//             className="w-full p-2 border rounded bg-[#A8C1E4] text-[#242424] placeholder-[#EEF4FD]"
//           ></textarea>
//           <button type="button" onClick={handleAddMedicine} className="w-full p-2 bg-[#146FEF] text-white rounded">Add Medicine</button>
//         </div>
//         <div className="space-y-2">
//           {medicines.map((medicine, index) => (
//             <div key={index} className="bg-[#EEF4FD] p-2 rounded">
//               <p>{medicine.name} - {medicine.dosage}</p>
//               <p>{medicine.frequency} for {medicine.duration}</p>
//               <p>{medicine.note}</p>
//             </div>
//           ))}
//         </div>
//         <button type="submit" className="w-full p-2 bg-[#146FEF] text-white rounded">Create Prescription</button>
//       </form>
//     </div>
//   );
// };