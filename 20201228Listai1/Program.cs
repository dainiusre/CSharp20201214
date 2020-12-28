using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201228Listai1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai = new List<int>();
            Console.WriteLine("Iveskite pazymius: ");
            string ivestis = Console.ReadLine();
            while(ivestis != "n")
            {
                pazymiai.Add(int.Parse(ivestis));
                ivestis = Console.ReadLine();
            }
            Console.WriteLine("Max: {0}", pazymiai.Max());
            Console.WriteLine("Min: {0}", pazymiai.Min());
            Console.WriteLine("Vidurkis: {0}", pazymiai.Average());
            Console.WriteLine("Pirmas: {0}", pazymiai.First());
            Console.WriteLine("Paskutinis: {0}", pazymiai.Last());
            Console.Read();
        }
    }
}
