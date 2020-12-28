using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201228CountryLeader
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Susikuriam Masyvus

            //LT GB USA
            //Nauseda Boris Biden/Trump

            string[] salys = { "LT", "GB", "USA" };
            string[] lyderiai = { "Nauseda", "Boris", "Biden/Trump" };

            //2.
            //Lyderis/Salis?
            Console.WriteLine("Pagal ką ieškote? S - Šalis ; L - Lyderis");
            string parinktis = Console.ReadLine().ToLower();

            switch(parinktis)
            {
                case "s":
                    Console.WriteLine("Iveskite salies sutrumpinima: ");
                    string salis = Console.ReadLine();
                    int indexas = MasyvoIndexas(salys, salis);

                    if(indexas == -1)
                    {
                        Console.WriteLine("Neturime duomenu!");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Salies lyderio pavarde - {lyderiai[indexas]}");
                    }

                    break;
                case "l":
                    Console.WriteLine("Iveskite lyderio pavarde: ");
                    string lyderis = Console.ReadLine();
                    int index = MasyvoIndexas(lyderiai, lyderis);
                    if (index == -1)
                    {
                        Console.WriteLine("Neturime duomenu!");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Salies kodas - {salys[index]}");
                    }

                    break;
                default:
                    Console.WriteLine("Nerasiu!");
                    Console.ReadLine();
                    return;
                    break;
            }

            //if(parinktis == "s")
            //{

            //}
            //else if(parinktis == "l")
            //{

            //}
            //else
            //{

            //}

            //3.
            //LT - Nauseda
            //Boris - GB

            Console.Read();
        }

        private static int MasyvoIndexas(string[] masyvas, string ieskome)
        {
            for(var i=0; i<masyvas.Length; i++)
            {
                if(ieskome.ToUpper() == masyvas[i].ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
