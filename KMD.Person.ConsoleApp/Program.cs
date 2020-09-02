using KMD.Person.Kerne;
using System;
using System.Collections.Generic;

namespace KMD.Person.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Person> lst = ...

            //Kerne.Person p = new Kerne.Person();
            //p.Id = 1;
            //p.Navn = "a";
            //p.Land = "DK";
            //p.Biler.Add(new Kerne.Bil { Id = 1, Mærke = "x", Person = p });

            //Console.WriteLine(p.Navn);
            //foreach (var bil in p.Biler)
            //    Console.WriteLine(bil.Mærke);

            //Console.WriteLine(p.Biler[0].Person.Navn);

            ExcelRepository r = new ExcelRepository();
            r.HentPersoner();
        }
    }
}
