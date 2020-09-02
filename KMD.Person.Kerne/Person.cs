using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

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
            return null;
        }
    }


}
