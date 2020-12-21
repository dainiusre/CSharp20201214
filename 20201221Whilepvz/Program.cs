using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201221Whilepvz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu [0-100]:");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            while(skaicius<0||skaicius>100)
            {
                Console.WriteLine("Blogas skaicius.");
                Console.WriteLine("Dar karta:");
                skaicius = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Gerai ivestas skaicius {skaicius}");
            Console.ReadLine();

        }
    }
}
