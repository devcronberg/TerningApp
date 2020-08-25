using System;
using System.Collections.Generic;
using System.Text;

namespace KMD.TerningApp.Kerne
{
    public class Terning
    {
        //// Offentlig field - felt
        //public int Værdi;
        //public DateTime RystetTid;

        // Properties - Egenskaber
        // Automatiake egenskaber
        public int Værdi { get; private set; }
        public DateTime RystetTid { get; private set; }

        //private int værdi;
        //private DateTime RystetTid;

        //public int Værdi {
        //    get {
        //        return this.værdi;
        //    }
        //    //set {
        //    //    this.værdi = value;
        //    //}
        //}

        // default
        public Terning()
        {
            this.Værdi = 1;
        }

        // Custom
        public Terning(int værdi) {
            if (værdi < 1 || værdi > 6)
            {
                Exception e = new Exception("Forkert værdi");
                throw e;
            }
            this.Værdi = værdi;
        }


    }

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
