using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace ExcelDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            DataSet ds;
            using (var stream = File.Open(@"c:\tmp\StamData.xlsx", FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
                ds = reader.AsDataSet();

            DataTable dt = ds.Tables[0];
            List<Person> lst = new List<Person>();
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (i++ == 0)
                    continue;
                
                lst.Add(new Person { Navn = row["Column1"].ToString(), Forkortelse = row["Column0"].ToString() });
            }

            foreach (var item in lst)
            {
                Console.WriteLine(item.NavnMedStort);
            }
        }
    }

    class Person {
        public string Forkortelse { get; set; }
        public string Navn { get; set; }

        public string NavnMedStort {
            get {
                return Navn?.ToUpper();
            }
        }
    }
}
