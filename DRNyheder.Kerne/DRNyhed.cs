using System;
using System.Collections.Generic;
using System.Xml;

namespace DRNyheder.Kerne
{
    public class DRNyhed
    {
        public string Titel { get; set; }
        public string Beskrivelse { get; set; }
        public DateTime Dato { get; set; }

        public override string ToString()
        {
            return $"{this.Dato:dd-MM hh:mm} {this.Titel}";
        }

        public static List<DRNyhed> Hent(string url)
        {

            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(url);

            System.Xml.XmlNodeList res = doc.SelectNodes("//item");
            List<DRNyhed> nyheder = new List<DRNyhed>();
            foreach (XmlNode item in res)
            {
                DRNyhed n = new DRNyhed();
                n.Titel = item.SelectSingleNode("title")?.InnerText;
                n.Beskrivelse = item.SelectSingleNode("description")?.InnerText;
                n.Dato = Convert.ToDateTime(item.SelectSingleNode("pubDate").InnerText);
                nyheder.Add(n);
            }
            return nyheder;
        }

    }
}
