using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201216SkaiciavimoMasinele
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Iveskite A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite B:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite veiksma (+,-,*,/):");
            string operatorius = Console.ReadLine();

            double ats = 0;

            if (operatorius == "+")
            {
                ats = a + b;
                Console.WriteLine(a + operatorius + b + "=" + ats);
            }
            else if (operatorius == "-")
            {
                ats = a - b;
                Console.WriteLine(a + operatorius + b + "=" + ats);
            }
            else if (operatorius == "*")
            {
                ats = a * b;
                Console.WriteLine(a + operatorius + b + "=" + ats);
            }
            else if (operatorius == "/")
            {
                ats = a / b;
                Console.WriteLine(a + operatorius + b + "=" + ats);
            }
            else
            {
                Console.WriteLine("Nesuprantama ivestis!");
            }

            Console.Read();
        }
    }
}
