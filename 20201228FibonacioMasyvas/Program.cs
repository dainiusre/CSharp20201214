using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201228FibonacioMasyvas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[10];

            masyvas[0] = 1;
            masyvas[1] = 1;

            for(int i = 2; i< masyvas.Length; i++)
            {
                masyvas[i] = masyvas[i - 1] + masyvas[i - 2];
            }

            foreach(var i in masyvas)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            
        }
    }
}
