
from django.db.models.signals import post_save
from django.dispatch import receiver
from .models import CustomUser, Employee

@receiver(post_save, sender=CustomUser)
def create_user_profile(sender, instance, created, **kwargs):
    if created:
        if instance.user_type == "3":  # Employee
            Employee.objects.create(admin=instance)
