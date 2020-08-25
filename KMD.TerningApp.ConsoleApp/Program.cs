using KMD.TerningApp.Kerne;
using System;

namespace KMD.TerningApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {

            try
            {
                Kerne.Terning t = new Kerne.Terning();
                t.Skriv();
                t.Ryst();
                t.Skriv();

                LudoTerning l = new LudoTerning();
                l.Skriv();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
