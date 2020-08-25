using System;

namespace KMD.TerningApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {
            Kerne.Terning t;
            t = new Kerne.Terning();
            t.Værdi = 1;
            t.RystetTid = DateTime.Now;
            Console.WriteLine(t.Værdi);
        }
    }
}
