from django.http import JsonResponse
from django.shortcuts import redirect, render
from django.views.decorators.csrf import csrf_exempt
from django.contrib import messages
from django.db import models
from django.conf import settings
from django.urls import reverse
from django.template.loader import render_to_string
from django.core.mail import EmailMultiAlternatives

from decimal import Decimal
import requests
import stripe
from plugin.service_fee import calculate_service_fee
import razorpay

from plugin.paginate_queryset import paginate_queryset
from store import models as store_models
from customer import models as customer_models
from vendor import models as vendor_models
from userauths import models as userauths_models
from plugin.tax_calculation import tax_calculation
from plugin.exchange_rate import convert_sle_to_usd 

from django.shortcuts import render, get_object_or_404
from .models import Order
#convert_usd_to_kobo, convert_usd_to_ngn, get_usd_to_ngn_rate
#convert_usd_to_inr,

stripe.api_key = settings.STRIPE_SECRET_KEY
razorpay_client = razorpay.Client(auth=(settings.RAZORPAY_KEY_ID, settings.RAZORPAY_KEY_SECRET))

def clear_cart_items(request):
    try:
        cart_id = request.session['cart_id']
        store_models.Cart.objects.filter(cart_id=cart_id).delete()
    except:
        pass
    return

def index(request):
    products = store_models.Product.objects.filter(status="Published")
    categories = store_models.Category.objects.all()
    
    context = {
        "products": products,
        "categories": categories,
    }
    return render(request, "store/index.html", context)

def shop(request):
    products_list = store_models.Product.objects.filter(status="Published")
    categories = store_models.Category.objects.all()
    colors = store_models.VariantItem.objects.filter(variant__name='Color').values('title', 'content').distinct()
    sizes = store_models.VariantItem.objects.filter(variant__name='Size').values('title', 'content').distinct()
    item_display = [
        {"id": "1", "value": 1},
        {"id": "2", "value": 2},
        {"id": "3", "value": 3},
        {"id": "40", "value": 40},
        {"id": "50", "value": 50},
        {"id": "100", "value": 100},
    ]

    ratings = [
        {"id": "1", "value": "★☆☆☆☆"},
        {"id": "2", "value": "★★☆☆☆"},
        {"id": "3", "value": "★★★☆☆"},
        {"id": "4", "value": "★★★★☆"},
        {"id": "5", "value": "★★★★★"},
    ]

    prices = [
        {"id": "lowest", "value": "Highest to Lowest"},
        {"id": "highest", "value": "Lowest to Highest"},
    ]


    print(sizes)

    products = paginate_queryset(request, products_list, 10)

    context = {
        "products": products,
        "products_list": products_list,
        "categories": categories,
         'colors': colors,
        'sizes': sizes,
        'item_display': item_display,
        'ratings': ratings,
        'prices': prices,
    }
    return render(request, "store/shop.html", context)

def category(request, id):
    category = store_models.Category.objects.get(id=id)
    products_list = store_models.Product.objects.filter(status="Published", category=category)

    query = request.GET.get("q")
    if query:
        products_list = products_list.filter(name__icontains=query)

    products = paginate_queryset(request, products_list, 10)

    context = {
        "products": products,
        "products_list": products_list,
        "category": category,
    }
    return render(request, "store/category.html", context)

def vendors(request):
    vendors = userauths_models.Profile.objects.filter(user_type="Vendor")
    
    context = {
        "vendors": vendors
    }
    return render(request, "store/vendors.html", context)

def product_detail(request, slug):
    product = store_models.Product.objects.get(status="Published", slug=slug)
    product_stock_range = range(1, product.stock + 1)

    related_products = store_models.Product.objects.filter(category=product.category).exclude(id=product.id)

    context = {
        "product": product,
        "product_stock_range": product_stock_range,
        "related_products": related_products,
    }
    return render(request, "store/product_detail.html", context)


# from django.shortcuts import redirect, reverse
# from django.http import JsonResponse
# from django.db import models
# from decimal import Decimal
# from django.contrib.auth.decorators import login_required
# from store import models as store_models  # Adjust based on your app's structure

# @login_required(login_url="/userauths/sign-in/")
# def add_to_cart(request):
#     # Get parameters from the request (ID, color, size, quantity, cart_id)
#     id = request.GET.get("id")
#     qty = request.GET.get("qty")
#     color = request.GET.get("color")
#     size = request.GET.get("size")
#     cart_id = request.GET.get("cart_id")

