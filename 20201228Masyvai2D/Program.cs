using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201228Masyvai2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Mas2D = { { 1, 2, 3 }, { 1, 1, 1 }, { 0, 0, 0 } };

            int suma = 0;
            int kiekis = Mas2D.Length;

            for(int i =0; i< Mas2D.GetLength(0); i++)
            {
                for(int j=0; j<Mas2D.GetLength(1); j++)
                {
                    suma += Mas2D[i, j];
                }
            }
            double vidurkis = suma / kiekis;

            
            Console.WriteLine("Iveskite kur norite ivesti skaiciu [0-{0}] [0-{1}]:", Mas2D.GetLength(0)-1, Mas2D.GetLength(1)-1);
            int ii = int.Parse(Console.ReadLine());
            int jj = int.Parse(Console.ReadLine());

            Mas2D[ii, jj] = int.Parse(Console.ReadLine());
            Console.WriteLine("Vidurkis - {0}", vidurkis);
            Console.WriteLine("_________________________________________________");
            for (int i = 0; i < Mas2D.GetLength(0); i++)
            {
                for (int j = 0; j < Mas2D.GetLength(1); j++)
                {
                    Console.Write(Mas2D[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
