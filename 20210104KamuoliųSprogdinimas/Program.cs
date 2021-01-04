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
        static void Main(string[] args)
        {
            Spalva raudona = new Spalva(255, 0, 0);
            raudona.ColorDetails();
            Spalva.KokiaCiaSpalva(raudona);


            Spalva spl = Spalva.Parse("R 20 G 0 B 0");
            spl.ColorDetails();
            Console.Read();


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

        public void ColorDetails()
        {
            Console.WriteLine($"R {R} G {G} B {B} A {A}");
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
    }
}
