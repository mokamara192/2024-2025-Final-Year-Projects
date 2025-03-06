import random
import string
from django.db import models
from django.contrib.auth.models import AbstractBaseUser, BaseUserManager, PermissionsMixin, Group
from django.core.validators import RegexValidator
from django.utils import timezone
from django.db.models.signals import post_save, pre_save
from django.dispatch import receiver
import os
import uuid
from django.core.validators import FileExtensionValidator


# Helper function to generate a unique filename for profile pictures
def upload_to(instance, filename):
    ext = filename.split(',')[-7]
    filename = f"{uuid.uuid4()}.{ext}"
    return os.path.join('profile_pics/', filename)

def upload_test(instance, filename):
    ext = filename.split('.')[-1]
    filename = f"{uuid.uuid4()}.{ext}"
    return os.path.join('test_result/', filename)

# Function to delete old profile picture
def delete_old_profile_picture(instance):
    try:
        old_instance = instance.__class__.objects.get(id=instance.id)
        if old_instance.profile_picture and old_instance.profile_picture != instance.profile_picture:
            old_instance.profile_picture.delete(save=False)
    except instance.__class__.DoesNotExist:
        pass

# Custom User Manager
class CustomUserManager(BaseUserManager):
    def create_user(self, email, username, password=None, **extra_fields):
        if not email:
            raise ValueError('The Email field must be set')
        email = self.normalize_email(email)
        user = self.model(email=email, username=username, **extra_fields)
        user.set_password(password)
        user.save(using=self._db)
        return user

    def create_superuser(self, email, username, password=None, **extra_fields):
        extra_fields.setdefault('is_staff', True)
        extra_fields.setdefault('is_superuser', True)
        extra_fields.setdefault('is_active', True)

        if extra_fields.get('is_staff') is not True:
            raise ValueError('Superuser must have is_staff=True.')
        if extra_fields.get('is_superuser') is not True:
            raise ValueError('Superuser must have is_superuser=True.')

        return self.create_user(email, username, password, **extra_fields)

# Custom User model
class CustomUser(AbstractBaseUser, PermissionsMixin):
    email = models.EmailField(unique=True)
    username = models.CharField(max_length=150, unique=True)
    is_active = models.BooleanField(default=False)
    is_staff = models.BooleanField(default=True)
    profile_set = models.BooleanField(default=False)
    date_joined = models.DateTimeField(default=timezone.now)
    group = models.ForeignKey(Group, on_delete=models.SET_NULL, null=True, related_name='users')

    objects = CustomUserManager()

    USERNAME_FIELD = 'username'
    REQUIRED_FIELDS = ['email']

    def __str__(self):
        return self.username

    def save(self, *args, **kwargs):
        is_new = self.pk is None
        if is_new and self.group and self.group.name == 'Super Admin':
            self.is_staff = True
            self.is_superuser = True
        super().save(*args, **kwargs)
        if is_new or self.group_id != self._initial_group_id:
            self._assign_group_permissions()

    def _assign_group_permissions(self):
        if self.group:
            self.user_permissions.set(self.group.permissions.all())
        else:
            self.user_permissions.clear()

    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self._initial_group_id = self.group_id

# Signal to assign permissions on user save
@receiver(post_save, sender=CustomUser)
def assign_permissions_on_save(sender, instance, created, **kwargs):
    if created or instance.group_id != instance._initial_group_id:
        instance._assign_group_permissions()

# Region model
class Region(models.Model):
    name = models.CharField(max_length=100, unique=True)

    def __str__(self):
        return self.name

# District model
class District(models.Model):
    name = models.CharField(max_length=100)
    region = models.ForeignKey(Region, on_delete=models.CASCADE, related_name='districts')

    class Meta:
        unique_together = ['name', 'region']

    def __str__(self):
        return f"{self.name}, {self.region.name}"

# from django.db import models
from django.db.models.signals import pre_save
from django.dispatch import receiver
# from django.utils.timezone import now




