using System;
using System.Collections.Generic;
using System.Text;
using Twilio.Exceptions;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SharedProject.Services
{
    public class TwilioService
    {
        private readonly string _accountSid = "AC25cdd1c2c5dcac7362c6a2218b35d07e";
        private readonly string _authToken = "8ab2636e03f7c73db4974540b2bbb98d";
        private readonly string _sourcePhoneNumber = "+12525184506";

        //public TwilioService(string? accountSid, string? authToken, string sourcePhoneNumber)
        //{
        //    _accountSid = accountSid;
        //    _authToken = authToken;
        //    _sourcePhoneNumber = sourcePhoneNumber;
        //}

        public string SendSms(string destinationPhoneNumber, string message)
        {
            try
            {
                TwilioClient.Init(_accountSid, _authToken);
                var smsMessage = MessageResource.Create(
                    body: message,
                    from: new Twilio.Types.PhoneNumber(_sourcePhoneNumber),
                    to: new Twilio.Types.PhoneNumber(destinationPhoneNumber)
                );

                Console.WriteLine($"SMS Sent: Message SID - {smsMessage.Sid}");
                return smsMessage.Sid;
            }
            catch (ApiException ex)
            {
                Console.WriteLine($"Error sending SMS: {ex.Message}");
                return ex.Message;
            }
        }
    }
}
