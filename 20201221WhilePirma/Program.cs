using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201221WhilePirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            Console.WriteLine("---------------------------");

            while(skaicius>0)
            {
                Console.WriteLine($"{skaicius}");
                if(skaicius % 2 == 0)
                {
                    suma += skaicius;
                }
                skaicius--;
            }
            Console.WriteLine("Lyginiu skaiciu suma: {0}",suma);
            Console.Read();
        }
    }
}