# HospitalHeadProfile model
class HospitalHeadProfile(models.Model):
    user = models.OneToOneField(CustomUser, on_delete=models.CASCADE, related_name='hospital_head_profile')
    first_name = models.CharField(max_length=100)
    last_name = models.CharField(max_length=100)
    phone_regex = RegexValidator(regex=r'^\+?1?\d{9,15}$', message="Phone number must be entered in the format: '+999999999'. Up to 15 digits allowed.")
    phone_number = models.CharField(validators=[phone_regex], max_length=17)
    address = models.TextField()
    profile_picture = models.ImageField(upload_to=upload_to, blank=True, null=True)

    def __str__(self):
        return f"{self.first_name} {self.last_name} - Hospital Head"



# Hospital model
class Hospital(models.Model):
    name = models.CharField(max_length=255)
    address = models.TextField()
    emergency_number = models.CharField(max_length=20)
    district = models.ForeignKey(District, on_delete=models.SET_NULL, null=True, related_name='hospitals')
    hhead = models.OneToOneField(HospitalHeadProfile, on_delete=models.PROTECT, related_name='hospital_head')

    def __str__(self):
        return self.name                      




# StaffProfile model
class StaffProfile(models.Model):
    user = models.OneToOneField(CustomUser, on_delete=models.CASCADE, related_name='staff_profile')
    first_name = models.CharField(max_length=100)
    middle_name = models.CharField(max_length=100, blank=True, null=True)
    last_name = models.CharField(max_length=100)
    phone_regex = RegexValidator(regex=r'^\+?1?\d{9,15}$', message="Phone number must be entered in the format: '+999999999'. Up to 15 digits allowed.")
    phone_number = models.CharField(validators=[phone_regex], max_length=17, blank=True, null=True)
    address = models.TextField()
    hospital = models.ForeignKey(Hospital, on_delete=models.CASCADE, related_name='staff_profiles')
    specialty = models.CharField(max_length=100, blank=True, null=True)
    hire_date = models.DateField(auto_now_add=True)
    profile_picture = models.ImageField(upload_to=upload_to, blank=True, null=True)





# SuperAdminProfile model
class SuperAdminProfile(models.Model):
    user = models.OneToOneField(CustomUser, on_delete=models.CASCADE, related_name='super_admin_profile')
    first_name = models.CharField(max_length=100)
    last_name = models.CharField(max_length=100)
    phone_regex = RegexValidator(regex=r'^\+?1?\d{9,15}$', message="Phone number must be entered in the format: '+999999999'. Up to 15 digits allowed.")
    phone_number = models.CharField(validators=[phone_regex], max_length=17)
    address = models.TextField()
    profile_picture = models.ImageField(upload_to=upload_to, blank=True, null=True)

    def __str__(self):
        return f"{self.first_name} {self.last_name} - Super Admin"







# Patient model
class Patient(models.Model):
    GENDER_CHOICES = (
        ('M', 'Male'),
        ('F', 'Female'),
        ('O', 'Other'),
    )

    user = models.OneToOneField(CustomUser, on_delete=models.CASCADE, related_name='patient_profile')
    first_name = models.CharField(max_length=100)
    middle_name = models.CharField(max_length=100, blank=True, null=True)
    last_name = models.CharField(max_length=100)
    date_of_birth = models.DateField()
    age = models.IntegerField(editable=False)  # New field for storing age
    gender = models.CharField(max_length=1, choices=GENDER_CHOICES)
    phone_regex = RegexValidator(regex=r'^\+?1?\d{9,15}$', message="Phone number must be entered in the format: '+999999999'. Up to 15 digits allowed.")
    phone_number = models.CharField(validators=[phone_regex], max_length=17, blank=True, null=True)
    nin_regex = RegexValidator(regex=r'^[A-Za-z0-9]{8}$', message="NIN must be exactly 8 alphanumeric characters.")
    nin = models.CharField(validators=[nin_regex], max_length=8, blank=True, null=True)
    address = models.TextField()
    emergency_contact_name = models.CharField(max_length=100)
    emergency_contact_number = models.CharField(validators=[phone_regex], max_length=17)
    profile_picture = models.ImageField(upload_to=upload_to, blank=True, null=True)
    public_key = models.CharField(max_length=6, blank=True, null=True)
    private_key = models.CharField(max_length=6, blank=True, null=True)
    blood_type = models.CharField(max_length=10, default='N/A')
    medical_info = models.TextField(default='N/A', help_text="Allergies, hereditary conditions, etc.")

    @property
    def calculate_age(self):
        today = timezone.now().date()
        return today.year - self.date_of_birth.year - ((today.month, today.day) < (self.date_of_birth.month, self.date_of_birth.day))


    def save(self, *args, **kwargs):
        # Set the age before saving
        self.age = self.calculate_age

        if not self.public_key:
            self.public_key = self.generate_key()
        if not self.private_key:
            self.private_key = self.generate_key()
        delete_old_profile_picture(self)
        super().save(*args, **kwargs)

    def regenerate_private_key(self):
        self.private_key = self.generate_key()
        self.save()

    def __str__(self):
        return f"{self.first_name} {self.last_name} - {self.age} years old"






