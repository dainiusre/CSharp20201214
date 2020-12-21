using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201221Metodai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasisveikinimas();
            string vardas = IvestiesMetodas("Jusu vardas:");
            int amzius = int.Parse(IvestiesMetodas("Jusu amzius:"));
            string hobis = IvestiesMetodas("Jusu hobis:");
            FormatuotasIsvedimas(vardas, amzius, hobis);
            Console.Read();
        }

        private static void Pasisveikinimas()
        {
            Console.WriteLine("Sveiki, norime susipazinti!");
        }

        private static void FormatuotasIsvedimas(string name, int age, string hobby)
        {
            Console.WriteLine($"{name} jus esate {age} metu ir jusu hobis yra {hobby}.");
        }


        private static string IvestiesMetodas(string uzklausa)
        {
            Console.WriteLine(uzklausa);
            string ivestis = Console.ReadLine();
            return ivestis;
        }

    }
}
