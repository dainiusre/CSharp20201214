using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201217SeptyniSimtasSandauga
{
    class Program
    {
        static void Main(string[] args)
        {
            int sandauga = 1;
            for (int i = 7; i < 100; i+=7)
            {
                sandauga = i * sandauga;
            }

            Console.WriteLine(sandauga);
            Console.Read();
        }
    }
}