class Triage(models.Model):
    date = models.DateTimeField(auto_now_add=True)
    patient = models.ForeignKey(Patient, on_delete=models.CASCADE, related_name='triages')
    staff = models.ForeignKey(StaffProfile, on_delete=models.CASCADE, related_name='performed_triages')
    blood_pressure = models.CharField(max_length=20)
    heart_rate = models.IntegerField()
    temperature = models.DecimalField(max_digits=4, decimal_places=1)
    hospital = models.ForeignKey(Hospital, on_delete=models.CASCADE, related_name='triage_hospital')
    oxygen_saturation = models.IntegerField()
    chief_complaint = models.TextField()
    priority_level = models.CharField(max_length=20, choices=[
        ('low', 'Low'),
        ('moderate', 'Moderate'),
        ('high', 'High'),
        ('emergency', 'Emergency')
    ])
    initial_assessment = models.TextField()
    
    def __str__(self):
        return f"Triage for {self.patient} on {self.date}"




class Checkup(models.Model):
    STATUS_CHOICES = [
        ('ongoing', 'Ongoing'),
        ('completed', 'Completed'),
        ('cancelled', 'Cancelled'),
    ]
    date = models.DateTimeField(auto_now_add=True)
    doctor = models.ForeignKey(StaffProfile, on_delete=models.CASCADE, related_name='performed_checkups')
    triage = models.OneToOneField(Triage, on_delete=models.CASCADE)
    secure = models.BooleanField(default=False)
    status = models.CharField(max_length=20, choices=STATUS_CHOICES, default='ongoing')
    
    def __str__(self):
        return f"Checkup by Dr. {self.doctor} on {self.date} - {self.get_status_display()}"




class Symptom(models.Model):
    SEVERITY_CHOICES = [
        ('mild', 'Mild'),
        ('moderate', 'Moderate'),
        ('severe', 'Severe'),
    ]
    checkup = models.ForeignKey(Checkup, on_delete=models.CASCADE, related_name='symptoms')
    name = models.CharField(max_length=100)
    severity = models.CharField(max_length=10, choices=SEVERITY_CHOICES)
    note = models.TextField(blank=True)
    
    class Meta:
        unique_together = ['checkup', 'name']
    
    def __str__(self):
        return f"{self.name} - {self.severity}"

class Test(models.Model):
    checkup = models.ForeignKey(Checkup, on_delete=models.CASCADE, related_name='tests')
    test_result = models.FileField(upload_to=upload_test, validators=[FileExtensionValidator(allowed_extensions=['pdf', 'jpg', 'png', 'jpeg', 'doc', 'docx'])])
    upload_date = models.DateTimeField(auto_now_add=True)
    test_type = models.CharField(max_length=100)
    
    class Meta:
        unique_together = ['checkup', 'test_result']
    
    def __str__(self):
        return f"{self.test_type} for {self.checkup} on {self.upload_date}"

class Diagnosis(models.Model):
    checkup = models.ForeignKey(Checkup, on_delete=models.CASCADE, related_name='diagnoses')
    name = models.CharField(max_length=200)
    note = models.TextField()
    
    def __str__(self):
        return f"{self.name} for {self.checkup}"

class Prescription(models.Model):
    STATUS_CHOICES = [
        ('active', 'Active'),
        ('inactive', 'Inactive'),
    ]
    checkup = models.OneToOneField(Checkup, on_delete=models.CASCADE)
    date_prescribed = models.DateTimeField(auto_now_add=True)
    status = models.CharField(max_length=10, choices=STATUS_CHOICES, default='active')
    note = models.TextField(blank=True)
    
    def __str__(self):
        return f"Prescription for {self.checkup} - {self.get_status_display()}"

