using KMD.TerningApp.Kerne;
using KMD.TerningApp.Kerne.DI;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using MCronberg;
using System.Collections.Generic;

namespace KMD.TerningApp.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)

        {

            Dag3();
            return;
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

        public static double Gns(params double[] tal) {
            double sum = 0;
            for (int i = 0; i < tal.Length; i++)
            {
                sum += tal[i];
            }
            return sum / tal.Length;
        }


        static IEnumerable<int> FindTal1()
        {
            List<int> lst = new List<int>();
            int i = 0;
            do
            {
                i++;
                lst.Add(i);
                Console.WriteLine($"Fundet {i} i FindTal1");
                if (i == 3)
                    break;
            } while (true);
            return lst;
        }

        static IEnumerable<int> FindTal2()
        {
            int i = 0;
            do
            {
                i++;
                Console.WriteLine($"Fundet {i} i FindTal2");
                yield return i;
                if (i == 3)
                    yield break;
            } while (true);
        }

        private static void Dag3()
        {

            using (Kat t = new Kat()) {


                int i = 1;
                
            }


        dynamic ao = new { Id=1, Alder =12 };
            

            return;
            





                // kjdhkdsjfhg 
                //t.Dispose();

                return;

            //foreach (var item in FindTal2())
            //{
            //    Console.WriteLine(item);
            //}
            //return;
            
            int[] tal = { 4, 58, 1, 5, 6, 7, 2 };
            //Console.WriteLine(string.Join(" ", tal));
            //var res4 = System.Array.FindAll(tal, t => t < 10);

            System.Array.ForEach(tal, t => Console.WriteLine(t));


            //Console.WriteLine(res4);
            return; 


            string aa = "mikKeL";
            //string navn = StringHelper.Proper(aa, 1);

            string bb = "mAtHias";
            Console.WriteLine(bb.Proper());
            //Console.WriteLine(navn);
            return;


            var res = Gns(5, 6, 43, 5, 6, 4, 3, 4, 6, 3);

            int a = 1;
            bool? b = true;
            DateTime c = DateTime.Now;

            c =  c.AddDays(1);
            
            double MitG(int a, bool b){
                return 0;
            }
            var y = MitG(1, true);

            //Func<int, bool, double> Miga = (int a, bool b) => { return 0; };
            Func<int, bool, double> Miga = (a, b) => 0;
            var v2 = Miga(4, true);



            b = null;
            if (b.HasValue)
            {

            }
            else { }



            MetodeTest(b);

            var r = GnsSum(100.5434, 100.4);
            Console.WriteLine(r.Sum);
            Console.WriteLine(r.Gns);
            
        }

        //public static MinReturVærdi GnsSum(double a, double b) {
        //    double sum = a + b;
        //    double gns = sum / 2.0;
        //    MinReturVærdi m = new MinReturVærdi { Sum = sum, Gns = gns };
        //    return m;
        //}

        public static (double Sum, double Gns, bool v) GnsSum(double a, double b)
        {
            double sum = a + b;
            double gns = sum / 2.0;
            return (sum, gns, true);
        }

        private static void MetodeTest(bool? b)
        {
            
        }
        private static DateTime? MetodeTest4()
        {
            return null;
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

    class MinReturVærdi {
        public double Sum;
        public double Gns;
    }

    class Kat : IDisposable {
        public int AntalBen { get; set; }
        public string Navn { get; set; }

        public Kat()
        {
            // Fødes
        }

        // Tråd for sig selv
        ~Kat()
        {
            // Dør
        }

        public void Dispose() {
            Console.WriteLine("Jeg rydder op");
        }
    }

    class Hund {

        private readonly int antalBen;
        private readonly string navn;

        public Hund(int antalBen, string navn)
        {
            this.antalBen = antalBen;
            this.navn = navn;
        }

        public int AntalBenOperation(bool a) {
            return this.antalBen - 1;
        }

        public int AntalBen => antalBen;
    }

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
