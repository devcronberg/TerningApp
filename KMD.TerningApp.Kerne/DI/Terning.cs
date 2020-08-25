using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KMD.TerningApp.Kerne.DI
{
    public class Terning
    {

        public int Værdi { get; private set; }
        public DateTime RystetTid { get; private set; }

        private ITilfældighedsGenerator rnd = null;

        public Terning()
        {
            rnd = new TilfældighedsGeneratorSystemRandom();
            this.Ryst();
        }
        public Terning(ITilfældighedsGenerator g)
        {
            rnd = g;
            this.Ryst();
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
            this.RystetTid = DateTime.Now;
        }

        public void Skriv()
        {
            Console.WriteLine($"[ {this.Værdi} ]");
        }

    }

    public interface ITilfældighedsGenerator {

        int Next(int min, int max);

    }


    public class TilfældighedsGeneratorSystemRandom : ITilfældighedsGenerator
    {
        private Random rnd = new Random();
        public int Next(int min, int max)
        {
            return rnd.Next(1, 7);
        }
    }
    public class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        public int Next(int min, int max)
        {
            return 6;
        }
    }


    public class TilfældighedsGeneratorRandomOrg : ITilfældighedsGenerator
    {
        public int Next(int min, int max)
        {
            using (WebClient w = new WebClient())
            {
                string s = w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
                return Convert.ToInt32(s);
            }
        }
    }



}
