using Nexmo.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant
{
    public class TextOrder
    {
        private string mobNumber = "44787628699";

        public string MobNumber { get => mobNumber; set => mobNumber = value; }


        public void SentTextOrder(string receipt)
        {
            var client = new Client(creds: new Nexmo.Api.Request.Credentials
            {
                ApiKey = "10023f21",
                ApiSecret = "wu4AX4zzKwKl7cXf"
            });
            var results = client.SMS.Send(request: new SMS.SMSRequest()
            {
                from = "Nexmo",
                to = "44787628699",
                text = receipt
            });
        }

    }
}
