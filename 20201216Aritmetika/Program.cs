using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201216Aritmetika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirmas sk: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Antras sk: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            double atimtis = sk1 - sk2;

            Console.WriteLine(sk1 + "+" + sk2 + "=" + (sk1 + sk2));
            Console.WriteLine($"{sk1}-{sk2}={atimtis}");
            Console.WriteLine("{0}*{1}={2}", sk1, sk2, (sk1 * sk2));
            Console.WriteLine($"{sk1}/{sk2}={sk1 / (double)sk2}");

            Console.Read();
        }
    }
}
