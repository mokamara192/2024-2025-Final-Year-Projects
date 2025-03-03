from django import forms
from django.contrib.auth.forms import UserCreationForm
from django.core.validators import RegexValidator

from captcha.fields import ReCaptchaField # type: ignore
from captcha.widgets import ReCaptchaV2Checkbox # type: ignore

from userauths.models import User

USER_TYPE = (
    ("Vendor", "Vendor"),
    ("Customer", "Customer"),
)

class UserRegisterForm(UserCreationForm):
    full_name = forms.CharField(
        widget=forms.TextInput(attrs={'class': 'form-control rounded', 'placeholder': 'Full Name'}),
        required=True
    )
    
    mobile = forms.CharField(
        widget=forms.TextInput(attrs={'class': 'form-control rounded', 'placeholder': 'Mobile Number'}),
        required=True,
        validators=[
            RegexValidator(
                regex=r'^(077|088|099|033|078|079|076|075|074|034|031)\d{6}$',
                message="Enter a valid mobile number starting with an allowed prefix and exactly 9 digits."
            )
        ]
    )
    
    email = forms.EmailField(
        widget=forms.TextInput(attrs={'class': 'form-control rounded', 'placeholder': 'Email Address'}),
        required=True
    )
    
    password1 = forms.CharField(
        widget=forms.PasswordInput(attrs={'class': 'form-control rounded', 'placeholder': 'Password'}),
        required=True
    )
    
    password2 = forms.CharField(
        widget=forms.PasswordInput(attrs={'class': 'form-control rounded', 'placeholder': 'Confirm Password'}),
        required=True
    )
    
    #captcha = ReCaptchaField(widget=ReCaptchaV2Checkbox())
    
    user_type = forms.ChoiceField(
        choices=USER_TYPE,
        widget=forms.Select(attrs={"class": "form-select"})
    )
    
    store_name = forms.CharField(
        widget=forms.TextInput(attrs={'class': 'form-control rounded', 'placeholder': 'Store Name'}),
        required=False
    )
    
    # full_name = forms.CharField(widget=forms.TextInput(attrs={'class': 'form-control rounded', 'placeholder':'Full Name'}), required=True)
    # mobile = forms.CharField(widget=forms.TextInput(attrs={'class': 'form-control rounded', 'placeholder':'Mobile Number'}), required=True)
    # email = forms.EmailField(widget=forms.TextInput(attrs={'class': 'form-control rounded' , 'placeholder':'Email Address'}), required=True)
    # password1 = forms.CharField(widget=forms.PasswordInput(attrs={'class': 'form-control rounded' , 'placeholder':'Password'}), required=True)
    # password2 = forms.CharField(widget=forms.PasswordInput(attrs={ 'class': 'form-control rounded' , 'placeholder':'Confirm Password'}), required=True)
    # captcha = ReCaptchaField(widget=ReCaptchaV2Checkbox())
    # user_type = forms.ChoiceField(choices=USER_TYPE, widget=forms.Select(attrs={"class": "form-select"}))
    # store_name = forms.CharField(widget=forms.TextInput(attrs={'class': 'form-control rounded', 'placeholder':'Store Name'}), required=False)

    class Meta:
        model = User
        fields = ['full_name', 'mobile', 'email', 'password1', 'password2', 'user_type', 'store_name']
        # 'captcha', 
       
class LoginForm(forms.Form):
    email = forms.EmailField(widget=forms.TextInput(attrs={'class': 'form-control rounded' , 'name': "email", 'placeholder':'Email Address'}), required=False)
    password = forms.CharField(widget=forms.PasswordInput(attrs={'class':'form-control rounded' , 'name': "password", 'placeholder':'Password'}), required=False)
    captcha = ReCaptchaField(widget=ReCaptchaV2Checkbox())

    class Meta:
        model = User
        fields = ['email', 'password', 'captcha']
