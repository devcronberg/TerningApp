using KMD.Person.Kerne;
using System;
using System.Collections.Generic;

namespace KMD.Person.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelRepository r = new ExcelRepository();
            var res = r.HentPersoner();
            foreach (var person in res)
            {
                Console.WriteLine(person.Navn);
                foreach (var bil in person.Biler)
                {
                    Console.WriteLine("\t" + bil.Mærke);
                }
            }
        }
    }
}
