using KMD.Person.Kerne;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KMD.Person.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataRepository r = RepositoryFind.FindRepository();

            var res = r.HentPersoner();
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

