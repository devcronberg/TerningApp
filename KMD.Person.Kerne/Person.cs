using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace KMD.Person.Kerne
{
    public class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Land { get; set; }
        public List<Bil> Biler { get; set; }

        public Person()
        {
            Biler = new List<Bil>();
        }

    }

    public class Bil
    {
        public int Id { get; set; }
        public string Mærke { get; set; }
        public Person Person { get; set; }

    }

    public interface IDataRepository
    {
        List<Person> HentPersoner();
    }

    public class ExcelRepository : IDataRepository
    {
        public List<Person> HentPersoner()
        {
            DataSet ds;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(@"c:\tmp\personer.xlsx", FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
                ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

            List<Person> lst = new List<Person>();

            foreach (DataRow row in ds.Tables["personer"].Rows)
            {
                lst.Add(new Person
                {
                    Id = Convert.ToInt32(row["id"]),
                    Navn = row["navn"].ToString(),
                    Land = row["land"].ToString()
                });
            }

            foreach (DataRow row in ds.Tables["biler"].Rows)
            {
                Bil b = new Bil
                {
                    Id = Convert.ToInt32(row["id"]),
                    Mærke = row["mærke"].ToString()
                };
                int personId = Convert.ToInt32(row["personid"]);
                var p = lst.Where(i => i.Id == personId).FirstOrDefault();
                b.Person = p;
                p.Biler.Add(b);
            }
            return lst;
        }
    }

    public class TestRepository : IDataRepository
    {
        public List<Person> HentPersoner()
        {
            List<Person> lst = new List<Person>();

            for (int i = 0; i < 50; i++)
            {
                Person p = new Person
                {
                    Id = 1,
                    Navn = Guid.NewGuid().ToString(),
                    Land = "a",
                    Biler = new List<Bil> { new Bil { Id = 1, Mærke = "x" }
                    }
                };
                lst.Add(p);
                p.Biler[0].Person = p;
                
            }            
            return lst;
        }
    }

    public static class RepositoryFind {
        public static IDataRepository FindRepository() { 
            
            if(DateTime.Now.Second%2==0)            
                return new TestRepository();
            else
                return new ExcelRepository();
        }
    }

}