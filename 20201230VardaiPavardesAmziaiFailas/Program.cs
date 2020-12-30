using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20201230VardaiPavardesAmziaiFailas
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Nuskaityti eilutes iš failo+
            //2. Eilutėje išskirti duomenis:
                //a. Ciklas per eilutės simbolius //VISI STRING YRA CHAR[]
                //b. Kablelio ieškojimas
                //c. Atskirų elementų sukūrimas
            //3. Saugoti atskirtus elementus į atskirus sąrašus (vardai, pavardes, amžiai (sveikieji skaičiai))

            string keliasIFaila = "duomenys.txt";
            List<string> duomenys = File.ReadAllLines(keliasIFaila).ToList();
            List<string> vardai = new List<string>();
            List<string> pavardes = new List<string>();
            List<int> amziai = new List<int>();

            foreach(string eilute in duomenys)
            {
                string word = "";
                int kableliuSkaitliukas = 0;

                foreach(char simbolis in eilute)
                {
                    if(simbolis == ',')
                    {
                        if(kableliuSkaitliukas == 0)
                        {
                            vardai.Add(word);
                        }
                        else if(kableliuSkaitliukas == 1)
                        {
                            pavardes.Add(word);
                        }
                        else if( kableliuSkaitliukas == 2)
                        {
                            amziai.Add(int.Parse(word));
                        }
                        else
                        {
                            Console.WriteLine("Beda! Taisyk koda!");
                        }
                        word = "";
                        kableliuSkaitliukas++;
                    }
                    else
                    {
                        word += simbolis;
                    }
                }
                amziai.Add(int.Parse(word));
            }

            foreach(string i in vardai)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach(string i in pavardes)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach(int i in amziai)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
