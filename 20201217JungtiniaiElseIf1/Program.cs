using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201217JungtiniaiElseIf1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirmas skaicius:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("antras skaicius:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("trecias skaicius:");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("pirmas skaicius yra didziausias");
            }
            else if(b>c && b>a)
            {
                Console.WriteLine("antras skaicius yra didziausias");
            }
            else if(c>a && c>b)
            {
                Console.WriteLine("trecias skaicius yra didziausias");
            }
            else
            {
                Console.WriteLine("Nera vieno didziausio skaiciaus");
            }
            Console.Read();
        }
    }
}
