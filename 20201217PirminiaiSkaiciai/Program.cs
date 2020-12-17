using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201217PirminiaiSkaiciai
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for(int i = 2;i<1000;i++)
            {
                bool prime = true;
                for(int j = 2; j<i; j++)
                {
                    if(i%j == 0)
                    {
                        prime = false;                        
                    }
                }
                if (prime)
                {
                    suma += i;
                }
            }
            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