#     request.session['cart_id'] = cart_id

#     # Validate required fields
#     if not id or not qty or not cart_id:
#         return JsonResponse({"error": "No color or size selected"}, status=400)

#     # Try to fetch the product, return an error if it doesn't exist
#     try:
#         product = store_models.Product.objects.get(status="Published", id=id)
#     except store_models.Product.DoesNotExist:
#         return JsonResponse({"error": "Product not found"}, status=404)

#     # Check if the quantity exceeds the product's stock
#     if int(qty) > product.stock:
#         return JsonResponse({"error": "Qty exceeds current stock amount"}, status=400)

#     # Check if the item is already in the cart
#     existing_cart_item = store_models.Cart.objects.filter(cart_id=cart_id, product=product).first()

#     if not existing_cart_item:
#         # If the item is not in the cart, create a new cart entry
#         cart = store_models.Cart()
#         cart.product = product
#         cart.qty = qty
#         cart.price = product.price
#         cart.color = color
#         cart.size = size
#         cart.sub_total = Decimal(product.price) * Decimal(qty)
#         cart.shipping = Decimal(product.shipping) * Decimal(qty)
#         cart.total = cart.sub_total + cart.shipping
#         cart.user = request.user  # Authenticated user
#         cart.cart_id = cart_id
#         cart.save()

#         message = "Item added to cart"
#     else:
#         # If the item exists in the cart, update the existing entry
#         existing_cart_item.color = color
#         existing_cart_item.size = size
#         existing_cart_item.qty = qty
#         existing_cart_item.price = product.price
#         existing_cart_item.sub_total = Decimal(product.price) * Decimal(qty)
#         existing_cart_item.shipping = Decimal(product.shipping) * Decimal(qty)
#         existing_cart_item.total = existing_cart_item.sub_total + existing_cart_item.shipping
#         existing_cart_item.user = request.user  # Authenticated user
#         existing_cart_item.cart_id = cart_id
#         existing_cart_item.save()

#         message = "Cart updated"

#     # Count the total number of items in the cart
#     total_cart_items = store_models.Cart.objects.filter(cart_id=cart_id)
#     cart_sub_total = store_models.Cart.objects.filter(cart_id=cart_id).aggregate(sub_total=models.Sum("sub_total"))['sub_total']

#     # Return the response with the cart update message and total cart items
#     return JsonResponse({
#         "message": message,
#         "total_cart_items": total_cart_items.count(),
#         "cart_sub_total": "{:,.2f}".format(cart_sub_total) if cart_sub_total else "0.00",
#         "item_sub_total": "{:,.2f}".format(existing_cart_item.sub_total) if existing_cart_item else "{:,.2f}".format(cart.sub_total)
#     })



# from django.contrib.auth.decorators import login_required
# @login_required
def add_to_cart(request):
            
    # Get parameters from the request (ID, color, size, quantity, cart_id)
    id = request.GET.get("id")
    qty = request.GET.get("qty")
    color = request.GET.get("color")
    size = request.GET.get("size")
    cart_id = request.GET.get("cart_id")
    
    request.session['cart_id'] = cart_id

    # Validate required fields
    if not id or not qty or not cart_id:
        return JsonResponse({"error": "No color or size selected"}, status=400)

    # Try to fetch the product, return an error if it doesn't exist
    try:
        product = store_models.Product.objects.get(status="Published", id=id)
    except store_models.Product.DoesNotExist:
        return JsonResponse({"error": "Product not found"}, status=404)

    # Check if the item is already in the cart
    existing_cart_item = store_models.Cart.objects.filter(cart_id=cart_id, product=product).first()

    # Check if quantity that user is adding exceed item stock qty
    if int(qty) > product.stock:
        return JsonResponse({"error": "Qty exceed current stock amount"}, status=404)

    # If the item is not in the cart, create a new cart entry
    if not existing_cart_item:
        cart = store_models.Cart()
        cart.product = product
        cart.qty = qty
        cart.price = product.price
        cart.color = color
        cart.size = size
        cart.sub_total = Decimal(product.price) * Decimal(qty)
        cart.shipping = Decimal(product.shipping) * Decimal(qty)
        cart.total = cart.sub_total + cart.shipping
        cart.user = request.user if request.user.is_authenticated else None
        cart.cart_id = cart_id
        cart.save()

        message = "Item added to cart"
    else:
        # If the item exists in the cart, update the existing entry
        existing_cart_item.color = color
        existing_cart_item.size = size
        existing_cart_item.qty = qty
        existing_cart_item.price = product.price
        existing_cart_item.sub_total = Decimal(product.price) * Decimal(qty)
        existing_cart_item.shipping = Decimal(product.shipping) * Decimal(qty)
        existing_cart_item.total = existing_cart_item.sub_total +  existing_cart_item.shipping
        existing_cart_item.user = request.user if request.user.is_authenticated else None
        existing_cart_item.cart_id = cart_id
        existing_cart_item.save()

        message = "Cart updated"

    # Count the total number of items in the cart
    total_cart_items = store_models.Cart.objects.filter(cart_id=cart_id)
    cart_sub_total = store_models.Cart.objects.filter(cart_id=cart_id).aggregate(sub_total = models.Sum("sub_total"))['sub_total']

    # Return the response with the cart update message and total cart items
    return JsonResponse({
        "message": message ,
        "total_cart_items": total_cart_items.count(),
        "cart_sub_total": "{:,.2f}".format(cart_sub_total),
        "item_sub_total": "{:,.2f}".format(existing_cart_item.sub_total) if existing_cart_item else "{:,.2f}".format(cart.sub_total) 
    })

