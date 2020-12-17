using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201217ForCiklasPvz
{
    class Program
    {
        static void Main(string[] args)
        {
            string piramide = "";
            for(int i = 0; i<1000; i++)
            {                
                Console.WriteLine(piramide+="*");
            }
            Console.ReadLine();
        }
    }
}
