using System;

namespace KMD.TerningApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {

            try
            {
                Kerne.Terning t;
                t = new Kerne.Terning();
                Console.WriteLine(t.Værdi);
                //t.Værdi = -6;
                // 
                Console.WriteLine(t.Værdi);


                Kerne.Terning t2 = new Kerne.Terning(6);
                Console.WriteLine(t2.Værdi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