def cart(request):
    if "cart_id" in request.session:
        cart_id = request.session['cart_id']
    else:
        cart_id = None

    #Get item in the cart
    items = store_models.Cart.objects.filter(cart_id=cart_id)
    
    #Get the subtotal in leone
    cart_sub_total = store_models.Cart.objects.filter(cart_id=cart_id).aggregate(sub_total = models.Sum("sub_total"))['sub_total']
    
    cart_sub_total_usd = convert_sle_to_usd(cart_sub_total) if cart_sub_total else Decimal('0')

    
    try:
        addresses = customer_models.Address.objects.filter(user=request.user)
    except:
        addresses = None

    if not items:
        messages.warning(request, "No item in cart")
        return redirect("store:index")

    context = {
        "items": items,
        "cart_sub_total": cart_sub_total, # In Leone
        "cart_sub_total_usd": cart_sub_total_usd,  # In USD
        "addresses": addresses,
    }
    return render(request, "store/cart.html", context)

def delete_cart_item(request):
    id = request.GET.get("id")
    item_id = request.GET.get("item_id")
    cart_id = request.GET.get("cart_id")
    
    # Validate required fields
    if not id and not item_id and not cart_id:
        return JsonResponse({"error": "Item or Product id not found"}, status=400)

    try:
        product = store_models.Product.objects.get(status="Published", id=id)
    except store_models.Product.DoesNotExist:
        return JsonResponse({"error": "Product not found"}, status=404)

    # Check if the item is already in the cart
    item = store_models.Cart.objects.get(product=product, id=item_id)
    item.delete()

    # Count the total number of items in the cart
    total_cart_items = store_models.Cart.objects.filter(cart_id=cart_id)
    cart_sub_total = store_models.Cart.objects.filter(cart_id=cart_id).aggregate(sub_total = models.Sum("sub_total"))['sub_total']

    return JsonResponse({
        "message": "Item deleted",
        "total_cart_items": total_cart_items.count(),
        "cart_sub_total": "{:,.2f}".format(cart_sub_total) if cart_sub_total else 0.00
    })

def create_order(request):
    if request.method == "POST":
        address_id = request.POST.get("address")
        if not address_id:
            messages.warning(request, "Please select an address to continue")
            return redirect("store:cart")
        
        address = customer_models.Address.objects.filter(user=request.user, id=address_id).first()

        if "cart_id" in request.session:
            cart_id = request.session['cart_id']
        else:
            cart_id = None

        items = store_models.Cart.objects.filter(cart_id=cart_id)
        cart_sub_total = store_models.Cart.objects.filter(cart_id=cart_id).aggregate(sub_total = models.Sum("sub_total"))['sub_total']
        cart_shipping_total = store_models.Cart.objects.filter(cart_id=cart_id).aggregate(shipping = models.Sum("shipping"))['shipping']
        
        order = store_models.Order()
        order.sub_total = cart_sub_total
        order.customer = request.user
        order.address = address
        order.shipping = cart_shipping_total
        order.tax = tax_calculation(address.address, cart_sub_total)
        order.total = order.sub_total + order.shipping + Decimal(order.tax)
        order.service_fee = calculate_service_fee(order.total)
        order.total += order.service_fee
        order.save()

        for i in items:
            store_models.OrderItem.objects.create(
                order=order,
                product=i.product,
                qty=i.qty,
                color=i.color,
                size=i.size,
                price=i.price,
                sub_total=i.sub_total,
                shipping=i.shipping,
                tax=tax_calculation(address.address, i.sub_total),
                total=i.total,
                initial_total=i.total,
                vendor=i.product.vendor
            )

            order.vendors.add(i.product.vendor)
        
    
    return redirect("store:checkout", order.order_id)

