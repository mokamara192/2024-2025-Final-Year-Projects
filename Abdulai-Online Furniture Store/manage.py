#!/usr/bin/env python
"""Django's command-line utility for administrative tasks."""
import os
import sys


def main():
    """Run administrative tasks."""
<<<<<<< HEAD
    os.environ.setdefault('DJANGO_SETTINGS_MODULE', 'office_ops.settings')
=======
    os.environ.setdefault('DJANGO_SETTINGS_MODULE', 'ecom_prj.settings')
>>>>>>> a76eb3f727e2c8c255975735514dc8a73e23b77e
    try:
        from django.core.management import execute_from_command_line
    except ImportError as exc:
        raise ImportError(
            "Couldn't import Django. Are you sure it's installed and "
            "available on your PYTHONPATH environment variable? Did you "
            "forget to activate a virtual environment?"
        ) from exc
    execute_from_command_line(sys.argv)


if __name__ == '__main__':
    main()
