using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201230RandomListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> atsitiktiniaiSkaiciai = new List<int>();

            Random rng = new Random();

            int kiek = rng.Next(0, 1000);

            for(int i = 0; i<kiek; i++)
            {
                int skaicius = rng.Next(1000);
                atsitiktiniaiSkaiciai.Add(skaicius);
            }
            Console.WriteLine("Max {0}", atsitiktiniaiSkaiciai.Max());
            Console.WriteLine("First {0}", atsitiktiniaiSkaiciai.First());
            Console.WriteLine("Min {0}",atsitiktiniaiSkaiciai.Min());
            Console.WriteLine("Last {0}",atsitiktiniaiSkaiciai.Last());
            Console.WriteLine("Aaverage {0}",atsitiktiniaiSkaiciai.Average());
            Console.WriteLine("Sum {0}",atsitiktiniaiSkaiciai.Sum());
            Console.WriteLine("Count {0}",atsitiktiniaiSkaiciai.Count);
            Console.WriteLine("Distinct count {0}",atsitiktiniaiSkaiciai.Distinct().Count());
            Console.WriteLine("BLast {0}",atsitiktiniaiSkaiciai[atsitiktiniaiSkaiciai.Count-2]);

            int nelyginiuKiekis = 0;
            int nelyginiuSuma = 0;

            foreach(int sk in atsitiktiniaiSkaiciai)
            {
                if(sk % 2 != 0)
                {
                    nelyginiuSuma +=sk;
                    nelyginiuKiekis++;
                }
            }
            Console.WriteLine("Nelyginiu suma {0} Nelyginiu kiekis {1}", nelyginiuSuma, nelyginiuKiekis);
            Console.ReadLine();

        }
    }
}