def coupon_apply(request, order_id):
    print("Order Id ========", order_id)
    
    try:
        order = store_models.Order.objects.get(order_id=order_id)
        order_items = store_models.OrderItem.objects.filter(order=order)
    except store_models.Order.DoesNotExist:
        messages.error(request, "Order not found")
        return redirect("store:cart")

    if request.method == 'POST':
        coupon_code = request.POST.get("coupon_code")
        
        if not coupon_code:
            messages.error(request, "No coupon entered")
            return redirect("store:checkout", order.order_id)
            
        try:
            coupon = store_models.Coupon.objects.get(code=coupon_code)
        except store_models.Coupon.DoesNotExist:
            messages.error(request, "Coupon does not exist")
            return redirect("store:checkout", order.order_id)
        
        if coupon in order.coupons.all():
            messages.warning(request, "Coupon already activated")
            return redirect("store:checkout", order.order_id)
        else:
            # Assuming coupon applies to specific vendor items, not globally
            total_discount = 0
            for item in order_items:
                if coupon.vendor == item.product.vendor and coupon not in item.coupon.all():
                    item_discount = item.total * coupon.discount / 100  # Discount for this item
                    total_discount += item_discount

                    item.coupon.add(coupon) 
                    item.total -= item_discount
                    item.saved += item_discount
                    item.save()

            # Apply total discount to the order after processing all items
            if total_discount > 0:
                order.coupons.add(coupon)
                order.total -= total_discount
                order.sub_total -= total_discount
                order.saved += total_discount
                order.save()
        
        messages.success(request, "Coupon Activated")
        return redirect("store:checkout", order.order_id)


def checkout(request, order_id):
    try:
        # Get the order details based on order_id
        order = store_models.Order.objects.get(order_id=order_id)

        # Ensure order.total is a Decimal before conversion
        if not isinstance(order.total, Decimal):
            order.total = Decimal(order.total)

        # Convert the total price from SLE (Leone) to USD
        amount_in_usd = convert_sle_to_usd(order.total)

        # Debug: Log values to verify correctness
        print(f"Order Total (SLE): {order.total}")
        print(f"Converted Amount (USD): {amount_in_usd}")

        # Context data for the template
        context = {
            "order": order,
            "amount_in_usd": round(amount_in_usd, 2),  # Display the converted USD amount
            "stripe_public_key": settings.STRIPE_PUBLIC_KEY,
            "paypal_client_id": settings.PAYPAL_CLIENT_ID,
            "paystack_public_key": settings.PAYSTACK_PUBLIC_KEY,
            "flutterwave_public_key": settings.FLUTTERWAVE_PUBLIC_KEY,
        }

        # Render the checkout page with the context
        return render(request, "store/checkout.html", context)
    
    except store_models.Order.DoesNotExist:
        # Handle case where order is not found
        return render(request, "store/error.html", {"message": "Order not found."})


#Previous
# def checkout(request, order_id):
#     # Get the order details based on order_id
#     order = store_models.Order.objects.get(order_id=order_id)

#     # Convert the total price from SLE (Leone) to USD
#     amount_in_usd = convert_sle_to_usd(order.total)

#     # Context data for the template
#     context = {
#         "order": order,
#         "amount_in_usd": round(amount_in_usd, 2),  # Display the converted USD amount
#         "stripe_public_key": settings.STRIPE_PUBLIC_KEY,
#         "paypal_client_id": settings.PAYPAL_CLIENT_ID,
#         "paystack_public_key": settings.PAYSTACK_PUBLIC_KEY,
#         "flutterwave_public_key": settings.FLUTTERWAVE_PUBLIC_KEY,
#     }

#     # Render the checkout page with the context
#     return render(request, "store/checkout.html", context)