class Medicine(models.Model):
    prescription = models.ForeignKey(Prescription, on_delete=models.CASCADE, related_name='medicines')
    name = models.CharField(max_length=100)
    dosage = models.CharField(max_length=100)
    frequency = models.CharField(max_length=100)  # e.g., "Twice daily", "Every 8 hours"
    duration = models.CharField(max_length=100)  # e.g., "7 days", "Until finished"
    note=models.CharField(max_length=200, blank=True, null=True)
    class Meta:
        unique_together = ['prescription', 'name']
    
    def __str__(self):
        return f"{self.name} - {self.dosage}"



class RecordAccess(models.Model):
    admin = models.ForeignKey('StaffProfile', on_delete=models.CASCADE, related_name='admin_record_access')
    patient = models.ForeignKey('Patient', on_delete=models.CASCADE, related_name='patient_record_access')
    doctor = models.ForeignKey('StaffProfile', on_delete=models.CASCADE, related_name='doctor_record_access')
    hospital = models.ForeignKey(Hospital, on_delete=models.CASCADE, related_name='RecordtAccess_hospital')
    secret_key = models.CharField(max_length=6, unique=True, blank=True, null=True)  # Allow blank and null values
    created_at = models.DateTimeField(auto_now_add=True)  # Automatically set timestamp

    def generate_secret_key(self):
        return ''.join(random.choices(string.ascii_letters + string.digits, k=6))

    def save(self, *args, **kwargs):
        if not self.secret_key:  # If secret_key is not provided, generate one
            self.secret_key = self.generate_secret_key()
        super().save(*args, **kwargs)

    class Meta:
        unique_together = ['patient', 'doctor', 'secret_key']

    def __str__(self):
        return f"Access for Dr. {self.doctor.first_name} {self.doctor.last_name} to {self.patient.first_name}'s records"

class Notification(models.Model):
    doctor = models.ForeignKey(StaffProfile, on_delete=models.CASCADE, related_name='doctor_notifications')  # Targeted doctor
    patient = models.ForeignKey(Patient, on_delete=models.CASCADE, related_name='doctor_notified_patient')  # Patient related to access
    secret_key = models.CharField(max_length=6)  # The granted secret key
    message = models.TextField()  # Notification message
    created_at = models.DateTimeField(auto_now_add=True)  # Timestamp
    read = models.BooleanField(default=False)  # Read status

    def __str__(self):
        return f"Doctor Notification for {self.doctor.first_name}: Secret Key for {self.patient.first_name}"






class RequestAccess(models.Model):
    STATUS_CHOICES = [
        ('pending', 'Pending'),
        ('approved', 'Approved'),
        ('denied', 'Denied'),
    ]  
    doctor = models.ForeignKey(StaffProfile, related_name='doctor_requests', on_delete=models.CASCADE)
    patient = models.ForeignKey(Patient, related_name='patient_requests', on_delete=models.CASCADE)
    hospital = models.ForeignKey(Hospital, on_delete=models.CASCADE, related_name='RequestAccess_hospital')
    status = models.CharField(max_length=10, choices=STATUS_CHOICES, default='pending')
    created_at = models.DateTimeField(default=timezone.now)

    def save(self, *args, **kwargs):
        # ❌ Remove redundant query, as `self.doctor` is already a StaffProfile
        if self.doctor and not self.hospital:
            self.hospital = self.doctor.hospital  # Directly access hospital
        super(RequestAccess, self).save(*args, **kwargs)
    
    
    @classmethod
    def cleanup_old_records(cls):
        """
        Delete all records that are not from the current day
        Removes records from all statuses
        """
        # Get today's date
        today = timezone.now().date()
        
        # Delete records not from today
        old_records = cls.objects.exclude(created_at__date=today)
        
        # Count and delete old records
        record_count = old_records.count()
        old_records.delete()
        
        return record_count

    def __str__(self):
        return f"{self.doctor} - {self.patient} - {self.status}"
