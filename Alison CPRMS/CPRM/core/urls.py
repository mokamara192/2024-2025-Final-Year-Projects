from django.urls import path
from rest_framework_simplejwt.views import TokenRefreshView
from .views import *
from .views import MyTokenObtainPairView

urlpatterns = [
    path('token/', MyTokenObtainPairView.as_view(), name='token_obtain_pair'),
    path('user/<int:user_id>/group/', get_user_group, name='get_user_group'),
    path('get-hospital-by-staffid/<int:user_id>/', get_hospital_by_staff_id, name='get_hospital_by_user'),
    path('get-hospital-by-hospitalhead/<str:hhead_id>/', get_hospital_by_hospitalhead_id, name='get_hospital_by_user_id'),
    path('user-profile/<int:user_id>/', get_user_profile, name='get_user_profile'),
    path('patients/<str:patient_id>/generate-public-key/', generate_public_key_view, name='generate-public-key'),
    path('patients/<str:patient_id>/generate-private-key/', generate_private_key_view, name='generate-private-key'),

    #update medical history
    path('checkup/<str:checkup_id>/prescription/', update_prescription, name='update-prescription'),


    path('medical-history/', get_patient_medical_history, name='get_patient_medical_history'),
    path('medical-history/<int:checkup_id>/toggle-secure/', toggle_secure_status, name='toggle_secure_status'),
    path('medical-history/<int:checkup_id>/details/', get_detailed_medical_record, name='get_detailed_medical_record'),

    #profile and medical history
    path('get-detailed-medical-history/<int:checkup_id>/', get_update_medical_history, name='medical-history-detail'),



    path('patients/search/', search_patients, name='search_patients'),
    path('patients/<str:patient_id>/', get_patient_details, name='get_patient_details'),
    path('patients/<str:patient_id>/update/', update_patient, name='update_patient'),
    path('patients/<str:patient_id>/delete/', delete_patient, name='delete_patient'),



    path('notifications/<str:profile_id>/', get_notifications, name='get_notifications'),


    path('get-users/', get_users_based_on_role, name='get_users_based_on_role'),
    path('delete-user/<int:user_id>/', delete_user, name='delete_user'),
    path('update-profile/<str:profile_type>/<str:profile_id>/', update_user_profile, name='update_user_profile'),
    path('update-username_password/', update_username_password, name='update_username_password'),



 
    path('validate-public-key/', validate_public_key, name='validate_public_key'),
    path('validate-secret-key/', validate_secret_key, name='validate_secret_key'),
    path('request-access/', request_access, name='request_access'),
    path('request-access_record/', get_request_access, name='get_request_access'),
    path('request-access/<int:request_id>/', update_request_access, name='update_request_access'),
    path('record-access/', get_record_access, name='get_record_access'),

    # CustomUser URLs
    path('users/', get_users, name='get_users'),
    path('users/<int:pk>/', get_user, name='get_user'),
    path('users/create/', create_user, name='create_user'),
    path('users/<int:pk>/update/', update_user, name='update_user'),
    path('users/<int:pk>/patchupdate/', patial_update_user, name='update_user'),
    path('users/<int:pk>/delete/', delete_user, name='delete_user'),

    # Region URLs
    path('regions/', get_regions, name='get_regions'),
    path('regions/<int:pk>/', get_region, name='get_region'),
    path('regions/create/', create_region, name='create_region'),
    path('regions/<int:pk>/update/', update_region, name='update_region'),
    path('regions/<int:pk>/delete/', delete_region, name='delete_region'),

    # District URLs
    path('districts/', get_districts, name='get_districts'),
    path('districts/<int:pk>/', get_district, name='get_district'),
    path('districts/create/', create_district, name='create_district'),
    path('districts/<int:pk>/update/', update_district, name='update_district'),
    path('districts/<int:pk>/delete/', delete_district, name='delete_district'),


     # HospitalHeadProfile URLs
    path('hospital-head-profiles/',get_hospital_head_profiles, name='get_hospital_head_profiles'),
    path('hospital-head-profiles/<str:pk>/', get_hospital_head_profile, name='get_hospital_head_profile'),
    path('hospital-head-profiles/create', create_hospital_head_profile, name='create_hospital_head_profile'),
    path('hospital-head-profiles/<int:pk>/update/', update_hospital_head_profile, name='update_hospital_head_profile'),
    path('hospital-head-profiles/<int:pk>/delete/', delete_hospital_head_profile, name='delete_hospital_head_profile'),

    # Hospital URLs
    path('hospitals_all/', get_all_hospital, name='get_all_hospital'),
    path('hospitals/', get_hospitals, name='get_hospitals'),
    path('hospitals/<int:pk>/', get_hospital, name='get_hospital'),
    path('hospitals/create/', create_hospital, name='create_hospital'),
    path('hospitals/<str:pk>/update/', update_hospital, name='update_hospital'),
    path('hospitals/<str:pk>/delete/',delete_hospital, name='delete_hospital'),

    # StaffProfile URLs
    path('staff-profiles/', get_staff_profiles, name='get_staff_profiles'),
    path('staff-profiles/<int:pk>/', get_staff_profile, name='get_staff_profile'),
    path('staff-profiles/create/', create_staff_profile, name='create_staff_profile'),
    path('staff-profiles/<int:pk>/update/', update_staff_profile, name='update_staff_profile'),
    path('staff-profiles/<int:pk>/delete/', delete_staff_profile, name='delete_staff_profile'),

    # Patient URLs
    path('patients/', get_patients, name='get_patients'),
    path('patients/<str:pk>/', get_patient, name='get_patient'),
    path('patient/create/', create_patient, name='create_patient'),
    path('patients/<int:pk>/update/', update_patient, name='update_patient'),
    path('patients/<int:pk>/delete/', delete_patient, name='delete_patient'),

    # SuperAdminProfile URLs
    path('super-admin-profiles/', get_super_admin_profiles, name='get_super_admin_profiles'),
    path('super-admin-profiles/<int:user_id>/', get_super_admin_profile, name='get_super_admin_profile'),
    path('super-admin-profiles/create/', create_super_admin_profile, name='create_super_admin_profile'),
    path('super-admin-profiles/<int:pk>/update/', update_super_admin_profile, name='update_super_admin_profile'),
    path('super-admin-profiles/<int:pk>/delete/', delete_super_admin_profile, name='delete_super_admin_profile'),


 # Triage URLs
    path('triages/', get_triages, name='get_triages'),
    path('triages/<int:pk>/', get_triage, name='get_triage'),
    path('triages/create/', create_triage, name='create_triage'),
    path('triages/<int:pk>/update/', update_triage, name='update_triage'),
    path('triages/<int:pk>/delete/', delete_triage, name='delete_triage'),

    # Checkup URLs
    path('checkups/', get_checkups, name='get_checkups'),
    path('checkups/<int:pk>/', get_checkup, name='get_checkup'),
    path('checkups/create/', create_checkup, name='create_checkup'),
    path('checkups/<int:pk>/update/', update_checkup, name='update_checkup'),
    path('checkups/<int:pk>/delete/', delete_checkup, name='delete_checkup'),

    # Symptom URLs
    path('symptoms/', get_symptoms, name='get_symptoms'),
    path('symptoms/<int:pk>/', get_symptom, name='get_symptom'),
    path('symptoms/create/', create_symptom, name='create_symptom'),
    path('symptoms/<int:pk>/update/', update_symptom, name='update_symptom'),
    path('symptoms/<int:pk>/delete/', delete_symptom, name='delete_symptom'),

    # Test URLs
    path('tests/', get_tests, name='get_tests'),
    path('tests/<int:pk>/', get_test, name='get_test'),
    path('tests/create/', create_test, name='create_test'),
    path('tests/<int:pk>/update/', update_test, name='update_test'),
    path('tests/<int:pk>/delete/', delete_test, name='delete_test'),

    # Diagnosis URLs
    path('diagnoses/', get_diagnoses, name='get_diagnoses'),
    path('diagnoses/<int:pk>/', get_diagnosis, name='get_diagnosis'),
    path('diagnoses/create/', create_diagnosis, name='create_diagnosis'),
    path('diagnoses/<int:pk>/update/', update_diagnosis, name='update_diagnosis'),
    path('diagnoses/<int:pk>/delete/', delete_diagnosis, name='delete_diagnosis'),

    # Prescription URLs
    path('prescriptions/', get_prescriptions, name='get_prescriptions'),
    path('prescriptions/<int:pk>/', get_prescription, name='get_prescription'),
    path('prescriptions/create/', create_prescription, name='create_prescription'),
    path('prescriptions/<int:pk>/update/', update_prescription, name='update_prescription'),
    path('prescriptions/<int:pk>/delete/', delete_prescription, name='delete_prescription'),

    # Medicine URLs
    path('medicines/', get_medicines, name='get_medicines'),
    path('medicines/<int:pk>/', get_medicine, name='get_medicine'),
    path('medicines/create/', create_medicine, name='create_medicine'),
    path('medicines/<int:pk>/update/', update_medicine, name='update_medicine'),
    path('medicines/<int:pk>/delete/', delete_medicine, name='delete_medicine'),

    # RecordAccess URLs
    # path('record-accesses/', get_record_accesses, name='get_record_accesses'),
    path('record-accesses/<int:pk>/', get_record_access, name='get_record_access'),
    path('record-accesses/create/', create_record_access, name='create_record_access'),
    path('record-accesses/<int:pk>/update/', update_record_access, name='update_record_access'),
    path('record-accesses/<int:pk>/delete/', delete_record_access, name='delete_record_access'),

    # Notification URLs
    path('notifications/', get_notifications, name='get_notifications'),
    path('notifications/<int:pk>/', get_notification, name='get_notification'),
    path('notifications/create/', create_notification, name='create_notification'),
    path('notifications/<int:pk>/update/', update_notification, name='update_notification'),
    path('notifications/<int:pk>/delete/', delete_notification, name='delete_notification'),
    path('dashboard-stats/', get_healthcare_dashboard, name='dashboard_stats'),

]