# def checkout(request, order_id):
#     order = store_models.Order.objects.get(order_id=order_id)

#     # Convert SLE to USD
#     amount_in_usd = convert_sle_to_usd(order.total)

#     context = {
#         "order": order,
#         "amount_in_usd": round(amount_in_usd, 2),
#         "stripe_public_key": settings.STRIPE_PUBLIC_KEY,
#         "paypal_client_id": settings.PAYPAL_CLIENT_ID,
#         "paystack_public_key": settings.PAYSTACK_PUBLIC_KEY,
#         "flutterwave_public_key": settings.FLUTTERWAVE_PUBLIC_KEY,
#     }

#     return render(request, "store/checkout.html", context)


# def checkout(request, order_id):
#     order = store_models.Order.objects.get(order_id=order_id)
    
#     #amount_in_inr = convert_usd_to_inr(order.total)
#     amount_in_kobo = convert_usd_to_kobo(order.total)
#     amount_in_ngn = convert_usd_to_ngn(order.total)
    

#     try:
#         razorpay_order = razorpay.Client(auth=(settings.RAZORPAY_KEY_ID, settings.RAZORPAY_KEY_SECRET)).order.create({
#             "amount": int(amount_in_inr),
#             "currency": "INR",
#             "payment_capture": "1"
#         })
#     except:
#         razorpay_order = None
#     context = {
#         "order": order,
#         "amount_in_inr":amount_in_inr,
#         "amount_in_kobo":amount_in_kobo,
#         "amount_in_ngn":round(amount_in_ngn, 2),
#         "razorpay_order_id": razorpay_order['id'] if razorpay_order else None,
#         "stripe_public_key": settings.STRIPE_PUBLIC_KEY,
#         "paypal_client_id": settings.PAYPAL_CLIENT_ID,
#         "razorpay_key_id":settings.RAZORPAY_KEY_ID,
#         "paystack_public_key":settings.PAYSTACK_PUBLIC_KEY,
#         "flutterwave_public_key":settings.FLUTTERWAVE_PUBLIC_KEY,
#     }

#     return render(request, "store/checkout.html", context)

@csrf_exempt
def stripe_payment(request, order_id):
    order = store_models.Order.objects.get(order_id=order_id)
    stripe.api_key = settings.STRIPE_SECRET_KEY

    #convert leone to usd
    amount_in_usd = convert_sle_to_usd(order.total) #leone to usd conversion
    
    checkout_session = stripe.checkout.Session.create(
        customer_email = order.address.email,
        payment_method_types=['card'],
        line_items = [
            {
                'price_data': {
                    'currency': settings.STRIPE_CURRENCY,#'USD',
                    'product_data': {
                        'name': order.address.full_name
                    },
                    'unit_amount': int(amount_in_usd * 100)
                },
                'quantity': 1
            }
        ],
        mode = 'payment',
        success_url = request.build_absolute_uri(reverse("store:stripe_payment_verify", args=[order.order_id])) + "?session_id={CHECKOUT_SESSION_ID}" + "&payment_method=Stripe",
        cancel_url = request.build_absolute_uri(reverse("store:stripe_payment_verify", args=[order.order_id]))
    )

    print("checkkout session", checkout_session)
    return JsonResponse({"sessionId": checkout_session.id})

def stripe_payment_verify(request, order_id):
    try:
        order = store_models.Order.objects.get(order_id=order_id)
        session_id = request.GET.get("session_id")
        session = stripe.checkout.Session.retrieve(session_id)

        if session.payment_status == "paid":
            if order.payment_status == "Processing":
                # Update order status
                order.payment_status = "Paid"
                order.save()

                # Clear cart items
                clear_cart_items(request)

                # Notify customer of a new order
                customer_models.Notifications.objects.create(
                    type="New Order", user=request.user
                )

                # Prepare and send email to customer
                customer_merge_data = {
                    'order': order,
                    'order_items': order.order_items(),
                }
                subject = "Your Order Confirmation"
                text_body = render_to_string(
                    "email/order/customer/customer_new_order.txt", customer_merge_data
                )
                html_body = render_to_string(
                    "email/order/customer/customer_new_order.html", customer_merge_data
                )

                msg = EmailMultiAlternatives(
                    subject=subject,
                    from_email=settings.DEFAULT_FROM_EMAIL,
                    to=[order.address.email],
                    body=text_body,
                )
                msg.attach_alternative(html_body, "text/html")
                msg.send()

                # Notify each vendor of their order items
                for item in order.order_items():
                    vendor_merge_data = {'item': item}
                    subject = "New Order Notification"
                    text_body = render_to_string(
                        "email/order/vendor/vendor_new_order.txt", vendor_merge_data
                    )
                    html_body = render_to_string(
                        "email/order/vendor/vendor_new_order.html", vendor_merge_data
                    )

                    msg = EmailMultiAlternatives(
                        subject=subject,
                        from_email=settings.DEFAULT_FROM_EMAIL,
                        to=[item.vendor.email],
                        body=text_body,
                    )
                    msg.attach_alternative(html_body, "text/html")
                    msg.send()

            return redirect(f"/payment_status/{order.order_id}/?payment_status=paid")
    except Exception as e:
        print(f"Error in payment verification: {e}")

    return redirect(f"/payment_status/{order.order_id}/?payment_status=failed")



