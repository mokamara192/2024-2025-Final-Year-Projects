import json
import re
from django.http import JsonResponse
from django.shortcuts import render
from rest_framework.decorators import api_view
from rest_framework.views import APIView
from rest_framework.response import Response
from rest_framework import status
from rest_framework.parsers import MultiPartParser, FormParser
from django.core.files.storage import default_storage
from django.core.files.base import ContentFile
from django.shortcuts import get_object_or_404
from rest_framework.decorators import api_view, parser_classes, authentication_classes,permission_classes
from rest_framework.permissions import IsAuthenticated
from rest_framework.authentication import TokenAuthentication
from rest_framework_simplejwt.authentication import JWTAuthentication
import traceback
import logging
from django.http import JsonResponse
import random
import string
from django.core.exceptions import ObjectDoesNotExist
from .models import (
    CustomUser, Region, District, HospitalHeadProfile, Hospital, RequestAccess, StaffProfile, 
    Patient, SuperAdminProfile, Triage, Checkup, Symptom, Test, Diagnosis, 
    Prescription, Medicine, RecordAccess, Notification
)
from .serializers import (
    CustomUserSerializer, RegionSerializer, DistrictSerializer, HospitalHeadProfileSerializer,
    HospitalSerializer, RequestAccessSerializer, StaffProfileSerializer, PatientSerializer, SuperAdminProfileSerializer,
    TriageSerializer, CheckupSerializer, SymptomSerializer, TestSerializer, DiagnosisSerializer,
    PrescriptionSerializer, MedicineSerializer, RecordAccessSerializer, NotificationSerializer
)


# users/views.py

from rest_framework_simplejwt.views import TokenObtainPairView
from rest_framework_simplejwt.serializers import TokenObtainPairSerializer
from django.contrib.auth import get_user_model

User = get_user_model()

class MyTokenObtainPairSerializer(TokenObtainPairSerializer):
    @classmethod
    def get_token(cls, user):
        token = super().get_token(user)

        # Add custom claims
        token['user_id'] = user.id
        token['username'] = user.username
        token['email'] = user.email
        token['profile_set']=user.profile_set
        token['groups'] = user.group.name if user.group else None  # user has a single group

        # Add any custom fields here
        
        return token

class MyTokenObtainPairView(TokenObtainPairView):
    serializer_class = MyTokenObtainPairSerializer


