using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _20210106GyvunasKlases
{
    public class Gyvunas
    {
        public Gyvunas(string veisle, Color spalva, int kojuKiekis, string rusis, bool yraLaukinis, bool yraVandens, bool yraPlesrunas, string vardas, double svoris, double ugis, DateTime gimimoData, string atsakas, string minta, bool yraAlkanas)
        {
            Veisle = veisle;
            Spalva = spalva;
            KojuKiekis = kojuKiekis;
            Rusis = rusis;
            YraLaukinis = yraLaukinis;
            YraVandens = yraVandens;
            YraPlesrunas = yraPlesrunas;
            Vardas = vardas;
            Svoris = svoris;
            Ugis = ugis;
            GimimoData = gimimoData;
            Atsakas = atsakas;
            Minta = minta;
            YraAlkanas = yraAlkanas;
        }

        public string Veisle { get; }
        public Color Spalva { get; private set; }
        public int KojuKiekis { get; private set; }
        public string Rusis { get; }
        public bool YraLaukinis { get; private set; }
        public bool YraVandens { get; }
        public bool YraPlesrunas { get; }
        public string Vardas { get; }
        public double Svoris { get; private set; }
        public double Ugis { get; private set; }
        public DateTime GimimoData { get; }
        private string Atsakas { get; }
        public string Minta { get; }
        public bool YraAlkanas { get; private set; }


        public string Informacija()
        {
            string info = $"Veisle: {Veisle} Rusis: {Rusis}\n" +
                $"Spalva: {Spalva}\n" +
                $"Kojos: {KojuKiekis}\n" +
                $"Vardas: {Vardas}, Svoris: {Svoris}, Ugis: {Ugis}\n" +
                $"GimimoData: {GimimoData}";
            return info;
        }
        public int NustatytAmziu()
        {
            return DateTime.Now.Year - GimimoData.Year;
        }
        public string PasauktiGyvuna(string saukiamasVardas)
        {
            if(saukiamasVardas == Vardas)
            {
                return Atsakas;
            }
            return "";
        }
        public bool ArGalimaPaglostyti()
        {
            if(YraLaukinis|| (YraPlesrunas && YraAlkanas))
            {
                return false;
            }
            return true;
        }

        public bool Suesti(Gyvunas pamatytasGyvunas)
        {
            if(YraPlesrunas && YraAlkanas)
            {
                if(pamatytasGyvunas.Rusis == Minta)
                {
                    return true;
                }
            }
            return false;
        }

        public void Issipurvinti()
        {
            Spalva = Color.Black;
        }
    }
}
