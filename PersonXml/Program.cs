using System;
using System.Collections.Generic;

namespace PersonXml
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = System.IO.File.ReadAllText(@"c:\tmp\person.xml");
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.LoadXml(xml);
            List<Person> lst = new List<Person>();
            // alle personer
            var personer = doc.SelectNodes("//person");
            foreach (System.Xml.XmlNode item in personer)
            {
                
                int id = Convert.ToInt32(item.Attributes["id"].Value);
                string navn = item.SelectSingleNode("navn").InnerText;
                int alder = Convert.ToInt32(item.SelectSingleNode("alder").InnerText);
                lst.Add(new Person { Id = 1, Navn = navn, Alder = alder });
        
            }
            lst.ForEach(i => Console.WriteLine(i.Navn));
        
        }
                    
    }
    class Person { 
        public int Id { get; set; } 
        public string Navn { get; set; } 
        public int Alder { get; set; }

        public List<Faktura> Fakturaer { get; set; }
    }

    class Faktura { }
}
