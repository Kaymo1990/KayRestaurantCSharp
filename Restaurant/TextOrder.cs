using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Restaurant
{
    class TextOrder
    {
        public static void SentTextOrder(string receipt)
        {
            {
                // Find your Account Sid and Token at twilio.com/console
                // DANGER! This is insecure. See http://twil.io/secure
                const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
                const string authToken = "your_auth_token";

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: receipt,
                    from: new Twilio.Types.PhoneNumber("+15017122661"),
                    to: new Twilio.Types.PhoneNumber("+15558675310")
                );

                Console.WriteLine(message.Sid);
            }
        }
    }
}
