using System.Collections.Generic;
using System.IO;
using MaxMind.GeoIP2;
using Newtonsoft.Json;

namespace RepeaterQTH.Data.Services
{
    public class AuthMessageSenderOptions
    {
        public string SendGridKey
        {
            get
            {   
                using StreamReader r = new StreamReader("connection.json");
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                return items["SendGridKey"];

            }
        }
    }
}