using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201217SudetingasIF
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius1 = 651.51;
            double skaicius2 = 6846;
            double skaicius3 = 101;

            if(skaicius1>skaicius2 && skaicius1<100)
            {
                Console.WriteLine(1);
            }
            if(skaicius2>0 && skaicius2>skaicius1)
            {
                Console.WriteLine(2);
            }
            if((skaicius1>skaicius2 && skaicius1>skaicius3) || skaicius1>0)
            {
                Console.WriteLine(3);
            }
            if(skaicius3>=5 && skaicius3<=10 || skaicius3>skaicius1 || skaicius3>skaicius2)
            {
                Console.WriteLine(4);
            }

            Console.Read();

        }
    }
}
