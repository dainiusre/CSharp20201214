using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201228MasyvaiTemperaturos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturos = { -1, -1.9, -2, 2, 3, -4 };

            //double didziausia = temperaturos.Max();
            //double maziausia = temperaturos.Min();
            //double vidurkis = temperaturos.Average();
            //double suma = temperaturos.Sum();
            double max = temperaturos[0];
            double min = temperaturos[0];
            double tempSuma = 0;
            double avg = 0;
            
            foreach(double temperatura in temperaturos)
            { 
                if(max<temperatura)
                {
                    max = temperatura;
                }
                if(min>temperatura)
                {
                    min = temperatura;
                }
                tempSuma += temperatura;
            }

            avg = tempSuma / temperaturos.Length;
            tempSuma = 0;

            foreach(double temperatura in temperaturos)
            {
                if(temperatura<avg)
                {
                    tempSuma += temperatura;
                }
            }
            Console.WriteLine($"Max: {max}\nMin: {min}\nAverage: {avg}\nSuma maziau vidurkio: {tempSuma}");
            Console.ReadLine();

        }
    }
}
