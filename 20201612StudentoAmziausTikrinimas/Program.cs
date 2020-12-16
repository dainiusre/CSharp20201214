using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201612StudentoAmziausTikrinimas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 65;
            Console.WriteLine("Studento amzius: ");
            double amzius = double.Parse(Console.ReadLine());

            if(amzius>b)
            {
                Console.WriteLine("Leidziama, taikyti nuolaida.");
            }
            else if(amzius>a)
            {
                Console.WriteLine("Leidziama, netaikyti nuolaidos.");
            }
            else
            {
                Console.WriteLine("Neleidziama. Nepilnametis.");
            }
            Console.Read();
        }
    }
}
