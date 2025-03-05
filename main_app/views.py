import json
from django.contrib import messages
from django.contrib.auth import authenticate, login, logout
from django.http import HttpResponse, JsonResponse
from django.shortcuts import get_object_or_404, redirect, render, reverse
from django.views.decorators.csrf import csrf_exempt
from django.contrib.auth.views import PasswordResetView, PasswordResetDoneView, PasswordResetConfirmView, PasswordResetCompleteView

from .EmailBackend import EmailBackend
from .models import Attendance, Department
from django.views.decorators.csrf import ensure_csrf_cookie


def login_page(request):
    if request.user.is_authenticated:
        if request.user.user_type == '1':
            return redirect(reverse("admin_home"))
        elif request.user.user_type == '2':
            return redirect(reverse("manager_home"))
        else:
            return redirect(reverse("employee_home"))
    return render(request, 'main_app/login.html')


from django.contrib.auth import login
from .EmailBackend import EmailBackend

def doLogin(request, **kwargs):
    if request.method != 'POST':
        return HttpResponse("<h4>Denied</h4>")
    else:
        email = request.POST.get('email')
        password = request.POST.get('password')

        # Authenticate using the custom EmailBackend
        user = EmailBackend().authenticate(request, username=email, password=password)
        if user is not None:
            # Explicitly set the backend attribute on the user
            user.backend = 'django.contrib.auth.backends.ModelBackend'  # Or your custom backend path
            login(request, user)

            # Redirect based on user type
            if user.user_type == '1':
                return redirect(reverse("admin_home"))
            elif user.user_type == '2':
                return redirect(reverse("manager_home"))
            else:
                return redirect(reverse("employee_home"))
        else:
            messages.error(request, "Invalid email or password")
            return redirect("/")


def logout_user(request):
    if request.user.is_authenticated:
        logout(request)
    return redirect("/")


@ensure_csrf_cookie
def get_attendance(request):
    if request.method == 'POST':
        department_id = request.POST.get('department')
        try:
            department = get_object_or_404(Department, id=department_id)
            attendance = Attendance.objects.filter(department=department).order_by('-date')
            attendance_list = [{"id": attd.id, "attendance_date": attd.date.strftime('%Y-%m-%d')} for attd in attendance]
            return JsonResponse(attendance_list, safe=False)
        except Exception as e:
            return JsonResponse({"error": str(e)}, status=500)
    return JsonResponse({"error": "Invalid request method"}, status=400)


def showFirebaseJS(request):
    data = """
    // Give the service worker access to Firebase Messaging.
// Note that you can only use Firebase Messaging here, other Firebase libraries
// are not available in the service worker.
importScripts('https://www.gstatic.com/firebasejs/7.22.1/firebase-app.js');
importScripts('https://www.gstatic.com/firebasejs/7.22.1/firebase-messaging.js');

// Initialize the Firebase app in the service worker by passing in
// your app's Firebase config object.
// https://firebase.google.com/docs/web/setup#config-object
firebase.initializeApp({
    apiKey: "AIzaSyBarDWWHTfTMSrtc5Lj3Cdw5dEvjAkFwtM",
    authDomain: "sms-with-django.firebaseapp.com",
    databaseURL: "https://sms-with-django.firebaseio.com",
    projectId: "sms-with-django",
    storageBucket: "sms-with-django.appspot.com",
    messagingSenderId: "945324593139",
    appId: "1:945324593139:web:03fa99a8854bbd38420c86",
    measurementId: "G-2F2RXTL9GT"
});

// Retrieve an instance of Firebase Messaging so that it can handle background
// messages.
const messaging = firebase.messaging();
messaging.setBackgroundMessageHandler(function (payload) {
    const notification = JSON.parse(payload);
    const notificationOption = {
        body: notification.body,
        icon: notification.icon
    }
    return self.registration.showNotification(payload.notification.title, notificationOption);
});
    """
    return HttpResponse(data, content_type='application/javascript')

# You do not need to add custom views for password reset since Django already provides them

# In your urls.py, you can link to the built-in password reset views
