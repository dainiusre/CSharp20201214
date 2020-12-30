using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201230Didėjantys_skaičiai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int zmogausIvestasSkaicius = int.Parse(Console.ReadLine());

            int skaitliukas = 0;
            int sk = 1;

            while(sk<=zmogausIvestasSkaicius)
            {
                sk *= 2;
                skaitliukas++;
            }

            int[] uzpildomasMasyvas = new int[skaitliukas];
            sk = 1;
            Console.WriteLine("______________");
            for(int i = 0; i<skaitliukas; i++)
            {
                uzpildomasMasyvas[i] = sk;
                sk *= 2;
            }

            foreach (int skaicius in uzpildomasMasyvas)
            {
                Console.WriteLine(skaicius);
            }
            Console.WriteLine("_____");

            Console.ReadLine();
        }
    }
}
