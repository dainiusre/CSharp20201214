using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201223RefOutPvz
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius1 = 20;
            int skaicius2 = 45;

            double vidurkis = 0;
            int suma = 0;

            Console.WriteLine(skaicius1 + " " + skaicius2);
            Console.WriteLine("_______________________");
            Apkeisti(ref skaicius1, ref skaicius2);
            Console.WriteLine(skaicius1 + " " + skaicius2);
            Console.WriteLine("_______________________");
            Console.WriteLine(vidurkis + " " + suma);
            Console.WriteLine("_______________________");
            Skaiciuoti(skaicius1, skaicius2, out vidurkis, out suma);
            Console.WriteLine(vidurkis + " " + suma);
            Console.WriteLine("_______________________");


            Console.ReadLine();
        }
        private static void Apkeisti(ref int a, ref int b)
        {
            int laikinas = a;
            a = b;
            b = laikinas;
        }
        private static int Suma(int a, int b)
        {
            return a + b;
        }

        private static void Skaiciuoti(int a, int b, out double vidurkis, out int suma)
        {
            vidurkis = (double)(a + b )/ 2;
            suma = a + b;
        }
    }
}
