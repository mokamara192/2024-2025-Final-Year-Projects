from django.contrib import admin
from django.contrib.auth.admin import UserAdmin
from django.contrib.auth.models import Group
from django.core.exceptions import PermissionDenied
from .models import CustomUser, DoctorNotification, Region, District, Hospital, HospitalHeadProfile, RequestAccess, StaffProfile, Patient, SuperAdminProfile,Checkup, Symptom
from .models import  Diagnosis, Prescription, Medicine, Notification, RecordAccess

class CustomUserAdmin(UserAdmin):
    model = CustomUser
    list_display = ('id','username', 'email', 'is_active', 'is_staff', 'profile_set', 'group')
    list_filter = ('is_active', 'is_staff', 'profile_set', 'group')
    fieldsets = (
        (None, {'fields': ('username', 'email', 'password')}),
        ('Permissions', {'fields': ('is_active', 'is_staff', 'is_superuser', 'profile_set', 'group', 'user_permissions')}),
        ('Important dates', {'fields': ('last_login', 'date_joined')}),
    )
    add_fieldsets = (
        (None, {
            'classes': ('wide',),
            'fields': ('username', 'email', 'password1', 'password2', 'is_active', 'is_staff', 'profile_set', 'group'),
        }),
    )
    search_fields = ('username', 'email')
    ordering = ('username',)

    def get_form(self, request, obj=None, **kwargs):
        form = super().get_form(request, obj, **kwargs)
        is_superuser = request.user.is_superuser

        if not is_superuser:
            if 'group' in form.base_fields:
                group_field = form.base_fields['group']
                allowed_groups = ['Staff']
                if request.user.has_perm('auth.can_create_hospital_head'):
                    allowed_groups.append('Hospital Head')
                group_field.queryset = Group.objects.filter(name__in=allowed_groups)

        return form

    def save_model(self, request, obj, form, change):
        if not change:  # This is a new user being created
            if obj.group and obj.group.name in ['Super Admin', 'Hospital Head']:
                if not request.user.has_perm('auth.can_create_super_admin'):
                    raise PermissionDenied("You don't have permission to create this user type.")
            
            # Ensure user is not activated until properly set up
            obj.is_active = False
            
        super().save_model(request, obj, form, change)

    def save_related(self, request, form, formsets, change):
        super().save_related(request, form, formsets, change)
        form.instance._assign_group_permissions()

admin.site.register(CustomUser, CustomUserAdmin)

@admin.register(Region)
class RegionAdmin(admin.ModelAdmin):
    list_display = ('name',)
    search_fields = ('name',)

@admin.register(District)
class DistrictAdmin(admin.ModelAdmin):
    list_display = ('name', 'region')
    list_filter = ('region',)
    search_fields = ('name', 'region__name')

class HospitalHeadProfileInline(admin.StackedInline):
    model = HospitalHeadProfile
    can_delete = False
    verbose_name_plural = 'Hospital Head Profile'

@admin.register(Hospital)
class HospitalAdmin(admin.ModelAdmin):
    list_display = ('id','name', 'district', 'hhead')
    list_filter = ('district__region', 'district')
    search_fields = ('name', 'district__name', 'user__email')
    raw_id_fields = ('hhead',)

@admin.register(HospitalHeadProfile)
class HospitalHeadProfileAdmin(admin.ModelAdmin):
    list_display = ('id','user', 'first_name', 'last_name', 'phone_number')
    search_fields = ('user__email', 'first_name', 'last_name', 'phone_number')
    raw_id_fields = ('user',)

    def get_queryset(self, request):
        qs = super().get_queryset(request)
        if request.user.is_superuser:
            return qs
        if request.user.group and request.user.group.name == 'Hospital Admin':
            return qs.filter(managed_hospital__staffprofile__user=request.user)
        return qs.none()  # Non-superusers and non-hospital admins can't see any hospital head profiles

    def has_add_permission(self, request):
        return request.user.is_superuser

    def has_change_permission(self, request, obj=None):
        return request.user.is_superuser

    def has_delete_permission(self, request, obj=None):
        return request.user.is_superuser