def cod_confirmation(request, order_id):
    # Fetch the order details
    order = get_object_or_404(Order, order_id=order_id)
    
    # Render the confirmation page
    return render(request, 'store/cod_confirmation.html', {'order': order})


# from django.core.mail import EmailMultiAlternatives
# from django.shortcuts import get_object_or_404, redirect
# from django.template.loader import render_to_string
# from django.conf import settings

def cash_on_delivery(request, order_id):
    order = get_object_or_404(Order, order_id=order_id)

    # Set the payment method to "Cash on Delivery"
    order.payment_method = "Cash on Delivery"
    order.save()
    
    # Prepare customer email content
    customer_merge_data = {'order': order}
    subject = "Order Confirmation - Cash on Delivery"
    text_body = render_to_string(
        "store/customer_cod_order.txt", customer_merge_data
    )
    html_body = render_to_string(
        "store/customer_cod_order.html", customer_merge_data
    )

    # Send confirmation email to the customer
    msg = EmailMultiAlternatives(
        subject=subject,
        from_email=settings.DEFAULT_FROM_EMAIL,
        to=[order.address.email],  # Customer's email from order address
        body=text_body,
    )
    msg.attach_alternative(html_body, "text/html")
    msg.send()

    # Notify each vendor of their order items
    for item in order.order_items():
        vendor_merge_data = {'item': item}
        subject = "New Order Notification - Cash on Delivery"
        text_body = render_to_string(
            "email/order/vendor/vendor_new_order.txt", vendor_merge_data
        )
        html_body = render_to_string(
            "email/order/vendor/vendor_new_order.html", vendor_merge_data
        )

        msg = EmailMultiAlternatives(
            subject=subject,
            from_email=settings.DEFAULT_FROM_EMAIL,
            to=[item.vendor.email],  # Vendor's email
            body=text_body,
        )
        msg.attach_alternative(html_body, "text/html")
        msg.send()

    # Redirect to the confirmation page
    return redirect('store:cod_confirmation', order_id=order_id)

# def stripe_payment_verify(request, order_id):
#     order = store_models.Order.objects.get(order_id=order_id)

#     session_id = request.GET.get("session_id")
#     session = stripe.checkout.Session.retrieve(session_id)

#     if session.payment_status == "paid":
#         if order.payment_status == "Processing":
#             order.payment_status = "Paid"
#             order.save()
#             clear_cart_items(request)
#             customer_models.Notifications.objects.create(type="New Order", user=request.user)
#             customer_merge_data = {
#                 'order': order,
#                 'order_items': order.order_items(),
#             }
#             subject = f"New Order!"
#             text_body = render_to_string("email/order/customer/customer_new_order.txt", customer_merge_data)
#             html_body = render_to_string("email/order/customer/customer_new_order.html", customer_merge_data)

#             msg = EmailMultiAlternatives(
#                 subject=subject, from_email=settings.FROM_EMAIL,
#                 to=[order.address.email], body=text_body
#             )
#             msg.attach_alternative(html_body, "text/html")
#             msg.send()

#             # Send Order Emails to Vendors
#             for item in order.order_items():
                
#                 vendor_merge_data = {
#                     'item': item,
#                 }
#                 subject = f"New Order!"
#                 text_body = render_to_string("email/order/vendor/vendor_new_order.txt", vendor_merge_data)
#                 html_body = render_to_string("email/order/vendor/vendor_new_order.html", vendor_merge_data)

