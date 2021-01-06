using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20210104KamuoliųSprogdinimas
{
    class Program
    {
        public static Random RNG = new Random();
        static void Main(string[] args)
        {
            Metikas metikas = new Metikas("Justas");
            List<Kamuolys> nupirktiKamuoliai = NusipirktiKamuoliu();
            AtliktiMetimus(metikas, nupirktiKamuoliai);
            InformacijaPoMetimu(nupirktiKamuoliai);
            Console.Read();
        }

        private static List<Kamuolys> NusipirktiKamuoliu()
        {
            List<Kamuolys> kamuoliai = new List<Kamuolys>();
            int kamuliuKiekis = RNG.Next(5, 21);
            for(int i = 0; i<kamuliuKiekis; i++)
            {
                int R = RNG.Next(0, 256);
                int G = RNG.Next(0, 256);
                int B = RNG.Next(0, 256);
                Spalva color = new Spalva(R, G, B);
                double skersmuo = RNG.Next(10, 31) + RNG.NextDouble();
                Kamuolys naujasKam = new Kamuolys(color, skersmuo);
                kamuoliai.Add(naujasKam);
            }
            return kamuoliai;
        }

        private static void AtliktiMetimus(Metikas metikas, List<Kamuolys> kamuoliai)
        {
            Console.WriteLine($"Šiandien kamuolius mėto {metikas.Vardas}");
            
            for(int i = 1; i<21; i++)
            {
                Console.WriteLine(i + "______________________________");
                foreach (var kamuolys in kamuoliai)
                {

                    metikas.Mesti(kamuolys);
                }
            }
        }

        private static void InformacijaPoMetimu(List<Kamuolys> kamuoliuSarasas)
        {
            foreach(var kamuolys in kamuoliuSarasas)
            {
                kamuolys.Informacija();
            }
        }
    }

    class Spalva
    {
        public int R { get; }
        public int G { get; }
        public int B { get; }
        public int A { get; }

        public Spalva(int red, int green, int blue, int alpha)
        {
            if(InPossibleColorRange(red))
            {
                R = red;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            if (InPossibleColorRange(green))
            {
                G = green;
            }
            if(InPossibleColorRange(blue))
            {
                B = blue;
            }
            if(InPossibleColorRange(alpha))
            {
                A = alpha;
            }
        }
        public Spalva(int red, int green, int blue)
        {
            R = PralaidusColorRange(red);
            G = PralaidusColorRange(green);
            B = PralaidusColorRange(blue);
            A = 255;
        }

        public Spalva()
        {
            R = 0;
            G = 0;
            B = 0;
            A = 0;
        }

        public string ColorDetails()
        {
            return $"R {R} G {G} B {B} A {A}";
        }

        private bool InPossibleColorRange(int value)
        {
            if(value<0 || value>255)
            {
                return false;
            }
            return true;
        }

        private int PralaidusColorRange(int value)
        {
            if(value<0)
            {
                return 0;
            }
            if(value>255)
            {
                return 255;
            }
            return value;
        }

        public static void KokiaCiaSpalva(Spalva spl)
        {
            spl.ColorDetails();
        }

        public static Spalva Parse(string spalva)
        {
            Regex re = new Regex("R (\\d*) G (\\d*) B (\\d*)");
            var match = re.Match(spalva);
            var red = int.Parse(match.Groups[1].Value);
            return new Spalva(red, 0, 0);            
        }
    }

    class Kamuolys
    {
        public Spalva KamuolioSpalva { get; }
        public double Skersmuo { get; private set; }
        public int MetimuSkaicius { get; set; }
        public bool Sproges { get; private set; }

        public Kamuolys(Spalva kamuolioSpalva, double skersmuo)
        {
            MetimuSkaicius = 0;
            Sproges = false;
            Skersmuo = skersmuo;
            KamuolioSpalva = kamuolioSpalva;
        }

        public void Sprogti()
        {
            Skersmuo = 0;
            Sproges = true;
        }

        public void Informacija()
        {
            string arSproges = Sproges ? "Taip" : "Ne";
            Console.ForegroundColor = (ConsoleColor)Program.RNG.Next(0, 12);
            Console.WriteLine($"Kamuolio spalva: {KamuolioSpalva.ColorDetails()}, Skersmuo: {Skersmuo}, Metimu skaicius: {MetimuSkaicius}, Ar sproges? {arSproges}");
        }
    }

    class Metikas
    {
        public string Vardas { get; }
        public Metikas(string vardas)
        {
            Vardas = vardas;
        }
        public void Mesti(Kamuolys kamuolys)
        {
            if(!kamuolys.Sproges)
            {
                kamuolys.MetimuSkaicius++;
                double sansas = Program.RNG.NextDouble();

                if (sansas < 0.1)
                {
                    kamuolys.Sprogti();
                    kamuolys.Informacija();
                }
            }  
        }
    }
}
