using KMD.Person.Kerne;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace KMD.Person.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IDataRepository r = new ExcelRepository();
            ListeAfPersoner listeAfPersoner = new ListeAfPersoner { Personer = r.HentPersoner() };
            

            // Fra objekter til JSON
            string jsonFraObjekter = Newtonsoft.Json.JsonConvert.SerializeObject(listeAfPersoner);
            System.IO.File.WriteAllText(@"c:\tmp\personer.json", jsonFraObjekter);

            // Fra JSON til Objekter
            string jsonFraFil = System.IO.File.ReadAllText(@"c:\tmp\personer.json");
            ListeAfPersoner fraJSON = Newtonsoft.Json.JsonConvert.DeserializeObject<ListeAfPersoner>(jsonFraFil);

            // Fra objekter til XML
            XmlSerializer xs2 = new XmlSerializer(typeof(ListeAfPersoner));
            using (FileStream fs = File.Create(@"c:\tmp\personer.xml"))
                xs2.Serialize(fs, listeAfPersoner);

            // Fra XML til objekter
            XmlSerializer xs4 = new XmlSerializer(typeof(ListeAfPersoner));
            ListeAfPersoner fraXml;
            using (StreamReader fs = File.OpenText(@"c:\tmp\personer.xml"))
                fraXml = xs4.Deserialize(fs) as ListeAfPersoner;

            IDataRepository rep = RepositoryFind.FindRepository();
            var res = rep.HentPersoner();
            foreach (var person in res)
            {
                Console.WriteLine(person.Navn);
                foreach (var bil in person.Biler)
                {
                    Console.WriteLine("\t" + bil.Mærke);
                }
            }

            var biler = res.SelectMany(i => i.Biler).ToList();
            foreach (var bil in biler)
                Console.WriteLine(bil.Mærke + " som tilhører " + bil.Person.Navn);

        }
    }

}

