using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201216LyginisSK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirmas sk: ");
            double sk = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if(sk%2 == 0)
            {
                Console.WriteLine("{0} yra lyginis", sk);
            }
            if(sk%2!=0)
            {
                Console.WriteLine("{0} yra nelyginis", sk);
            }
            Console.ReadLine();
        }
    }
}
