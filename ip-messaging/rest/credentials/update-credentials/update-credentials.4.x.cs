// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio;

class Example {
    static void Main (string[] args) {
        // Find your Account Sid and Auth Token at twilio.com/user/account
        const string accountSid = "accountSid";
        const string authToken = "authToken";

        const string credentialSid = "credentialSid";
        const string friendlyName = "friendlyName";
        const string type = "type";
        const string privateKey = "privateKey";
        const string sandbox = "sandbox";
        const string certificate = "certificate";
        const string apiKey = "apiKey";
        
        // Update a Credential
        var client = new TwilioIpMessagingClient(accountSid, authToken);
        Credential credential = client.UpdateCredential(credentialSid, type, friendlyName, certificate, privateKey, sandbox, apikey);
        Console.WriteLine(credential);
    }
}