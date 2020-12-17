using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201217VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("1. Kava");
            Console.WriteLine("2. Arbata");
            Console.WriteLine("3. Limonadas");
            Console.WriteLine("4. Vanduo");
            Console.WriteLine("5. Nieko");
            Console.WriteLine("Iveskite pasirinkta gerima:");

            char ivestis = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch(ivestis)
            {
                case '1':
                    Console.WriteLine("Jus gavote kava.");
                    break;
                case '2':
                    Console.WriteLine("Jus gavote arbata.");
                    break;
                case '3':
                    Console.WriteLine("Jus gavote limonada.");
                    break;
                case '4':
                    Console.WriteLine("Jus gavote vandeni.");
                    break;
                case '5':
                    Console.WriteLine("nieko.");
                    break;
                default:
                    Console.WriteLine("Blogai ivestas pasirinkimas! Perkauti.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
