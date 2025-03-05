from django.shortcuts import render, redirect
from django.contrib import messages
from django.contrib.auth import authenticate, login
from django.contrib.auth import logout

from userauths import models as userauths_models
from userauths import forms as userauths_forms
from vendor import models as vendor_models














# def register_view(request):
#     if request.user.is_authenticated:
#         messages.warning(request, f"You are already logged in")
#         return redirect('/')   

#     form = userauths_forms.UserRegisterForm(request.POST or None)

#     if form.is_valid():
#         user = form.save()

#         full_name = form.cleaned_data.get('full_name')
#         email = form.cleaned_data.get('email')
#         mobile = form.cleaned_data.get('mobile')
#         password = form.cleaned_data.get('password1')
#         user_type = form.cleaned_data.get("user_type")
#         store_name = request.POST.get('store_name')

#         user = authenticate(email=email, password=password)
#         login(request, user)

#         messages.success(request, f"Account was created successfully.")
#         profile = userauths_models.Profile.objects.create(full_name = full_name, mobile = mobile, user=user)
        
#         if user_type == "Vendor":
#             vendor_models.Vendor.objects.create(user=user, store_name=store_name)
#             profile.user_type = "Vendor"
#         else:
#             profile.user_type = "Customer"
        
#         profile.save()

#         next_url = request.GET.get("next", 'store:index')
#         return redirect(next_url)
    
#     context = {
#         'form':form
#     }
#     return render(request, 'userauths/sign-up.html', context)



# Registration with Validation
from django.shortcuts import render, redirect
from django.contrib import messages
from django.contrib.auth import login
from userauths import forms as userauths_forms
from userauths import models as userauths_models
from vendor import models as vendor_models

def register_view(request):
    if request.user.is_authenticated:
        messages.warning(request, "You are already logged in")
        return redirect('/')

    form = userauths_forms.UserRegisterForm(request.POST or None)

    if form.is_valid():
        print("Form is valid!")
        
        # Save user instance without committing to the database
        user = form.save(commit=False)
        user_type = form.cleaned_data.get("user_type")
        store_name = form.cleaned_data.get("store_name", "").strip()

        # Validate if the user type is Customer but store_name is provided
        if user_type == "Customer" and store_name:
            messages.error(request, "Store Name should not be provided for Customer accounts.")
            return render(request, 'userauths/sign-up.html', {'form': form})

        # Set user type and save the user instance
        user.user_type = user_type
        user.save()
        print(f"User created: {user}")

        # Get other form data
        full_name = form.cleaned_data.get('full_name')
        email = form.cleaned_data.get('email')
        mobile = form.cleaned_data.get('mobile')

        # Log the user in
        login(request, user, backend='django.contrib.auth.backends.ModelBackend')
        print(f"User logged in: {user}")

        # Create a Profile instance
        profile = userauths_models.Profile.objects.create(
            full_name=full_name, 
            mobile=mobile, 
            user=user, 
            user_type="Vendor" if user_type == "Vendor" else "Customer"
        )
        print(f"Profile created: {profile}")

        # If user type is Vendor, validate and create a Vendor instance
        if user_type == "Vendor":
            if not store_name:
                messages.error(request, "Store Name is required for Vendor accounts.")
                return render(request, 'userauths/sign-up.html', {'form': form})

            vendor = vendor_models.Vendor.objects.create(user=user, store_name=store_name)
            print(f"Vendor created: {vendor}")

        messages.success(request, "Account was created successfully.")

        # Redirect to the next page or home
        next_url = request.GET.get("next", 'store:index')
        return redirect(next_url)

    # If the form is not valid
    print("Form is NOT valid!")
    return render(request, 'userauths/sign-up.html', {'form': form})


# Registration without validation

# def register_view(request):
#     if request.user.is_authenticated:
#         messages.warning(request, "You are already logged in")
#         return redirect('/')

#     form = userauths_forms.UserRegisterForm(request.POST or None)

#     if form.is_valid():
#         print("Form is valid!")
        
#         user = form.save(commit=False)
#         user.save()
#         print(f"User created: {user}")

#         full_name = form.cleaned_data.get('full_name')
#         email = form.cleaned_data.get('email')
#         mobile = form.cleaned_data.get('mobile')
#         password = form.cleaned_data.get('password1')
#         user_type = form.cleaned_data.get("user_type")
#         store_name = request.POST.get('store_name', '')

