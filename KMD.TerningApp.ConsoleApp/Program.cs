using KMD.TerningApp.Kerne;
using KMD.TerningApp.Kerne.DI;
using System;

namespace KMD.TerningApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {


            TerningApp.Kerne.DI.Terning g = new Kerne.DI.Terning(new TilfældighedsGeneratorSystemRandom());
            for (int i = 0; i < 20; i++)
            {
                g.Ryst();
                g.Skriv();

            }   
            return;



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
