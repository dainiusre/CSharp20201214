using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201221Zaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sugalvokite skaiciu [0-5000] ir sakykite ar daugiau(+) maziau(-) atspejau(=):");
            string ivestis = "";
            int min = 0;
            int max = 5001;
            int guess = 2500;
            while(ivestis != "=")
            {
                guess = min+(max - min) / 2;
                Console.WriteLine("Ar jusu skaicius yra {0}", guess);
                ivestis = Console.ReadLine();
                if (ivestis == "+")
                {
                    min = guess;
                }
                else if( ivestis == "-")
                {
                    max = guess;
                }
                else if( ivestis == "=")
                {
                    Console.WriteLine($"Atspejau! Tavo skaicius yra {guess}");
                }
                else
                {
                    Console.WriteLine("Neatpazinta ivestis veskite dar karta!");
                }
            }
            Console.ReadLine();
        }
    }
}
