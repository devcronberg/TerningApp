using KMD.TerningApp.Kerne;
using KMD.TerningApp.Kerne.DI;
using System;
using System.Reflection;

namespace KMD.TerningApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {


            //TerningApp.Kerne.DI.Terning g = new Kerne.DI.Terning(new TilfældighedsGeneratorSystemRandom());
            //for (int i = 0; i < 20; i++)
            //{
            //    g.Ryst();
            //    g.Skriv();

            //}   
            //return;

            Maskine m = new Maskine();
            //m.logFunktion += Skriv;
            //m.logFunktion += SkrivTilFil;
            // m.logFunktion += (string txt) => { Console.WriteLine(txt); };
            m.logFunktion += txt => Console.WriteLine(txt);

            m.Start();
            m.Slut();


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

        public static void Skriv(string txt) {
            Console.WriteLine(txt);
        }
        public static void SkrivTilFil(string txt)
        {
            System.IO.File.AppendAllText(@"c:\kursus\log.txt", txt);

        }

    }
    // Action, Func, Predicate

    // public delegate void MinLogDelegate(string txt);
    class Maskine
    {
        public Action<string> logFunktion;

 
        public Maskine()
        {
        }
        public void Start()
        {
            //
            Log("Nu er jeg startet!");
        }
        public void Slut()
        {
            Log("Nu er jeg stoppet");
        }

        private void Log(string txt)
        {
            //if (nr == 1)
            //    Console.WriteLine(DateTime.Now.ToShortTimeString() + " " + txt);
            //else if (nr == 2)
            //    System.IO.File.AppendAllText(@"c:\kursus\log.txt", DateTime.Now.ToShortTimeString() + " " + txt + "\r\n");
            if(logFunktion!=null)
                logFunktion.Invoke(DateTime.Now.ToShortTimeString() + " " + txt);
        }

    }
}