# CustomUser CRUD operations
@api_view(['GET'])
def get_users(request):
    users = CustomUser.objects.all()
    serializer = CustomUserSerializer(users, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_user(request, pk):
    user = CustomUser.objects.filter(pk=pk).first()
    if user:
        serializer = CustomUserSerializer(user)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_user(request):
    serializer = CustomUserSerializer(data=request.data)
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_user(request, pk):
    user = CustomUser.objects.filter(pk=pk).first()
    if user:
        serializer = CustomUserSerializer(user, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['PATCH'])
def patial_update_user(request, pk):
    user = CustomUser.objects.filter(pk=pk).first()
    if user:
        serializer = CustomUserSerializer(user, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_user(request, pk):
    user = CustomUser.objects.filter(pk=pk).first()
    if user:
        user.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# Region CRUD operations
@api_view(['GET'])
def get_regions(request):
    regions = Region.objects.all()
    serializer = RegionSerializer(regions, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_region(request, pk):
    region = Region.objects.filter(pk=pk).first()
    if region:
        serializer = RegionSerializer(region)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_region(request):
    serializer = RegionSerializer(data=request.data)
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_region(request, pk):
    region = Region.objects.filter(pk=pk).first()
    if region:
        serializer = RegionSerializer(region, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_region(request, pk):
    region = Region.objects.filter(pk=pk).first()
    if region:
        region.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# District CRUD operations
@api_view(['GET'])
def get_districts(request):
    districts = District.objects.all()
    serializer = DistrictSerializer(districts, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_district(request, pk):
    district = District.objects.filter(pk=pk).first()
    if district:
        serializer = DistrictSerializer(district)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_district(request):
    serializer = DistrictSerializer(data=request.data)
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_district(request, pk):
    district = District.objects.filter(pk=pk).first()
    if district:
        serializer = DistrictSerializer(district, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_district(request, pk):
    district = District.objects.filter(pk=pk).first()
    if district:
        district.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)


# HospitalHeadProfile CRUD operations
@api_view(['GET'])
def get_hospital_head_profiles(request):
    profiles = HospitalHeadProfile.objects.all()
    serializer = HospitalHeadProfileSerializer(profiles, many=True, context={'request': request})
    return Response(serializer.data)

@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_hospital_head_profile(request, pk):
    print(f"Attempting to fetch HospitalHeadProfile with pk={pk}")
    print(f"Authenticated user: {request.user}")
    print(f"User groups: {[group.name for group in request.user.groups.all()]}")
    
    try:
        profile = HospitalHeadProfile.objects.get(pk=pk)
        print(f"Profile found: {profile}")
        serializer = HospitalHeadProfileSerializer(profile, context={'request': request})
        return Response(serializer.data)
    except HospitalHeadProfile.DoesNotExist:
        print(f"No HospitalHeadProfile found with user_id={pk}")
        return Response({"detail": "Hospital Head Profile not found."}, status=status.HTTP_404_NOT_FOUND)
    except Exception as e:
        print(f"Unexpected error: {str(e)}")
        return Response({"detail": "An unexpected error occurred."}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)




@api_view(['POST'])
@parser_classes([MultiPartParser, FormParser])
def create_hospital_head_profile(request):
    print("Method:", request.method)  # Add this
    print("Data:", request.data) 
    serializer = HospitalHeadProfileSerializer(data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)


@api_view(['PUT', 'PATCH'])
@parser_classes([MultiPartParser, FormParser])
def update_hospital_head_profile(request, pk):
    profile = get_object_or_404(HospitalHeadProfile, pk=pk)
    serializer = HospitalHeadProfileSerializer(profile, data=request.data, partial=True, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_hospital_head_profile(request, pk):
    profile = HospitalHeadProfile.objects.filter(pk=pk).first()
    if profile:
        profile.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)



@api_view(['GET'])
def get_all_hospital(request):
    hospitals = Hospital.objects.all()
    serializer = HospitalSerializer(hospitals, many=True, context={'request': request})
    return Response(serializer.data)

@api_view(['GET'])
def get_hospitals(request):
    # Get the 'district' query parameter from the request
    district_id = request.query_params.get('district', None)
    
    # Filter hospitals by district if a district_id is provided
    if district_id:
        hospitals = Hospital.objects.filter(district_id=district_id)
    else:
        hospitals = Hospital.objects.all()
    
    # Serialize and return the hospitals
    serializer = HospitalSerializer(hospitals, many=True, context={'request': request})
    return Response(serializer.data)

@api_view(['GET'])
def get_hospital(request, pk):
    hospital = Hospital.objects.filter(pk=pk).first()
    if hospital:
        serializer = HospitalSerializer(hospital)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)



@api_view(['POST'])
def create_hospital(request):
    hhead_id = request.data.get('hhead_id')
    if not hhead_id:
        return Response({"detail": "Hospital Head ID is required."}, status=status.HTTP_400_BAD_REQUEST)

    # Ensure the HospitalHeadProfile exists
    try:
        hhead = HospitalHeadProfile.objects.get(id=hhead_id)
    except HospitalHeadProfile.DoesNotExist:
        return Response({"detail": "Invalid Hospital Head ID."}, status=status.HTTP_400_BAD_REQUEST)

    # Check if the HospitalHeadProfile is already associated
    if Hospital.objects.filter(hhead=hhead).exists():
        return Response({"detail": "This Hospital Head is already assigned to another hospital."}, status=status.HTTP_400_BAD_REQUEST)

    # Proceed with serializer validation
    serializer = HospitalSerializer(data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    print(serializer.errors)  # Log errors for debugging
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)



@api_view(['PUT'])
def update_hospital(request, pk):
    hospital = Hospital.objects.filter(pk=pk).first()
    if hospital:
        serializer = HospitalSerializer(hospital, data=request.data, context={'request': request}, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_hospital(request, pk):
    hospital = Hospital.objects.filter(pk=pk).first()
    if hospital:
        hospital.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# StaffProfile CRUD operations
@api_view(['GET'])
def get_staff_profiles(request):
    profiles = StaffProfile.objects.all()
    serializer = StaffProfileSerializer(profiles, many=True, context={'request': request})
    return Response(serializer.data)

@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_staff_profile(request, pk):
    print(f"Attempting to fetch StaffProfile with pk={pk}")
    print(f"Authenticated user: {request.user}")
    print(f"User groups: {[group.name for group in request.user.groups.all()]}")
    
    try:
        profile = StaffProfile.objects.get(user_id=pk)
        print(f"Profile found: {profile}")
        serializer = StaffProfileSerializer(profile, context={'request': request})
        return Response(serializer.data)
    except StaffProfile.DoesNotExist:
        print(f"No StaffProfile found with user_id={pk}")
        return Response({"detail": "Staff Profile not found."}, status=status.HTTP_404_NOT_FOUND)
    except Exception as e:
        print(f"Unexpected error: {str(e)}")
        return Response({"detail": "An unexpected error occurred."}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)



@api_view(['POST'])
@parser_classes([MultiPartParser, FormParser])
def create_staff_profile(request):
    serializer = StaffProfileSerializer(data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT', 'PATCH'])
@parser_classes([MultiPartParser, FormParser])
def update_staff_profile(request, pk):
    profile = get_object_or_404(StaffProfile, pk=pk)
    serializer = StaffProfileSerializer(profile, data=request.data, partial=True, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)



@api_view(['DELETE'])
def delete_staff_profile(request, pk):
    profile = StaffProfile.objects.filter(pk=pk).first()
    if profile:
        profile.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# Patient CRUD operations
@api_view(['GET'])
def get_patients(request):
    patients = Patient.objects.all()
    serializer = PatientSerializer(patients, many=True, context={'request': request})
    return Response(serializer.data)


@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_patient(request, pk):
    print(f"Attempting to fetch Patient with pk={pk}")
    print(f"Authenticated user: {request.user}")
    print(f"User groups: {[group.name for group in request.user.groups.all()]}")
    
    try:
        patient = Patient.objects.get(id=pk)
        print(f"Patient found: {patient}")
        serializer = PatientSerializer(patient, context={'request': request})
        return Response(serializer.data)
    except Patient.DoesNotExist:
        print(f"No Patient found with user_id={pk}")
        return Response({"detail": "Patient not found."}, status=status.HTTP_404_NOT_FOUND)
    except Exception as e:
        print(f"Unexpected error: {str(e)}")
        return Response({"detail": "An unexpected error occurred."}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)






@api_view(['POST'])
@parser_classes([MultiPartParser, FormParser])
def create_patient(request):
    serializer = PatientSerializer(data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT', 'PATCH'])
@parser_classes([MultiPartParser, FormParser])
def update_patient(request, pk):
    patient = get_object_or_404(Patient, pk=pk)
    serializer = PatientSerializer(patient, data=request.data, partial=True, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_patient(request, pk):
    patient = Patient.objects.filter(pk=pk).first()
    if patient:
        patient.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# SuperAdminProfile CRUD operations
@api_view(['GET'])
def get_super_admin_profiles(request):
    profiles = SuperAdminProfile.objects.all()
    serializer = SuperAdminProfileSerializer(profiles, many=True, context={'request': request})
    return Response(serializer.data)

@api_view(['GET'])
def get_super_admin_profile(request, user_id):
    profile = SuperAdminProfile.objects.filter(user_id=user_id).first()
    if profile:
        serializer = SuperAdminProfileSerializer(profile, context={'request': request})
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)



@api_view(['POST'])
@parser_classes([MultiPartParser, FormParser])
def create_super_admin_profile(request):
    serializer = SuperAdminProfileSerializer(data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT', 'PATCH'])
@parser_classes([MultiPartParser, FormParser])
def update_super_admin_profile(request, pk):
    profile = get_object_or_404(SuperAdminProfile, pk=pk)
    serializer = SuperAdminProfileSerializer(profile, data=request.data, partial=True, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_super_admin_profile(request, pk):
    profile = SuperAdminProfile.objects.filter(pk=pk).first()
    if profile:
        profile.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)



# Triage CRUD operations
@api_view(['GET'])
def get_triages(request):
    triages = Triage.objects.all()
    serializer = TriageSerializer(triages, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_triage(request, pk):
    triage = Triage.objects.filter(patient=pk)
    if triage:
        serializer = TriageSerializer(triage)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_triage(request):
    id=request.data.get("id")
    print("STAFF ID", id)
    serializer = TriageSerializer(data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_triage(request, pk):
    triage = Triage.objects.filter(pk=pk).first()
    if triage:
        serializer = TriageSerializer(triage, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_triage(request, pk):
    triage = Triage.objects.filter(pk=pk).first()
    if triage:
        triage.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# Checkup CRUD operations
@api_view(['GET'])
def get_checkups(request):
    checkups = Checkup.objects.all()
    serializer = CheckupSerializer(checkups, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_checkup(request, pk):
    checkup = Checkup.objects.filter(triage=pk)
    if checkup:
        serializer = CheckupSerializer(checkup)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_checkup(request):
    serializer = CheckupSerializer(data=request.data,context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_checkup(request, pk):
    checkup = Checkup.objects.filter(pk=pk).first()
    if checkup:
        serializer = CheckupSerializer(checkup, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_checkup(request, pk):
    checkup = Checkup.objects.filter(pk=pk).first()
    if checkup:
        checkup.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# Symptom CRUD operations
@api_view(['GET'])
def get_symptoms(request):
    symptoms = Symptom.objects.all()
    serializer = SymptomSerializer(symptoms, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_symptom(request, pk):
    symptom = Symptom.objects.filter(checkup=pk)
    if symptom:
        serializer = SymptomSerializer(symptom)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_symptom(request):
    serializer = SymptomSerializer(data=request.data,context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_symptom(request, pk):
    symptom = Symptom.objects.filter(pk=pk).first()
    if symptom:
        serializer = SymptomSerializer(symptom, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_symptom(request, pk):
    symptom = Symptom.objects.filter(pk=pk).first()
    if symptom:
        symptom.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# Test CRUD operations
@api_view(['GET'])
def get_tests(request):
    tests = Test.objects.all()
    serializer = TestSerializer(tests, many=True, context={'request': request})
    return Response(serializer.data)

@api_view(['GET'])
def get_test(request, pk):
    test = Test.objects.filter(checkup=pk)
    if test:
        serializer = TestSerializer(test, context={'request': request})
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
@parser_classes([MultiPartParser, FormParser])
def create_test(request):
    serializer = TestSerializer(data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT', 'PATCH'])
@parser_classes([MultiPartParser, FormParser])
def update_test(request, pk):
    test = get_object_or_404(Test, pk=pk)
    serializer = TestSerializer(test, data=request.data, partial=True, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_test(request, pk):
    test = Test.objects.filter(pk=pk).first()
    if test:
        test.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# Diagnosis CRUD operations
@api_view(['GET'])
def get_diagnoses(request):
    diagnoses = Diagnosis.objects.all()
    serializer = DiagnosisSerializer(diagnoses, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_diagnosis(request, pk):
    diagnosis = Diagnosis.objects.filter(checkup=pk)
    if diagnosis:
        serializer = DiagnosisSerializer(diagnosis)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_diagnosis(request):
    serializer = DiagnosisSerializer(data=request.data,context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_diagnosis(request, pk):
    diagnosis = Diagnosis.objects.filter(pk=pk).first()
    if diagnosis:
        serializer = DiagnosisSerializer(diagnosis, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_diagnosis(request, pk):
    diagnosis = Diagnosis.objects.filter(pk=pk).first()
    if diagnosis:
        diagnosis.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# Prescription CRUD operations
@api_view(['GET'])
def get_prescriptions(request):
    prescriptions = Prescription.objects.all()
    serializer = PrescriptionSerializer(prescriptions, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_prescription(request, pk):
    prescription = Prescription.objects.filter(checkup=pk)
    if prescription:
        serializer = PrescriptionSerializer(prescription)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_prescription(request):
    serializer = PrescriptionSerializer(data=request.data,context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_prescription(request, pk):
    prescription = Prescription.objects.filter(pk=pk).first()
    if prescription:
        serializer = PrescriptionSerializer(prescription, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_prescription(request, pk):
    prescription = Prescription.objects.filter(pk=pk).first()
    if prescription:
        prescription.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# Medicine CRUD operations
@api_view(['GET'])
def get_medicines(request):
    medicines = Medicine.objects.all()
    serializer = MedicineSerializer(medicines, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_medicine(request, pk):
    medicine = Medicine.objects.filter(prescription=pk)
    if medicine:
        serializer = MedicineSerializer(medicine)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_medicine(request):
    serializer = MedicineSerializer(data=request.data,context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_medicine(request, pk):
    medicine = Medicine.objects.filter(pk=pk).first()
    if medicine:
        serializer = MedicineSerializer(medicine, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_medicine(request, pk):
    medicine = Medicine.objects.filter(pk=pk).first()
    if medicine:
        medicine.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['GET'])
def get_record_accesses(request):
    record_accesses = RecordAccess.objects.all()
    serializer = RecordAccessSerializer(record_accesses, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_record_access(request, pk):
    record_access = RecordAccess.objects.filter(pk=pk).first()
    if record_access:
        serializer = RecordAccessSerializer(record_access)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_record_access(request):
    serializer = RecordAccessSerializer(data=request.data)
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_record_access(request, pk):
    record_access = RecordAccess.objects.filter(pk=pk).first()
    if record_access:
        serializer = RecordAccessSerializer(record_access, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_record_access(request, pk):
    record_access = RecordAccess.objects.filter(pk=pk).first()
    if record_access:
        record_access.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)

# Notification CRUD operations
@api_view(['GET'])
def get_notifications(request):
    notifications = Notification.objects.all()
    serializer = NotificationSerializer(notifications, many=True)
    return Response(serializer.data)

@api_view(['GET'])
def get_notification(request, pk):
    notification = Notification.objects.filter(pk=pk).first()
    if notification:
        serializer = NotificationSerializer(notification)
        return Response(serializer.data)
    return Response(status=status.HTTP_404_NOT_FOUND)

@api_view(['POST'])
def create_notification(request):
    serializer = NotificationSerializer(data=request.data)
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data, status=status.HTTP_201_CREATED)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['PUT'])
def update_notification(request, pk):
    notification = Notification.objects.filter(id=pk).first()
    if notification:
        serializer = NotificationSerializer(notification, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save()
            return Response(serializer.data)
    return Response(status=status.HTTP_400_BAD_REQUEST)

# Notification CRUD operations (continued)
@api_view(['DELETE'])
def delete_notification(request, pk):
    notification = Notification.objects.filter(pk=pk).first()
    if notification:
        notification.delete()
        return Response(status=status.HTTP_204_NO_CONTENT)
    return Response(status=status.HTTP_404_NOT_FOUND)






from django.contrib.auth.models import Group
from rest_framework.decorators import api_view, permission_classes
from rest_framework.permissions import IsAuthenticated




@api_view(['GET'])
def get_user_group(request, user_id):
    try:
        # Fetch the user by their ID
        user = CustomUser.objects.get(pk=user_id)
        
        # Check if the user has a group assigned
        if user.group:
            user_group = user.group.name
            return Response({'group': user_group}, status=status.HTTP_200_OK)
        else:
            return Response({'error': f'User {user_id} has no group'}, status=status.HTTP_404_NOT_FOUND)
    
    except CustomUser.DoesNotExist:
        return Response({'error': f'User {user_id} not found'}, status=status.HTTP_404_NOT_FOUND)




@api_view(['GET'])
def get_hospital_by_staff_id(request, user_id):
    try:
        # Get the StaffProfile by user_id
        staff_profile = StaffProfile.objects.get(user_id=user_id)
        # Extract the hospital ID
        hospital_id = staff_profile.hospital.id
        return Response({'hospital_id': hospital_id}, status=status.HTTP_200_OK)
    
    except StaffProfile.DoesNotExist:
        return Response({'error': 'Staff profile not found'}, status=status.HTTP_404_NOT_FOUND)
    

@api_view(['GET'])
def get_hospital_by_hospitalhead_id(request, hhead_id):
    try:
        # Get the Hospital by user_id
        hospital = Hospital.objects.get(hhead_id=hhead_id)
        # Extract the hospital ID
        hospital_id = hospital.id
        return Response({'hospital_id': hospital_id}, status=status.HTTP_200_OK)
    
    except Hospital.DoesNotExist:
        return Response({'error': 'Hospital not found for this user'}, status=status.HTTP_404_NOT_FOUND)




@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_user_profile(request, user_id):
    """
    Fetches the user profile based on the user's group (custom group field).
    """
    print(f"Fetching user profile for user_id={user_id}")
    user = CustomUser.objects.filter(id=user_id).first()
    return Response(user)






@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_patient_medical_history(request):
    profile_id = request.query_params.get('profileId')  # Get profileId from query parameters
    try:
        if not profile_id:
            return Response({"error": "profileId is required"}, status=status.HTTP_400_BAD_REQUEST)
        
        profile = Patient.objects.filter(id=profile_id).first()

        Patserializer = PatientSerializer(profile, context={'request': request})

        # Validate the profile ID exists in the Triage model
        triages = Triage.objects.filter(patient_id=profile_id)
        if not triages.exists():
            return Response({"error": "No records found for the given profile ID"}, status=status.HTTP_404_NOT_FOUND)

        # Get checkups related to the triages for the given patient profile
        checkups = Checkup.objects.filter(triage__patient_id=profile_id).select_related('doctor', 'triage__hospital')
        return Response(checkups, status=status.HTTP_200_OK)
    except Exception as e:
        return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)


# Endpoint to toggle secure status of a checkup
@api_view(['GET'])
@permission_classes([IsAuthenticated])
def toggle_secure_status(request, checkup_id):
    profile_id = request.query_params.get('profileId')  # Get profileId from query parameters

    try:
        if not profile_id:
            return Response({"error": "profileId is required"}, status=status.HTTP_400_BAD_REQUEST)
        print(f"Received profileId: {profile_id}, checkupId: {checkup_id}")

        checkup = get_object_or_404(Checkup, id=checkup_id, triage__patient_id=profile_id)
        try:
            checkup.secure = not checkup.secure
            checkup.save()
            return Response({"success": "Secure status updated", "secure": checkup.secure}, status=status.HTTP_200_OK)
        except Exception as e:
            return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)
    except Exception as e:
        return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)


@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_detailed_medical_record(request, checkup_id):
    profile_id = request.query_params.get('profileId')  # Get profileId from query parameters

    try:
        if not profile_id:
            return Response({"error": "profileId is required"}, status=status.HTTP_400_BAD_REQUEST)

        print(f"Received profileId: {profile_id}, checkupId: {checkup_id}")

        # Validate the checkup and ensure it belongs to the given profile
        checkup = get_object_or_404(Checkup, id=checkup_id, triage__patient_id=profile_id)
        print(f"Request context: {request}")

        print(f"Checkup found: {checkup.id}, linked to profileId: {profile_id}")


        diagnoses = DiagnosisSerializer(checkup.diagnoses.all(), many=True, context={"request": request}).data

        return Response(diagnoses, status=status.HTTP_200_OK)

    except Checkup.DoesNotExist:
        print("Checkup not found.")
        return Response({"error": "Checkup not found for the provided profileId"}, status=status.HTTP_404_NOT_FOUND)

    except Exception as e:
        print(f"Error occurred: {str(e)}")
        return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)


from rest_framework.decorators import api_view, permission_classes
from rest_framework.permissions import IsAuthenticated
from rest_framework.response import Response
from django.shortcuts import get_object_or_404
import logging
from .models import Patient, Notification

logger = logging.getLogger(__name__)

@api_view(['POST'])
@permission_classes([IsAuthenticated])
def validate_public_key(request):
    """
    Validates the public key for a given patient ID.
    """
    doctor_id = request.data.get('doctor_id')
    patient_id = request.data.get('patient_id')  # Example: 17
    public_key = request.data.get('public_key')  # Example: 'QwqOQM'

    if not patient_id or not public_key:
        return Response({"valid": False, "error": "Patient ID and Public Key are required."}, status=400)

    try:
        # Retrieve patient securely
        patient = get_object_or_404(Patient, id=patient_id, public_key=public_key)
        logger.info(f"Validated public key for Patient ID: {patient_id}")

        return Response({"valid": True}, status=200)

    except Exception as e:
        logger.error(f"Error validating public key: {str(e)}")
        return Response({"valid": False, "error": str(e)}, status=400)
    

# Validate secret key and access all records
@api_view(['POST'])
@permission_classes([IsAuthenticated])
def validate_secret_key(request):
    patient_id = request.data.get('patient_id')
    secret_key = request.data.get('secret_key')
    doctor_id = request.data.get('doctor_id')
    print("Patient ID:", patient_id)
    print("secret_key ID:", secret_key)
    print("doctor_id ID:", doctor_id)

    try:
        patient = get_object_or_404(Patient, id=patient_id)
        # record_access = get_object_or_404(Patient, id=patient_id, secret_key=secret_key)
        record_access = get_object_or_404(RecordAccess, patient=patient, secret_key=secret_key,doctor=doctor_id)

        return Response({"valid": True}, status=200)
    except Exception:
        return Response({"valid": False, "error": "Invalid Secret Key."}, status=400)


# create request access
@api_view(['POST'])
@permission_classes([IsAuthenticated])
def request_access(request):
    doctor_id = request.data.get('doctor_id')
    patient_id = request.data.get('patient_id')

    print("Patient ID:", patient_id)
    print("Doctor ID:", doctor_id)

    if not doctor_id or not patient_id:
        return Response({"error": "Doctor ID or Patient ID is missing"}, status=400)

    try:
        doctor = get_object_or_404(StaffProfile, id=doctor_id)  # ✅ Correctly fetch StaffProfile
        patient = get_object_or_404(Patient, id=patient_id)

        access_request, created = RequestAccess.objects.get_or_create(
            doctor=doctor, 
            patient=patient,
            hospital=doctor.hospital,  # Directly use hospital from StaffProfile
            status='pending'
        )

        if not created:
            return Response({"message": "You have already requested access for this patient."}, status=400)

        return Response({"message": "Access request submitted successfully."}, status=201)

    except Exception as e:
        print("Error:", str(e))  # Debugging
        return Response({"error": str(e)}, status=500)

@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_request_access(request):
    user = request.user
    staff_profile = get_object_or_404(StaffProfile, user=user)
    requests = RequestAccess.objects.filter(hospital=staff_profile.hospital)
    serializer = RequestAccessSerializer(requests, many=True,context={'request': request})
    return Response(serializer.data)

@api_view(['PATCH'])
@permission_classes([IsAuthenticated])
def update_request_access(request, request_id):
    admin_id = request.data.get('profile_id')
    instance = get_object_or_404(RequestAccess, id=request_id)
    admin_instance = get_object_or_404(StaffProfile, id=admin_id)
    new_status = request.data.get("status")
    print("admin_id ID:", admin_id)

    if new_status == "approved":
        RecordAccess.objects.create(
            admin=admin_instance,
            patient=instance.patient,
            doctor=instance.doctor,
            hospital=instance.hospital
        )
        instance.status = "approved"
    elif new_status == "denied":
        RecordAccess.objects.filter(doctor=instance.doctor, patient=instance.patient).delete()
        instance.status = "denied"
    else:
        return Response({"error": "Invalid status"}, status=status.HTTP_400_BAD_REQUEST)
    
    instance.save()
    serializer = RequestAccessSerializer(instance,context={'request': request})
    return Response(serializer.data)

@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_record_access(request):
    admin_id = request.GET.get('profile_id')  
    user = request.user
    admin_profile = get_object_or_404(StaffProfile, id=admin_id)
    hospital= admin_profile.hospital
    records = RecordAccess.objects.filter(hospital=hospital)
    serializer = RecordAccessSerializer(records, many=True,context={'request': request})
    return Response(serializer.data)



# Set up logging
logger = logging.getLogger(__name__)
@api_view(['GET', 'PATCH'])
@permission_classes([IsAuthenticated])
def get_update_medical_history(request, checkup_id):
    """
    API to fetch and update a specific medical history record.
    """
    logger = logging.getLogger(__name__)
    doctor_id = request.GET.get('profile_id')

    try:
        # Get doctor profile
        doctor = StaffProfile.objects.get(id=doctor_id)
        
        # Fetch the checkup record with all related models
        checkup = Checkup.objects.select_related(
            'triage__patient', 
            'triage__hospital', 
            'doctor'
        ).prefetch_related(
            'symptoms', 
            'diagnoses', 
            'prescription__medicines',
            'tests'
        ).get(id=checkup_id)
        
        # Initialize context with request
        context = {'request': request}
        
        if request.method == 'GET':
            # Prepare response data
            response_data = {
                "checkup": CheckupSerializer(checkup, context=context).data,
                "triage": TriageSerializer(checkup.triage, context=context).data if checkup.triage else None,
                "diagnoses": DiagnosisSerializer(checkup.diagnoses.all(), many=True, context=context).data,
                "symptoms": SymptomSerializer(checkup.symptoms.all(), many=True, context=context).data,
            }
            return Response(response_data, status=200)
        else:
            return Response({
                "message": "No Record",
            }, status=200)

    except StaffProfile.DoesNotExist:
        logger.error(f"Staff profile with ID {doctor_id} not found")
        return Response({'error': 'Doctor profile not found'}, status=404)
    except Checkup.DoesNotExist:
        logger.error(f"Checkup record with ID {checkup_id} not found")
        return Response({'error': 'Checkup record not found'}, status=404)
    except Exception as e:
        logger.error(f"Error in get_update_medical_history: {str(e)}")
        return Response({'error': str(e)}, status=500)


# API View
@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_patient_profile(request, patient_id):
    """
    API to fetch patient profile details and public medical history
    """
    try:
        patient = Patient.objects.get(id=patient_id)
        checkups = Checkup.objects.filter(triage__patient=patient, secure=False)  # Fetch public records
        patient_serializer = PatientSerializer(patient, context={'request': request})
        checkup_serializer = CheckupSerializer(checkups, many=True,context={'request': request})
        return Response({
            'patient': patient_serializer.data,
            'public_records': checkup_serializer.data
        }, status=200)
    except Patient.DoesNotExist:
        return Response({'error': 'Patient not found'}, status=404)
    

from django.contrib.auth.hashers import make_password
@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_users_based_on_role(request):
    """Returns hospital heads for Super Admin, staff for Hospital Head/Admin"""
    user = request.user
    if user.group.name == 'Super Admin':
        hospital_heads = HospitalHeadProfile.objects.all()
        serializer = HospitalHeadProfileSerializer(hospital_heads, many=True, context={'request': request})
        data = serializer.data
        
        # Enhance the data with hospital information
        for head_data in data:
            try:
                # Find the hospital for this head
                hospital = Hospital.objects.get(id=head_data['id'])
                head_data['hospital'] = {
                    'id': hospital.id,
                    'name': hospital.name
                }
            except Hospital.DoesNotExist:
                head_data['hospital'] = None
        
        return Response(data)

    elif user.group.name in ['Hospital Head', 'Hospital Admin']:
        if user.group.name == 'Hospital Head':
            hospital = get_object_or_404(Hospital, id=user)  # Find hospital from hospital head
        else:
            hospital_admin = get_object_or_404(CustomUser, id=user)
            hospital = hospital_admin.hospital
        # hospital = get_object_or_404(Hospital, hhead__user=user)  # Find hospital from hospital head
        staff = StaffProfile.objects.filter(hospital=hospital)
        serializer = StaffProfileSerializer(staff, many=True,context={'request': request})
        return Response(serializer.data)
    
    return Response({"error": "Unauthorized access"}, status=status.HTTP_403_FORBIDDEN)




@api_view(['PATCH'])
@permission_classes([IsAuthenticated])
def update_user_profile(request, profile_id, profile_type):
    """Updates either HospitalHeadProfile or StaffProfile based on role."""
    
    if profile_type == 'hospital_head':
        profile = get_object_or_404(HospitalHeadProfile, id=profile_id)
        serializer = HospitalHeadProfileSerializer(profile, data=request.data, partial=True,context={'request': request})
    elif profile_type == 'staff':
        profile = get_object_or_404(StaffProfile, id=profile_id)
        serializer = StaffProfileSerializer(profile, data=request.data, partial=True,context={'request': request})
    else:
        return Response({"error": "Invalid profile type"}, status=status.HTTP_400_BAD_REQUEST)
    
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)






@api_view(['DELETE'])
@permission_classes([IsAuthenticated])
def delete_user(request, user_id):
    """Delete a patient record along with associated data after confirmation"""
    user = get_object_or_404(User, id=user_id)
    # user_delete=get_object_or_404(User, id=patient.user.id)
    user.delete()
    return Response({"message": "User record deleted successfully"}, status=status.HTTP_204_NO_CONTENT)



@api_view(['POST'])
@permission_classes([IsAuthenticated])
def update_username_password(request):
    """Allows a user to update their username and password."""
    user = request.user
    username = request.data.get('username', user.username)
    current_password = request.data.get('current_password')
    new_password = request.data.get('new_password')
    
    # Authenticate current password
    if not user.check_password(current_password):
        return Response({"error": "Current password is incorrect."}, status=status.HTTP_400_BAD_REQUEST)
    
    # Update username if changed
    if username and username != user.username:
        user.username = username
    
    # Update password
    if new_password:
        user.set_password(new_password)
    
    user.save()
    return Response({"message": "Username and password updated successfully."}, status=status.HTTP_200_OK)


from django.shortcuts import get_object_or_404
from django.db.models import Q
from rest_framework.decorators import api_view, permission_classes
from rest_framework.permissions import IsAuthenticated
from rest_framework.response import Response
from rest_framework import status
from .models import Patient
from .serializers import PatientSerializer


@api_view(['GET'])
@permission_classes([IsAuthenticated])
def search_patients(request):
    """Search patients by multiple filters (ID, NIN, Phone, etc.)"""
    query_params = request.query_params
    filters = Q()
    
    if 'patient_id' in query_params:
        filters &= Q(id__icontains=query_params['patient_id'])
    if 'nin' in query_params:
        filters &= Q(nin__icontains=query_params['nin'])
    if 'phone' in query_params:
        filters &= Q(phone_number__icontains=query_params['phone'])
    if 'address' in query_params:
        filters &= Q(address__icontains=query_params['address'])
    if 'first_name' in query_params:
        filters &= Q(first_name__icontains=query_params['first_name'])
    if 'last_name' in query_params:
        filters &= Q(last_name__icontains=query_params['last_name'])
    if 'middle_name' in query_params:
        filters &= Q(middle_name__icontains=query_params['middle_name'])
    
    patients = Patient.objects.filter(filters)
    serializer = PatientSerializer(patients, many=True,context={'request': request})
    return Response(serializer.data, status=status.HTTP_200_OK)


@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_patient_details(request, patient_id):
    """Retrieve full patient details excluding sensitive keys"""
    patient = get_object_or_404(Patient, id=patient_id)
    serializer = PatientSerializer(patient,context={'request': request})
    return Response(serializer.data, status=status.HTTP_200_OK)



@api_view(['PATCH'])
@permission_classes([IsAuthenticated])
def update_patient(request, patient_id):
    """Update patient details excluding NIN, age, and keys"""
    print(f"Received update request for patient {patient_id}: {request.data}")

    patient = get_object_or_404(Patient, id=patient_id)
    excluded_fields = ['nin', 'age', 'public_key', 'private_key','profile_picture']
    data = {key: value for key, value in request.data.items() if key not in excluded_fields}
    
    print(f"Filtered data after exclusion: {data}")

    serializer = PatientSerializer(patient, data=data, partial=True, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        print("Update successful.")
        return Response(serializer.data, status=status.HTTP_200_OK)

    print(f"Update failed: {serializer.errors}")
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)


@api_view(['DELETE'])
@permission_classes([IsAuthenticated])
def delete_patient(request, patient_id):
    """Delete a patient record along with associated data after confirmation"""
    print(f"Received delete request for patient {patient_id}")

    try:
        patient = get_object_or_404(Patient, id=patient_id)
        print(f"Found patient: {patient}")
        user = get_object_or_404(CustomUser, id=patient.user.id)
        print(f"Deleting user: {user}")
        user.delete()
        return Response({"message": "Patient record deleted successfully"}, status=status.HTTP_204_NO_CONTENT)
    except Exception as e:
        print(f"Error while deleting patient: {e}")
        return Response({"error": str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)















from rest_framework.decorators import api_view, permission_classes
from rest_framework.permissions import IsAuthenticated
from rest_framework.response import Response
from django.db.models import Count, F
from django.utils import timezone
from datetime import timedelta

from .models import Diagnosis, Hospital, Checkup, StaffProfile, Patient, HospitalHeadProfile, Triage
@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_healthcare_dashboard(request):
    """
    Returns detailed healthcare analytics based on the role of the logged-in user.
    """
    user = request.user
    print(f"Username: {user.username}")
    print(f"Groups: {user.groups.name}")
    print(f"Is Superuser: {user.is_superuser}")
    print(f"Is Staff: {user.is_staff}")
    print(f"Is Active: {user.is_active}")


    thirty_days_ago = timezone.now() - timedelta(days=30)
    if hasattr(user, 'super_admin_profile'):
    # if user.groups.filter(name="Super Admin").exists():
        total_hospitals = Hospital.objects.count()
        total_staff = StaffProfile.objects.count()
        total_patients = Patient.objects.count()

        # Top 5 reported diseases
        top_diseases = Diagnosis.objects.filter(
            checkup__date__gte=thirty_days_ago
        ).values('name').annotate(
            cases=Count('id')
        ).order_by('-cases')[:5]

        # Disease hotspots (most affected districts)
        disease_hotspots = Hospital.objects.annotate(
            total_cases=Count('staff_profiles__performed_checkups__diagnoses')
        ).values('district__name', 'total_cases').order_by('-total_cases')[:5]

        # Top 5 hospitals with the most cases
        top_hospitals = Hospital.objects.annotate(
            total_cases=Count('staff_profiles__performed_checkups__diagnoses')
        ).values('name', 'total_cases').order_by('-total_cases')[:5]

        return Response({
            'totalHospitals': total_hospitals,
            'totalStaff': total_staff,
            'totalPatients': total_patients,
            'topDiseases': top_diseases,
            'diseaseHotspots': disease_hotspots,
            'topHospitals': top_hospitals
        })

    hospital_id = None
    if hasattr(user, 'hospital_head_profile'):
        hospital = Hospital.objects.filter(hhead=user.hospital_head_profile).first()
        if hospital:
            hospital_id = hospital.id

    elif hasattr(user, 'staff_profile'):
        hospital_id = user.staff_profile.hospital.id

    if hospital_id:
        hospital = Hospital.objects.get(id=hospital_id)
        staff_count = StaffProfile.objects.filter(hospital=hospital).count()
        patient_count = Patient.objects.filter(triages__hospital=hospital).distinct().count()

        # Disease statistics for this hospital
        hospital_disease_stats = Diagnosis.objects.filter(
            checkup__doctor__hospital=hospital,
            checkup__date__gte=thirty_days_ago
        ).values('name').annotate(
            cases=Count('id')
        ).order_by('-cases')[:5]

        return Response({
            'hospitalName': hospital.name,
            'totalStaff': staff_count,
            'totalPatients': patient_count,
            'topDiseases': hospital_disease_stats
        })

    if hasattr(user, 'staff_profile'):
        hospital = user.staff_profile.hospital

        # Patients treated by this staff
        treated_patients = Triage.objects.filter(
            staff=user.staff_profile
        ).values('patient__id', 'patient__first_name', 'patient__last_name').distinct()

        # Top diseases diagnosed by this staff
        treated_diseases = Diagnosis.objects.filter(
            checkup__doctor=user.staff_profile,
            checkup__date__gte=thirty_days_ago
        ).values('name').annotate(
            cases=Count('id')
        ).order_by('-cases')[:5]

        return Response({
            'role': 'Staff (Doctor/Nurse/Clerk)',
            'hospitalName': hospital.name,
            'treatedPatients': list(treated_patients),
            'topDiseases': treated_diseases
        })

    if hasattr(user, 'patient_profile'):
        patient = user.patient_profile

        # Recent checkups
        recent_checkups = Checkup.objects.filter(
            triage__patient=patient
        ).values('date', 'doctor__first_name', 'doctor__last_name', 'status')[:5]

        # Recent diagnoses
        recent_diagnoses = Diagnosis.objects.filter(
            checkup__triage__patient=patient
        ).values('name', 'note')[:25]

        return Response({
            'recentCheckups': recent_checkups,
            'recentDiagnoses': recent_diagnoses
        })

    return Response({'message': 'User role not recognized'}, status=403)





from rest_framework.response import Response
from rest_framework.decorators import api_view, permission_classes
from rest_framework.permissions import IsAuthenticated
from django.shortcuts import get_object_or_404
from .models import DoctorNotification, Notification, StaffProfile, Patient
from .serializers import DoctorNotificationSerializer, NotificationSerializer

@api_view(['GET'])
@permission_classes([IsAuthenticated])
def get_notifications(request, profile_id):
    """
    Fetch unread notifications based on the user's role (Doctor or Patient)
    """
    try:
        doctor_notifications = DoctorNotification.objects.filter(doctor__id=profile_id)
        patient_notifications = Notification.objects.filter(patient__id=profile_id)

        if doctor_notifications.exists():
            serializer = DoctorNotificationSerializer(doctor_notifications, many=True,context={'request': request})
            return Response({"notifications": serializer.data, "role": "doctor"})
        
        elif patient_notifications.exists():
            serializer = NotificationSerializer(patient_notifications, many=True,context={'request': request})
            return Response({"notifications": serializer.data, "role": "patient"})
        
        return Response({"notifications": [], "role": "unknown"})
    
    except Exception as e:
        return Response({"error": str(e)}, status=500)



@permission_classes([IsAuthenticated])
def generate_key():
    """Generate a random 6-character alphanumeric key."""
    return ''.join(random.choices(string.ascii_letters + string.digits, k=6))

@permission_classes([IsAuthenticated])
def generate_public_key(id):
    """Auto-generate and update only the public key for a specific patient."""
    from .models import Patient  # Import here to avoid circular imports
    try:
        patient = Patient.objects.get(pk=id)
        patient.public_key = generate_key()
        patient.save()
        return {"message": "Public key updated successfully", "public_key": patient.public_key}
    except ObjectDoesNotExist:
        return {"error": "Patient not found"}
    
@permission_classes([IsAuthenticated])
def generate_private_key(patient_id):
    """Auto-generate and update only the private key for a specific patient."""
    from .models import Patient
    try:
        patient = Patient.objects.get(pk=patient_id)
        patient.private_key = generate_key()
        patient.save()
        return {"message": "Private key updated successfully", "private_key": patient.private_key}
    except ObjectDoesNotExist:
        return {"error": "Patient not found"}


@api_view(['POST'])
@permission_classes([IsAuthenticated])
def generate_public_key_view(request, patient_id):
    """API endpoint to generate a new public key."""
    if request.method == 'POST':
        response = generate_public_key(patient_id)
        return JsonResponse(response)
    return JsonResponse({"error": "Invalid request method"}, status=400)


@api_view(['POST'])
@permission_classes([IsAuthenticated])
def generate_private_key_view(request, patient_id):
    """API endpoint to generate a new private key."""
    if request.method == 'POST':
        response = generate_private_key(patient_id)
        return JsonResponse(response)
    return JsonResponse({"error": "Invalid request method"}, status=400)


