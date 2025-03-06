from django.urls import path
from store import views
from . import views 

app_name = "store"

urlpatterns = [
    path("", views.index, name="index"),
    path("shop/", views.shop, name="shop"),
    path("category/<id>/", views.category, name="category"),
    path("detail/<slug>/", views.product_detail, name="product_detail"),
    path("cart/", views.cart, name="cart"),
    path("create_order/", views.create_order, name="create_order"),
    path("checkout/<order_id>/", views.checkout, name="checkout"),
    path("coupon_apply/<order_id>/", views.coupon_apply, name="coupon_apply"),
    path("payment_status/<order_id>/", views.payment_status, name="payment_status"),

    path("filter_products/", views.filter_products, name="filter_products"),
    path("add_to_cart/", views.add_to_cart, name="add_to_cart"),
    path("delete_cart_item/", views.delete_cart_item, name="delete_cart_item"),

    path('stripe_payment/<order_id>/', views.stripe_payment, name='stripe_payment'),
    path('stripe_payment_verify/<order_id>/', views.stripe_payment_verify, name='stripe_payment_verify'),
    path('paypal_payment_verify/<order_id>/', views.paypal_payment_verify, name='paypal_payment_verify'),
    path('razorpay_payment_verify/<order_id>/', views.razorpay_payment_verify, name='razorpay_payment_verify'),
    path('paystack_payment_verify/<order_id>/', views.paystack_payment_verify, name='paystack_payment_verify'),
    path('flutterwave_payment_callback/<order_id>/', views.flutterwave_payment_callback, name='flutterwave_payment_callback'),

    path("order_tracker_page/", views.order_tracker_page, name="order_tracker_page"),
    path("order_tracker_detail/<item_id>/", views.order_tracker_detail, name="order_tracker_detail"),

    path("about/", views.about, name="about"),
    path("contact/", views.contact, name="contact"),
    path("faqs/", views.faqs, name="faqs"),
    path("privacy_policy/", views.privacy_policy, name="privacy_policy"),
    path("terms_conditions/", views.terms_conditions, name="terms_conditions"),
    path('cash_on_delivery/<order_id>/', views.cash_on_delivery, name='cash_on_delivery'),
    path('cod_confirmation/<order_id>/', views.cod_confirmation, name='cod_confirmation'),  # Add this


]