using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20201230SkaitymasIsFailo
{
    class Program
    {
        static void Main(string[] args)
        {
            string keliasIFaila = @"C:\Users\justa\kintamieji20201214\20201230SkaitymasIsFailo\bin\Debug\input.txt";
            List<string> eilutes = File.ReadAllLines(keliasIFaila).ToList();

            int counter = 1;
            foreach(string eilute in eilutes)
            {
                Console.WriteLine($"{counter++} " + eilute);
            }
            Console.Read();
        }
    }
}
