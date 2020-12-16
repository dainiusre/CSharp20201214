using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201216IfasPirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirmas sk: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Antras sk: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            if(sk1>sk2)
            {
                Console.WriteLine($"{sk1} yra daugiau uz {sk2}");
            }
            if(sk1<sk2)
            {
                Console.WriteLine($"{sk1} yra maziau uz {sk2}");
            }
            if(sk1==sk2)
            {
                Console.WriteLine($"skaiciai lygus {sk1}");
            }
            Console.Read();
        }
    }
}
