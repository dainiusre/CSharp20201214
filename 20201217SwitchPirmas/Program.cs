using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201217SwitchPirmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            int sk2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu: ");
            int sk3 = int.Parse(Console.ReadLine());

            switch (sk1)
            {
                case 1:
                    Console.WriteLine($"suma: {sk1+sk2+sk3}");
                    break;
                case 2:
                    Console.WriteLine($"skirtumas: {sk1-sk3}");
                    break;
                case 3:
                    Console.WriteLine($"sandauga: {sk1*sk2}");
                    break;
            }
            Console.ReadLine();
        }
    }
}
