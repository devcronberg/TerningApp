using System;
using System.Data;
using System.Data.SQLite;

namespace DataDemo1
{
    class Program
    {

        private static string databaseFil = "c:\\temp\\people.db";
        private static string connectionString = "Data Source=" + databaseFil;
        static void Main(string[] args)
        {

            DataTable dt = new DataTable();
            using (SQLiteConnection cn = new SQLiteConnection(connectionString))
            {
                cn.Open();
                using (SQLiteCommand cm = new SQLiteCommand(cn))
                {
                    //cm.CommandText = "select * from person where Height<170 order by LastName";
                    cm.CommandText = "update person set Height=100 where PersonId=1";
                    cm.CommandType = System.Data.CommandType.Text;
                    int poster = cm.ExecuteNonQuery();
                    Console.WriteLine(poster);
                    //SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
                    //da.Fill(dt);
                    //var reader = cm.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    Console.WriteLine(reader.GetValue(2));
                    //}
                }
            }

            //foreach (DataRow item in dt.Rows)
            //{
            //    Console.WriteLine(item["LastName"]);
            //}


        }
    }
}
