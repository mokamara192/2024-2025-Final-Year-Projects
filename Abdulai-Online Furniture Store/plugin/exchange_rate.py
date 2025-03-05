from decimal import Decimal

# Exchange rate: 1 Leone = 0.00005 USD
def convert_sle_to_usd(sle_amount):
    SLE_TO_USD_RATE = Decimal('22.0')
    # Ensure sle_amount is a Decimal
    sle_amount = Decimal(sle_amount)
    usd_amount = sle_amount / SLE_TO_USD_RATE
    return usd_amount




# from decimal import Decimal
# #import requests

# # Example rate: 1 Leone = 0.00005 USD

# def convert_sle_to_usd(sle_amount):
#     SLE_TO_USD_RATE = Decimal('0.00005')
#     usd_amount = sle_amount * SLE_TO_USD_RATE
#     return usd_amount

























# def convert_sle_to_usd(sle_amount):
#     return sle_amount * SLE_TO_USD_RATE

# def fetch_exchange_rates():
#     response = requests.get('https://api.exchangerate-api.com/v4/latest/USD')  # Replace with a reliable API
#     data = response.json()
#     return {
#         'USD': Decimal(data['rates']['USD'])  # Fetch Leone-to-USD rate
#     }

# exchange_rates = fetch_exchange_rates()

# def get_sle_to_usd_rate():
#     return exchange_rates['USD']

# def convert_sle_to_usd(sle_amount):
#     usd_rate = get_sle_to_usd_rate()
#     print(f"Conversion Rate (SLE to USD): {usd_rate}")
#     return sle_amount * usd_rate




# def fetch_exchange_rates():
#     response = requests.get('https://api.exchangerate-api.com/v4/latest/USD')
#     data = response.json()
#     return {
#         'INR': Decimal(data['rates']['INR']),
#         'NGN': Decimal(data['rates']['NGN'])
#     }

# exchange_rates = fetch_exchange_rates()

# def get_usd_to_inr_rate():
#     return exchange_rates['INR']

# def get_usd_to_ngn_rate():
#     return exchange_rates['NGN']

# def convert_usd_to_inr(usd_amount):
#     inr_rate = get_usd_to_inr_rate()
#     return usd_amount * inr_rate

# def convert_usd_to_kobo(usd_amount):
#     ngn_rate = get_usd_to_ngn_rate()
#     ngn_amount = usd_amount * ngn_rate
#     return int(ngn_amount * 100)  # Convert NGN to Kobo

# def convert_usd_to_ngn(usd_amount):
#     ngn_rate = get_usd_to_ngn_rate()
#     return usd_amount * ngn_rate

