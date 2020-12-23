using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201223SkaiciuotuvasMetodai
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(IvestiesMetodas("Iveskite pirma skaiciu: "));            
            int b = int.Parse(IvestiesMetodas("Iveskite antra skaiciu: "));
            double atsakymas = 0;
            string operatorius = "";
            bool neradau = true;
            while(neradau)
            {
                operatorius = IvestiesMetodas("Iveskite veiksma: ");
                switch (operatorius)
                {
                    case "+":
                        atsakymas = Sudeti(a, b);
                        neradau = false;
                        break;
                    case "-":
                        atsakymas = Atimtis(a, b);
                        neradau = false;
                        break;
                    case "*":
                        atsakymas = Sandauga(a, b);
                        neradau = false;
                        break;
                    case "/":
                        atsakymas = Dalyba(a, b); 
                        neradau = false;
                        break;
                    default:
                        Console.WriteLine("Neatpažinta operacija!");
                        break;
                }
            }

            Console.WriteLine($"{a}{operatorius}{b}={atsakymas}");
            Console.ReadLine();
        }

        private static double Sudeti(int sk1, int sk2)
        {
            int suma = sk1 + sk2;
            return suma;
        }

        private static double Atimtis(int sk1, int sk2)
        {
            return sk1 - sk2;
        }

        private static double Sandauga(int sk1, int sk2)
        {
            return sk1 * sk2;
        }

        private static double Dalyba(int sk1, int sk2)
        {
            return (double)sk1 / sk2; //castinimas (pirma paskaita)
        }

        private static string IvestiesMetodas(string uzklausa)
        {
            Console.WriteLine(uzklausa);
            string ivestis = Console.ReadLine();
            return ivestis;
        }
    }
}
