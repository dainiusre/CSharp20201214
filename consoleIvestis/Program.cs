using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleIvestis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kazkoki teksta:");
            string sakinys = Console.ReadLine();

            Console.WriteLine("Irasytas tekstas:\n"+sakinys);
            /*
            Console.WriteLine("Irasytas tekstas:");
            Console.WriteLine(sakinys);
            */

            //Console.WriteLine($"Irasytas tekstas: \n{sakinys}");

            //Console.WriteLine("Irasytas tekstas : \n{0}", sakinys);
            Console.Read();
        }
    }
}
