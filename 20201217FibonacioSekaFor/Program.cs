using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201217FibonacioSekaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek fibonacio skaiciu pageidaujate? (>2)");
            int kiekis = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            string seka = a + " " + b + " ";

            for(int i = 2; i< kiekis; i++)
            {
                int c = a + b;
                Console.WriteLine(c);
                seka += c + " ";
                a = b;
                b = c;
            }
            //Console.WriteLine(seka);
            Console.ReadLine();
        }
    }
}
