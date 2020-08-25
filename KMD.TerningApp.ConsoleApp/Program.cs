using KMD.TerningApp.Kerne;
using KMD.TerningApp.Kerne.DI;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace KMD.TerningApp.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)

        {
            //System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            //s.Start();
            //Console.WriteLine("Start");

            //Task t1 = Task.Run(() =>
            //{
            //    Console.WriteLine("Sleep 1");
            //    Thread.Sleep(500);
            //});

            //Task t2 = Task.Run(() =>
            //{
            //    Console.WriteLine("Sleep 2");
            //    Thread.Sleep(500);
            //});

            //Task t3 = Task.Run(() =>
            //{
            //    Console.WriteLine("Sleep 3");
            //    Thread.Sleep(500);
            //});

            //await t1;
            //await t2;
            //await t3;

            //// eller
            //// await Task.WhenAll(t1, t2, t3);

            //Console.WriteLine("Slut");
            //s.Stop();
            //Console.WriteLine($"Tid: {s.ElapsedMilliseconds}");

            //Console.WriteLine("Tryk en tast for at afslutte");
            //Console.ReadKey();
            //return;

            //System.Timers.Timer ti = new System.Timers.Timer();
            //ti.Interval = 500;
            //ti.Enabled = true;
            //ti.Elapsed += (s, e) => Console.WriteLine("TICK");

            //System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\kursus");
            //w.EnableRaisingEvents = true;
            //w.Created += (s, e) => Console.WriteLine("Oprettet " + e.FullPath);
            //w.Deleted += (s, e) => Console.WriteLine("Slettet " + e.FullPath);

            //Console.ReadLine();
            //TerningApp.Kerne.DI.Terning g = new Kerne.DI.Terning(new TilfældighedsGeneratorSystemRandom());
            //for (int i = 0; i < 20; i++)
            //{
            //    g.Ryst();
            //    g.Skriv();

            //}   
            //return;

            //Maskine m = new Maskine();
            ////m.logFunktion += Skriv;
            ////m.logFunktion += SkrivTilFil;
            //// m.logFunktion += (string txt) => { Console.WriteLine(txt); };
            //m.logFunktion += txt => Console.WriteLine(txt);

            //m.Start();
            //m.Slut();


            //return;
            try
            {
                Kerne.Terning t = new Kerne.Terning();
                //t.Rystet += v => Console.WriteLine("Rystet til " + v);
                //t.Sekser += _ => Console.Beep();
                //t.Sekser += d => {
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("YESSS!!! - kl. " + d);
                //    Console.ResetColor();

                //};
                t.Skriv();
                //for (int i = 0; i < 10; i++)
                //{
                await t.RystAsync();
                t.Skriv();

                // }
                //LudoTerning l = new LudoTerning();
                //l.Skriv();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Skriv(string txt)
        {
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
            if (logFunktion != null)
                logFunktion.Invoke(DateTime.Now.ToShortTimeString() + " " + txt);
        }

    }
}
