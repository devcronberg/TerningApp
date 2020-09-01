using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var res = DRNyheder.Kerne.DRNyhed.Hent(@"https://www.dr.dk/nyheder/service/feeds/penge/");

            foreach (var nyhed in res.Select(i=>new { i.Titel, i.Beskrivelse }))
            {
                Console.WriteLine(nyhed.Titel);
            }
        }
    }
}
