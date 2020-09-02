using SQLiteEF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            // https://github.com/devcronberg/undervisning-db-sqlite

            PeopleContext context = new PeopleContext();
            //List<Person> lst = context.People.Where(i=>i.Height<170).OrderBy(i => i.LastName).Skip(5).Take(5).ToList();

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item.LastName);
            //}

            //Person p = context.People.Where(i => i.PersonId == 1).FirstOrDefault();
            //p.Height = 300;
            //context.SaveChanges();

            //Person p = new Person() { FirstName = "a", LastName = "b", CountryId = 1 };
            //context.People.Add(p);
            //context.SaveChanges();

            //Person p = context.People.Where(i => i.PersonId == 201).FirstOrDefault();
            //context.People.Remove(p);
            //context.SaveChanges();


        }
    }
}