#         login(request, user, backend='django.contrib.auth.backends.ModelBackend')
#         print(f"User logged in: {user}")

#         profile = userauths_models.Profile.objects.create(
#             full_name=full_name, mobile=mobile, user=user, 
#             user_type="Vendor" if user_type == "Vendor" else "Customer"
#         )
#         print(f"Profile created: {profile}")

#         if user_type == "Vendor":
#             vendor = vendor_models.Vendor.objects.create(user=user, store_name=store_name)
#             print(f"Vendor created: {vendor}")

#         messages.success(request, "Account was created successfully.")

#         next_url = request.GET.get("next", 'store:index')
#         return redirect(next_url)

#     print("Form is NOT valid!")
#     return render(request, 'userauths/sign-up.html', {'form': form})






















# Sign up with Session control
from django.views.decorators.cache import cache_control

@cache_control(no_cache=True, must_revalidate=True, no_store=True)
def login_view(request):
    if request.user.is_authenticated:
        messages.warning(request, "You are already logged in")
        return redirect('store:index')

    if request.method == 'POST':
        form = userauths_forms.LoginForm(request.POST)
        if form.is_valid():
            email = form.cleaned_data['email']
            password = form.cleaned_data['password']
            captcha_verified = form.cleaned_data.get('captcha', False)

            if captcha_verified:
                try:
                    user_instance = userauths_models.User.objects.get(email=email, is_active=True)
                    user_authenticate = authenticate(request, email=email, password=password)

                    if user_instance is not None and user_authenticate:
                        login(request, user_authenticate)
                        messages.success(request, "You are Logged In")
                        next_url = request.GET.get("next", 'store:index')

                        # Handle edge cases for next_url
                        if not next_url or next_url in ['undefined', '/undefined/'] or not next_url.startswith('/'):
                            return redirect('store:index')

                        return redirect(next_url)
                    else:
                        messages.error(request, 'Username or password does not exist')
                except userauths_models.User.DoesNotExist:
                    messages.error(request, 'User does not exist')
            else:
                messages.error(request, 'Captcha verification failed. Please try again.')
    else:
        form = userauths_forms.LoginForm()

    # Prevent caching of the login page
    response = render(request, "userauths/sign-in.html", {'form': form})
    response['Cache-Control'] = 'no-store, no-cache, must-revalidate, max-age=0'
    response['Pragma'] = 'no-cache'
    response['Expires'] = '0'
    return response



# Sign up with out Session control

# def login_view(request):
#     if request.user.is_authenticated:
#         messages.warning(request, "You are already logged in")
#         return redirect('store:index')
    
#     if request.method == 'POST':
#         form = userauths_forms.LoginForm(request.POST)  
#         if form.is_valid():
#             email = form.cleaned_data['email']
#             password = form.cleaned_data['password']
#             captcha_verified = form.cleaned_data.get('captcha', False)  

#             if captcha_verified:
#                 try:
#                     user_instance = userauths_models.User.objects.get(email=email, is_active=True)
#                     user_authenticate = authenticate(request, email=email, password=password)

#                     if user_instance is not None:
#                         login(request, user_authenticate)
#                         messages.success(request, "You are Logged In")
#                         next_url = request.GET.get("next", 'store:index')

#                         print("next_url ========", next_url)
#                         if next_url == '/undefined/':
#                             return redirect('store:index')
                        
#                         if next_url == 'undefined':
#                             return redirect('store:index')

#                         if next_url is None or not next_url.startswith('/'):
#                             return redirect('store:index')

#                         return redirect(next_url)

#                     else:
#                         messages.error(request, 'Username or password does not exist')
#                 except userauths_models.User.DoesNotExist:
#                     messages.error(request, 'User does not exist')
#             else:
#                 messages.error(request, 'Captcha verification failed. Please try again.')

#     else:
#         form = userauths_forms.LoginForm()  

#     return render(request, "userauths/sign-in.html", {'form': form})

def logout_view(request):
    if "cart_id" in request.session:
        cart_id = request.session['cart_id']
    else:
        cart_id = None
    logout(request)
    request.session['cart_id'] = cart_id
    messages.success(request, 'You have been logged out.')
    return redirect("userauths:sign-in")

def handler404(request, exception, *args, **kwargs):
    context = {}
    response = render(request, 'userauths/404.html', context)
    response.status_code = 404
    return response

def handler500(request, *args, **kwargs):
    context = {}
    response = render(request, 'userauths/500.html', context)
    response.status_code = 500
    return response



