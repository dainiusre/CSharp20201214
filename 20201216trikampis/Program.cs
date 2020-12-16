using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201216trikampis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite B:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite C:");
            double c = Convert.ToDouble(Console.ReadLine());

            if(a+b<=c)
            {
                Console.WriteLine("Negalima.");
            }
            else if(a+c<=b)
            {
                Console.WriteLine("Negalima.");
            }
            else if(b+c<=a)
            {
                Console.WriteLine("Negalima.");
            }
            else
            {
                Console.WriteLine("Galima.");
            }

            Console.ReadKey();
        }
    }
}
