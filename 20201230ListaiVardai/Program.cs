using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201230ListaiVardai
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vardai = {"Justas", "Petras", "Rasa", "Viktorija" };
            List<string> varduSarasas = new List<string>();
            Random rng = new Random();

            int sarasoDydis = rng.Next(10, 20); 

            for(int i = 0; i<sarasoDydis; i++)
            {
                int skaicius = rng.Next(0, 4);
                varduSarasas.Add(vardai[skaicius]);
            }

            int skaitliukas = 0;
            foreach(string vardas in varduSarasas)
            {
                if(skaitliukas == varduSarasas.Count-1)
                {
                    Console.Write(vardas);
                }
                else
                {
                    Console.Write(vardas + ",");
                }
                skaitliukas++;
            }
            Console.Read();
        }
    }
}
