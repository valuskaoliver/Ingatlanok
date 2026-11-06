using System;
using System.Collections.Generic;
using System.Text;

namespace Ingatlanok
{
    internal class Ingatlan
    {
        private int alapteruletM2 { get; set; }
        private int arEzerFT { get; set; }
        private static int osszesRegisztraltIngatlan = 0;
        public string Azonosito { get; set; }
        public string Cim { get; set; }
        public string Kategoria { get; set; }
        public int AlapteruletM2 
        {
            get => alapteruletM2;
            set => alapteruletM2 = value < 10 ? 10 : value;
        }
        public int ArEzerFT
        {
            get => arEzerFT;
            set => arEzerFT = value < 0 ? 0 : value;
        }
        
        public static int OsszesRegisztraltIngatlan
        {
            get => osszesRegisztraltIngatlan;
        }
        public Ingatlan(string azonosito, string cim, string kategoria, int alapteruletM2) : this(azonosito, cim, kategoria, alapteruletM2, 500)
        {

        }
        public Ingatlan(string azonosito, string cim, string kategoria, int alapteruletM2, int arEzerFt)
        {
            Azonosito = azonosito;
            Cim = cim;
            Kategoria = kategoria;
            AlapteruletM2 = alapteruletM2;
            ArEzerFT = arEzerFt;
            osszesRegisztraltIngatlan++;
        }

        public override string ToString()
        {
            return ($"[{Azonosito}] {Cim} ({Kategoria}) - Terület: {AlapteruletM2} m2 | Ár: {ArEzerFT}FT");
        }

        public double NegyzetmeterAr()
        {
            return ((ArEzerFT * 1000.0) / AlapteruletM2);
        } 
        public bool KategoriaEgyezik(string keresettKategoria)
        {
            return keresettKategoria == Kategoria;
        }
    }
}
