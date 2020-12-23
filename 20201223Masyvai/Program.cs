using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201223Masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciuMasyvas = { 1, 8, 6, 25, 10, 56 };

            int dydis = skaiciuMasyvas.Length; // masyvo dydis
            Console.WriteLine($"Pirma masyvo reiksme: {skaiciuMasyvas[0]}");
            Console.WriteLine($"Masyvo dydis: {dydis}");
            Console.WriteLine($"Paskutine masyvo reiksme: {skaiciuMasyvas[dydis - 1]}"); // paskutine reiksme
            Console.WriteLine("_____________________________________________________________________");
            char[] charMasyvas = new char[10];
            Console.WriteLine("Demonstracija su char masyvu: ");
            charMasyvas[0] = 'j';
            charMasyvas[1] = 'u';
            charMasyvas[2] = 's';

            skaiciuMasyvas[1] = 9;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(charMasyvas[i]);
                //Console.WriteLine(skaiciuMasyvas[i]);
            }


            Console.Read();

        }
    }
}
    

