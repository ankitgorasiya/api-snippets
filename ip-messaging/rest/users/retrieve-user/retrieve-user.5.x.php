<?php

// This line loads the library
require '/path/to/vendor/autoload.php';

use Twilio\Rest\Client;

// Find your Account Sid and Token at twilio.com/user/account
$sid = "ACCOUNT_SID";
$token = "AUTH_TOKEN";

// Initialize the client
$client = new Client($sid, $token);

// Retrieve the user
$user = $client->ipMessaging
    ->services("SERVICE_SID")
    ->users("USER_SID")
    ->fetch();

echo $user->identity;