#                 msg = EmailMultiAlternatives(
#                     subject=subject, from_email=settings.FROM_EMAIL,
#                     to=[item.vendor.email], body=text_body
#                 )
#                 msg.attach_alternative(html_body, "text/html")
#                 msg.send()

#             return redirect(f"/payment_status/{order.order_id}/?payment_status=paid")
    
#     return redirect(f"/payment_status/{order.order_id}/?payment_status=failed")
    
def get_paypal_access_token():
    token_url = 'https://api.sandbox.paypal.com/v1/oauth2/token'
    data = {'grant_type': 'client_credentials'}
    auth = (settings.PAYPAL_CLIENT_ID, settings.PAYPAL_SECRET_ID)
    response = requests.post(token_url, data=data, auth=auth)

    if response.status_code == 200:
        return response.json()['access_token']
    else:
        raise Exception(f'Failed to get access token from PayPal. Status code: {response.status_code}') 

def paypal_payment_verify(request, order_id):
    order = store_models.Order.objects.get(order_id=order_id)

    transaction_id = request.GET.get("transaction_id")
    paypal_api_url = f'https://api-m.sandbox.paypal.com/v2/checkout/orders/{transaction_id}'
    headers = {
        'Content-Type': 'application/json',
        'Authorization': f'Bearer {get_paypal_access_token()}',
    }
    response = requests.get(paypal_api_url, headers=headers)

    if response.status_code == 200:
        paypal_order_data = response.json()
        paypal_payment_status = paypal_order_data['status']
        if paypal_payment_status == 'COMPLETED':
            if order.payment_status == "Processing":
                order.payment_status = "Paid"
                payment_method = request.GET.get("payment_method")
                order.payment_method = payment_method
                order.save()
                clear_cart_items(request)
                return redirect(f"/payment_status/{order.order_id}/?payment_status=paid")
    else:
        return redirect(f"/payment_status/{order.order_id}/?payment_status=failed")

@csrf_exempt
def razorpay_payment_verify(request, order_id):
    order = store_models.Order.objects.get(order_id=order_id)
    payment_method = request.GET.get("payment_method")

    if request.method == "POST":
        data = request.POST

        # Extract payment data
        razorpay_order_id = data.get('razorpay_order_id')
        razorpay_payment_id = data.get('razorpay_payment_id')
        razorpay_signature = data.get('razorpay_signature')

        print("razorpay_order_id: ====", razorpay_order_id)
        print("razorpay_payment_id: ====", razorpay_payment_id)
        print("razorpay_signature: ====", razorpay_signature)

        params_dict = {
            'razorpay_order_id': razorpay_order_id,
            'razorpay_payment_id': razorpay_payment_id,
            'razorpay_signature': razorpay_signature
        }

        # Verify the payment signature
        razorpay_client.utility.verify_payment_signature({
            'razorpay_order_id': razorpay_order_id,
            'razorpay_payment_id': razorpay_payment_id,
            'razorpay_signature': razorpay_signature
        })

        razorpay_client.utility.verify_payment_signature(params_dict)

        # Success response
        if order.payment_status == "Processing":
            order.payment_status = "Paid"
            order.payment_method = payment_method
            order.save()
            clear_cart_items(request)
            customer_models.Notifications.objects.create(type="New Order", user=request.user)
            for item in order.order_items():
                vendor_models.Notifications.objects.create(type="New Order", user=item.vendor)

            return redirect(f"/payment_status/{order.order_id}/?payment_status=paid")

        

    return redirect(f"/payment_status/{order.order_id}/?payment_status=failed")

def paystack_payment_verify(request, order_id):
    order = store_models.Order.objects.get(order_id=order_id)
    reference = request.GET.get('reference', '')

    if reference:
        headers = {
            "Authorization": f"Bearer {settings.PAYSTACK_PRIVATE_KEY}",
            "Content-Type": "application/json"
        }

        # Verify the transaction
        response = requests.get(f'https://api.paystack.co/transaction/verify/{reference}', headers=headers)
        response_data = response.json()

        if response_data['status']:
            if response_data['data']['status'] == 'success':
                if order.payment_status == "Processing":
                    order.payment_status = "Paid"
                    payment_method = request.GET.get("payment_method")
                    order.payment_method = payment_method
                    order.save()
                    clear_cart_items(request)
                    return redirect(f"/payment_status/{order.order_id}/?payment_status=paid")
                else:
                    return redirect(f"/payment_status/{order.order_id}/?payment_status=failed")
            else:
                # Payment failed
                return redirect(f"/payment_status/{order.order_id}/?payment_status=failed")
        else:
            return redirect(f"/payment_status/{order.order_id}/?payment_status=failed")
    else:
        return redirect(f"/payment_status/{order.order_id}/?payment_status=failed")

