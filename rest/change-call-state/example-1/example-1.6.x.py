# Download the Python helper library from twilio.com/docs/python/install
from twilio.rest import Client

# Your Account Sid and Auth Token from twilio.com/user/account
account_sid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
auth_token = "your_auth_token"
client = Client(account_sid, auth_token)

call = client.calls("CAe1644a7eed5088b159577c5802d8be38") \
             .update(url="http://demo.twilio.com/docs/voice.xml",
                     method="POST")

print(call.to)