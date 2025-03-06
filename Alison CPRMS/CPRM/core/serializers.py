from rest_framework import serializers
from django.contrib.auth.models import Group
from .models import (
    CustomUser, DoctorNotification, Region, District, HospitalHeadProfile, Hospital, RequestAccess, StaffProfile, 
    Patient, SuperAdminProfile, Triage, Checkup, Symptom, Test, Diagnosis, 
    Prescription, Medicine, RecordAccess, Notification
)

class GroupSerializer(serializers.ModelSerializer):
    class Meta:
        model = Group
        fields = ['id', 'name']

class CustomUserSerializer(serializers.ModelSerializer):
    class Meta:
        model = CustomUser
        fields = ['id', 'email', 'username', 'password', 'is_active', 'is_staff', 'profile_set', 'date_joined', 'group']
    
    def create(self, validated_data):
        password = validated_data.pop('password', None)
        instance = self.Meta.model(**validated_data)
        if password is not None:
            instance.set_password(password)
        instance.save()
        return instance

class RegionSerializer(serializers.ModelSerializer):
    class Meta:
        model = Region
        fields = ['id', 'name']

class DistrictSerializer(serializers.ModelSerializer):

    class Meta:
        model = District
        fields = ['id', 'name', 'region', 'region_id']

class HospitalHeadProfileSerializer(serializers.ModelSerializer):
    profile_picture_url = serializers.SerializerMethodField()

    class Meta:
        model = HospitalHeadProfile
        fields = ['id', 'user', 'first_name', 'last_name', 'phone_number', 'address', 'profile_picture', 'profile_picture_url']

    def get_profile_picture_url(self, obj):
        if obj.profile_picture:
            return self.context['request'].build_absolute_uri(obj.profile_picture.url)
        return None

class HospitalSerializer(serializers.ModelSerializer):
    class Meta:
        model = Hospital
        fields = ['id', 'name', 'address', 'emergency_number', 'district',  'hhead']

class StaffProfileSerializer(serializers.ModelSerializer):
    profile_picture_url = serializers.SerializerMethodField()

    class Meta:
        model = StaffProfile
        fields = ['id', 'user', 'first_name', 'middle_name', 'last_name', 'phone_number','address', 'hospital', 'specialty', 'hire_date', 'profile_picture', 'profile_picture_url']

    def get_profile_picture_url(self, obj):
        if obj.profile_picture:
            return self.context['request'].build_absolute_uri(obj.profile_picture.url)
        return None

class PatientSerializer(serializers.ModelSerializer):
    age = serializers.ReadOnlyField()
    profile_picture_url = serializers.SerializerMethodField()

    class Meta:
        model = Patient
        fields = ['id', 'user',  'first_name', 'middle_name', 'last_name', 'date_of_birth', 'age', 'gender', 'phone_number','nin','address', 'emergency_contact_name', 'emergency_contact_number', 'profile_picture', 'profile_picture_url', 'public_key', 'private_key', 'blood_type', 'medical_info']

    def get_profile_picture_url(self, obj):
        if obj.profile_picture:
            return self.context['request'].build_absolute_uri(obj.profile_picture.url)
        return None

class SuperAdminProfileSerializer(serializers.ModelSerializer):
    profile_picture_url = serializers.SerializerMethodField()

    class Meta:
        model = SuperAdminProfile
        fields = ['id', 'user', 'first_name', 'last_name', 'phone_number', 'address', 'profile_picture', 'profile_picture_url']

    def get_profile_picture_url(self, obj):
        if obj.profile_picture:
            return self.context['request'].build_absolute_uri(obj.profile_picture.url)
        return None

class TriageSerializer(serializers.ModelSerializer):
    class Meta:
        model = Triage
        fields = ['id', 'date', 'patient', 'staff', 'hospital', 'blood_pressure', 'heart_rate', 'temperature', 'oxygen_saturation', 'chief_complaint', 'priority_level', 'initial_assessment']


class CheckupSerializer(serializers.ModelSerializer):

    class Meta:
        model = Checkup
        fields = ['id', 'date', 'doctor', 'triage', 'secure', 'status']

class SymptomSerializer(serializers.ModelSerializer):


    class Meta:
        model = Symptom
        fields = ['id', 'checkup',  'name', 'severity', 'note']


class TestSerializer(serializers.ModelSerializer):
    test_result_url = serializers.SerializerMethodField()

    class Meta:
        model = Test
        fields = ['id', 'checkup','test_result', 'test_result_url', 'upload_date', 'test_type']

    def get_test_result_url(self, obj):
        request = self.context.get('request')
        if not request:
            return None
            
        if obj.test_result:
            try:
                return request.build_absolute_uri(obj.test_result.url)
            except Exception:
                return None
        return None
    
class DiagnosisSerializer(serializers.ModelSerializer):


    class Meta:
        model = Diagnosis
        fields = ['id', 'checkup', 'name', 'note']

class PrescriptionSerializer(serializers.ModelSerializer):
    checkup = CheckupSerializer(read_only=True)
    checkup_id = serializers.PrimaryKeyRelatedField(queryset=Checkup.objects.all(), source='checkup', write_only=True)

    class Meta:
        model = Prescription
        fields = ['id', 'checkup', 'checkup_id', 'date_prescribed', 'status', 'note']

class MedicineSerializer(serializers.ModelSerializer):


    class Meta:
        model = Medicine
        fields = ['id', 'prescription',  'name', 'dosage', 'frequency', 'duration','note']

class RecordAccessSerializer(serializers.ModelSerializer):


    class Meta:
        model = RecordAccess
        fields = ['id', 'admin',  'patient', 'doctor','hospital', 'secret_key', 'created_at']



class NotificationSerializer(serializers.ModelSerializer):
    patient = PatientSerializer(read_only=True)
    patient_id = serializers.PrimaryKeyRelatedField(queryset=Patient.objects.all(), source='patient', write_only=True)
    doctor = StaffProfileSerializer(read_only=True)
    doctor_id = serializers.PrimaryKeyRelatedField(queryset=StaffProfile.objects.all(), source='doctor', write_only=True, required=False, allow_null=True)
    secret_key = serializers.CharField(read_only=True)  # Ensure it's included in responses but not required for input

    class Meta:
        model = DoctorNotification
        fields = ['id', 'doctor', 'doctor_id', 'patient', 'patient_id', 'secret_key', 'message', 'created_at', 'read']




class RequestAccessSerializer(serializers.ModelSerializer):


    class Meta:
        model = RequestAccess
        fields = ['id', 'doctor','patient', 'hospital',  'status'] #,'created_at'

    def create(self, validated_data):
        # Automatically set the hospital if not provided
        if 'hospital' not in validated_data:
            doctor = validated_data.get('doctor')
            staff_profile = doctor.staff_profile if hasattr(doctor, 'staff_profile') else None
            if staff_profile and staff_profile.hospital:
                validated_data['hospital'] = staff_profile.hospital
        return super().create(validated_data)