def flutterwave_payment_callback(request, order_id):
    order = store_models.Order.objects.get(order_id=order_id)

    payment_id = request.GET.get('tx_ref')
    status = request.GET.get('status')

    headers = {
        'Authorization': f'Bearer {settings.FLUTTERWAVE_PRIVATE_KEY}'
    }
    response = requests.get(f'https://api.flutterwave.com/v3/charges/verify_by_id/{payment_id}', headers=headers)

    if response.status_code == 200:
        if order.payment_status == "Processing":
            order.payment_status = "Paid"
            payment_method = request.GET.get("payment_method")
            order.payment_method = payment_method
            order.save()
            clear_cart_items(request)
            return redirect(f"/payment_status/{order.order_id}/?payment_status=paid")
        else:
            return redirect(f"/payment_status/{order.order_id}/?payment_status=failed")
    else:
        return redirect(f"/payment_status/{order.order_id}/?payment_status=failed")

def payment_status(request, order_id):
    order = store_models.Order.objects.get(order_id=order_id)
    payment_status = request.GET.get("payment_status")

    context = {
        "order": order,
        "payment_status": payment_status
    }
    return render(request, "store/payment_status.html", context)

def filter_products(request):
    products = store_models.Product.objects.all()

    # Get filters from the AJAX request
    categories = request.GET.getlist('categories[]')
    rating = request.GET.getlist('rating[]')
    sizes = request.GET.getlist('sizes[]')
    colors = request.GET.getlist('colors[]')
    price_order = request.GET.get('prices')
    search_filter = request.GET.get('searchFilter')
    display = request.GET.get('display')

    print("categories =======", categories)
    print("rating =======", rating)
    print("sizes =======", sizes)
    print("colors =======", colors)
    print("price_order =======", price_order)
    print("search_filter =======", search_filter)
    print("display =======", display)

   
    # Apply category filtering
    if categories:
        products = products.filter(category__id__in=categories)

    # Apply rating filtering
    if rating:
        products = products.filter(reviews__rating__in=rating).distinct()

    

    # Apply size filtering
    if sizes:
        products = products.filter(variant__variant_items__content__in=sizes).distinct()

    # Apply color filtering
    if colors:
        products = products.filter(variant__variant_items__content__in=colors).distinct()

    # Apply price ordering
    if price_order == 'lowest':
        products = products.order_by('-price')
    elif price_order == 'highest':
        products = products.order_by('price')

    # Apply search filter
    if search_filter:
        products = products.filter(name__icontains=search_filter)

    if display:
        products = products.filter()[:int(display)]


    # Render the filtered products as HTML using render_to_string
    html = render_to_string('partials/_store.html', {'products': products})

    return JsonResponse({'html': html, 'product_count': products.count()})

def order_tracker_page(request):
    if request.method == "POST":
        item_id = request.POST.get("item_id")
        return redirect("store:order_tracker_detail", item_id)
    
    return render(request, "store/order_tracker_page.html")

def order_tracker_detail(request, item_id):
    try:
        item = store_models.OrderItem.objects.filter(models.Q(item_id=item_id) | models.Q(tracking_id=item_id)).first()
    except:
        item = None
        messages.error(request, "Order not found!")
        return redirect("store:order_tracker_page")
    
    context = {
        "item": item,
    }
    return render(request, "store/order_tracker.html", context)

def about(request):
    return render(request, "pages/about.html")

def contact(request):
    if request.method == "POST":
        full_name = request.POST.get("full_name")
        email = request.POST.get("email")
        subject = request.POST.get("subject")
        message = request.POST.get("message")

        userauths_models.ContactMessage.objects.create(
            full_name=full_name,
            email=email,
            subject=subject,
            message=message,
        )
        messages.success(request, "Message sent successfully")
        return redirect("store:contact")
    return render(request, "pages/contact.html")

def faqs(request):
    return render(request, "pages/faqs.html")

def privacy_policy(request):
    return render(request, "pages/privacy_policy.html")

def terms_conditions(request):
    return render(request, "pages/terms_conditions.html")