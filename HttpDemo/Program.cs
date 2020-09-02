using System;
using System.Collections.Generic;
using System.Net;

namespace HttpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string json;
            using (WebClient w = new WebClient())                
                json = w.DownloadString("https://dawa.aws.dk/kommuner/");

            var res = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kommune>>(json);
        }
    }

    class Kommune {
        public string Kode { get; set; }
        public string Navn { get; set; }

        public string Regionskode { get; set; }
        public string Aaa { get; set; }

    }
}
