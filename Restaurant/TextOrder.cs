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
                const string accountSid = "AC13146fc0948c7b0a80620342784fb7b4";
                const string authToken = "38f00c1ba8e62fcd075a8efe2583eb0c";

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: receipt,
                    from: new Twilio.Types.PhoneNumber("+441622321259"),
                    to: new Twilio.Types.PhoneNumber("+44787628699")
                );

                Console.WriteLine(message.Sid);
            }
        }
    }
}