@admin.register(StaffProfile)
class StaffProfileAdmin(admin.ModelAdmin):
    list_display = ('id','user', 'first_name', 'last_name', 'hospital', 'specialty', 'profile_picture')
    list_filter = ('hospital', 'specialty')
    search_fields = ('user__email', 'first_name', 'last_name', 'hospital__name', 'specialty')
    raw_id_fields = ('user', 'hospital')

    def save_model(self, request, obj, form, change):
        if not change:  # This is a new staff profile being created
            if request.user.group and request.user.group.name == 'Hospital Admin':
                obj.hospital = request.user.staff_profile.hospital
        super().save_model(request, obj, form, change)

    def has_add_permission(self, request):
        if request.user.group and request.user.group.name in ['Super Admin', 'Hospital Admin']:
            return True
        return False

@admin.register(Patient)
class PatientAdmin(admin.ModelAdmin):
    list_display = ('id','user', 'first_name', 'last_name', 'date_of_birth', 'age','gender','nin','blood_type','medical_info','public_key', 'private_key')
    list_filter = ('gender',)
    search_fields = ('user__email', 'first_name', 'last_name', 'phone_number','nin')
    raw_id_fields = ('user',)

@admin.register(SuperAdminProfile)
class SuperAdminProfileAdmin(admin.ModelAdmin):
    list_display = ('id','user', 'first_name', 'last_name', 'phone_number')
    search_fields = ('user__email', 'first_name', 'last_name', 'phone_number')
    raw_id_fields = ('user',)

    def has_add_permission(self, request):
        return request.user.is_superuser

    def has_change_permission(self, request, obj=None):
        return request.user.is_superuser

    def has_delete_permission(self, request, obj=None):
        return request.user.is_superuser


@admin.register(Checkup)
class CheckupAdmin(admin.ModelAdmin):
    list_display = ('date', 'doctor', 'secure','status')
    search_fields = ('doctor__username', 'status')
    list_filter = ('status', 'date')

@admin.register(Symptom)
class SymptomAdmin(admin.ModelAdmin):
    list_display = ('checkup', 'name', 'severity')
    search_fields = ('name', 'checkup__doctor__username')
    list_filter = ('severity',)


@admin.register(Diagnosis)
class DiagnosisAdmin(admin.ModelAdmin):
    list_display = ('checkup', 'name')
    search_fields = ('name', 'checkup__doctor__username')

@admin.register(Prescription)
class PrescriptionAdmin(admin.ModelAdmin):
    list_display = ('checkup', 'date_prescribed', 'status')
    search_fields = ('checkup__doctor__username',)
    list_filter = ('status', 'date_prescribed')

@admin.register(Medicine)
class MedicineAdmin(admin.ModelAdmin):
    list_display = ('prescription', 'name', 'dosage', 'frequency', 'duration','note')
    search_fields = ('name', 'prescription__checkup__doctor__username')

# Register the Notification model
@admin.register(Notification)
class NotificationAdmin(admin.ModelAdmin):
    list_display = ('patient', 'doctor','admin', 'event_type', 'created_at', 'read')
    search_fields = ('patient__username', 'doctor__username', 'event_type')
    list_filter = ('event_type', 'read', 'created_at')
    ordering = ('-created_at',)


@admin.register(DoctorNotification)
class DoctorNotificationAdmin(admin.ModelAdmin):
    list_display = ('patient', 'doctor','created_at', 'read')
    search_fields = ('patient__username', 'doctor__username', 'event_type')
    list_filter = ('read', 'created_at')
    ordering = ('-created_at',)


@admin.register(RecordAccess)
class RecordAccessAdmin(admin.ModelAdmin):
    list_display = ('id', 'admin', 'patient', 'doctor','hospital__name', 'secret_key', 'created_at')
    search_fields = ('admin__username', 'patient__user__username', 'doctor__username', 'secret_key')
    list_filter = ('created_at',)
    ordering = ('-created_at',)



@admin.register(RequestAccess)
class RequestAccessAdmin(admin.ModelAdmin):
    list_display = ('id', 'doctor', 'patient', 'hospital', 'status')  # Display these fields in the admin list view
    list_filter = ('status', 'hospital')  # Add filters for status status and hospital
    search_fields = ('doctor__username', 'patient__username', 'hospital__name')  # Add search functionality
    ordering = ('-id',)  # Order by ID descending by default
    list_editable = ('status',)  # Allow inline editing of the 'status' status
    readonly_fields = ('hospital',)  # Make hospital field status-only as it's auto-assigned

    def get_queryset(self, request):
        """Optimize queries to prefetch related objects for efficiency."""
        queryset = super().get_queryset(request)
        return queryset.select_related('doctor', 'patient', 'hospital')

    def has_change_permission(self, request, obj=None):
        """Customize change permission if needed."""
        return True  # Modify this logic if specific permissions are required