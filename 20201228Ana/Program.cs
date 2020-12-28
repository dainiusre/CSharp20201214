using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201228Ana
{
    class Program
    {
        static void Main(string[] args)
        {
            int ivestis = int.Parse(Console.ReadLine());

            for(int i = ivestis; i>10; i--)
            {
                if(ArTvarkingas(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine();
        }

        private static bool ArTvarkingas(int tikrinamasSkaicius) //
        {
            int desimtys = tikrinamasSkaicius / 10 % 10;
            int vienetai = tikrinamasSkaicius % 10;

            if(desimtys<=vienetai)
            {
                if(tikrinamasSkaicius/10 > 10)
                {
                    return ArTvarkingas(tikrinamasSkaicius / 10);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
