using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201228MasyvaiConsoleUzpildymas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masyvo dydis: ");
            int dydis = int.Parse(Console.ReadLine());

            int[] skaiciuMasyvas = new int[dydis];

            int didziausiasSkaicius = int.MinValue;
            int maziausiasSkaicius = int.MaxValue;

            for(int i = 0; i<skaiciuMasyvas.Length; i++)
            {
                Console.WriteLine($"Iveskite {i} indekso reiksme dydis: ");
                int ivestis = int.Parse(Console.ReadLine());

                skaiciuMasyvas[i] = ivestis;
                if(ivestis>didziausiasSkaicius)
                {
                    didziausiasSkaicius = ivestis;
                }
                if(ivestis<maziausiasSkaicius)
                {
                    maziausiasSkaicius = ivestis;
                }
            }

            Console.WriteLine($"Didziausias skaicius {didziausiasSkaicius}");
            Console.WriteLine($"Maziausias skaicius {maziausiasSkaicius}");
            Console.ReadLine();
        }
    }
}
