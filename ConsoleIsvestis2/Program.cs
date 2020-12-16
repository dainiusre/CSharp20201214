using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIsvestis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Spalvos raide:");
            //char spalvosRaide1 = Convert.ToChar(Console.ReadLine());
            char spalvosRaide = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("Pirmas sk: ");
            double sk1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Antras sk: ");
            double sk2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{vardas} mestamiausia spalva: {spalvosRaide}, {sk1}, {sk2}");
            Console.ReadLine();
        }
    }
}
