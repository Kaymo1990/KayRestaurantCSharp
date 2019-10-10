using Nexmo.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Restaurant
{
    public class TextOrder
    {
        private static string mobNumber = "44787628699";

        public static string MobNumber { get => mobNumber; set => mobNumber = value; }
        public static void TextReceipt(Receipt receipt)
        {
            TextOrder.SentTextOrder(receipt.StoredReceipt, MobNumber);
        }

        public static void SentTextOrder(string receipt, string mobNumber)
        {
            var client = new Client(creds: new Nexmo.Api.Request.Credentials
            {
                ApiKey = "10023f21",
                ApiSecret = "wu4AX4zzKwKl7cXf"
            });
            var results = client.SMS.Send(request: new SMS.SMSRequest()
            {
                from = "Nexmo",
                to = mobNumber,
                text = receipt
            });
        }

    }
}
