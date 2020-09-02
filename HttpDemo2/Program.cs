using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpDemo2
{
    class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            var json = await httpClient.GetStringAsync("https://dawa.aws.dk/kommuner/");
            var res = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kommune>>(json);
            foreach (var kommune in res)
            {
                Console.WriteLine(kommune.Navn);
            }

            var k = res.Where(i => i.Kode == "0101").FirstOrDefault();
            Console.WriteLine(k.Navn);

        }
    }
    class Kommune
    {
        public string Kode { get; set; }
        public string Navn { get; set; }

        public string Regionskode { get; set; }
        public string Aaa { get; set; }

    }

}
