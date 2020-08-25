using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KMD.TerningApp.Kerne
{


    /*

        - Avancerede (operator overload, relection, LINQ ...)
        - Serialisering / Deserialisering (XML, JSON)
        - NuGet
          - Excel ... + ...
        - DB2 / Sql - direkte kald
          - EF (Entity Framework)
        - HTTP / HTTPS

        - Web / WPF / WinForm
          - MVC / Blazor / Razor / JS / TS 

    */

    public class Terning
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public event Action<DateTime> Sekser;
        public event Action<int> Rystet;

        public int Værdi { get; private set; }
        public DateTime RystetTid { get; private set; }

        private Random rnd = null;

        public Terning()
        {            
            rnd = new Random();
            this.Værdi = 1;
        }

        public void Ryst() {
            this.Værdi = rnd.Next(1, 7);
            this.RystetTid = DateTime.Now;
            Rystet?.Invoke(this.Værdi);
            if (this.ErSekser()) {
                //if (Sekser != null) {
                Sekser?.Invoke(this.RystetTid); 
                //}
            }
        }

        public async Task RystAsync()
        {
            var response1 = await httpClient.GetStringAsync("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
            this.Værdi = Convert.ToInt32(response1);
        }


        public bool ErSekser() { 
            return this.Værdi == 6;
        }

        public virtual void Skriv() {
            Console.WriteLine($"[ {this.Værdi} ]");
        }

    }

    public class LudoTerning : Terning {

        public bool ErStjerne() {
            return this.Værdi == 3;
        }

        public bool ErGlobus()
        {
            return this.Værdi == 5;
        }

        public override void Skriv()
        {
            if(ErStjerne())
                Console.WriteLine("[ S ]");
            else if (ErGlobus())
                Console.WriteLine("[ G ]");
            else
                base.Skriv();
        }


    }



    //public class Terning
    //{
    //    //// Offentlig field - felt
    //    //public int Værdi;
    //    //public DateTime RystetTid;

    //    // Properties - Egenskaber
    //    // Automatiake egenskaber
    //    public int Værdi { get; private set; }
    //    public DateTime RystetTid { get; private set; }

    //    //private int værdi;
    //    //private DateTime RystetTid;

    //    //public int Værdi {
    //    //    get {
    //    //        return this.værdi;
    //    //    }
    //    //    //set {
    //    //    //    this.værdi = value;
    //    //    //}
    //    //}

    //    // default
    //    public Terning()
    //    {
    //        this.Værdi = 1;
    //    }

    //    // Custom
    //    public Terning(int værdi) {
    //        if (værdi < 1 || værdi > 6)
    //        {
    //            Exception e = new Exception("Forkert værdi");
    //            throw e;
    //        }
    //        this.Værdi = værdi;
    //    }


    //}

    //public enum TerningVærdi
    //{
    //    Et = 1,
    //    To, 
    //    Tre, 
    //    Fire, 
    //    Fem, 
    //    Seks
    //}

    class Hund {
        public string Navn { get; set; }
        // public int Alder { get; set; }

        private int _alder;
        public int Alder {
            get {
                return _alder;
            }
            set {
                // check..
                this._alder = value;
            }
        }
    }
}
