using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210114MokiniuVidurkiai
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Kontrolinis>> dienynas = new Dictionary<string, List<Kontrolinis>>();
            dienynas.Add("Justas", new List<Kontrolinis>());
            dienynas.Add("Vardenis", new List<Kontrolinis>());
            dienynas.Add("Petras", new List<Kontrolinis>());
            dienynas.Add("Vardas", new List<Kontrolinis>());

            dienynas["Justas"].Add(new Kontrolinis("Geografija", 2));
            dienynas["Justas"].Add(new Kontrolinis("Matematika", 8));
            dienynas["Justas"].Add(new Kontrolinis("Lietuviu", 10));
            dienynas["Justas"].Add(new Kontrolinis("Istorija", 9));

            dienynas["Vardenis"].Add(new Kontrolinis("Geografija", 8));
            dienynas["Vardenis"].Add(new Kontrolinis("Matematika", 5));
            dienynas["Vardenis"].Add(new Kontrolinis("Lietuviu", 2));
            dienynas["Vardenis"].Add(new Kontrolinis("Istorija", 5));
                      
            dienynas["Petras"].Add(new Kontrolinis("Geografija", 3));
            dienynas["Petras"].Add(new Kontrolinis("Matematika", 9));
            dienynas["Petras"].Add(new Kontrolinis("Lietuviu", 10));
            dienynas["Petras"].Add(new Kontrolinis("Istorija", 1));
                      
            dienynas["Vardas"].Add(new Kontrolinis("Geografija", 4));
            dienynas["Vardas"].Add(new Kontrolinis("Matematika", 6));
            dienynas["Vardas"].Add(new Kontrolinis("Lietuviu", 7));
            dienynas["Vardas"].Add(new Kontrolinis("Istorija", 9));

            Dictionary<string, double> mokiniuVidurkiai = new Dictionary<string, double>();

            foreach(var mokinys in dienynas)
            {
                double suma = 0;
                foreach(var kontrolinis in mokinys.Value)
                {
                    suma += kontrolinis.Balas;
                }
                mokiniuVidurkiai.Add(mokinys.Key, suma / mokinys.Value.Count);
            }

            var mokiniuVidurkiaiSurusiuoti = mokiniuVidurkiai.OrderByDescending(x => x.Value);
            foreach (var mokinioVidurkis in mokiniuVidurkiaiSurusiuoti)
            {
                Console.WriteLine($"Mokinys {mokinioVidurkis.Key} Vidurkis: {Math.Round(mokinioVidurkis.Value,2)}");
            }

            Console.ReadLine();

        }
    }

    class Kontrolinis
    {
        public string Pavadinimas { get; }
        public int Balas { get; }

        public Kontrolinis(string pavadinimas, int balas)
        {
            Pavadinimas = pavadinimas;
            Balas = balas;
        }

        public string GrazinkKazka()
        {
            return "Kazkas";
        }
    }



}
