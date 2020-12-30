using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020ListAddViduje
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1 };

            int sk = 20;

            int count = 1;

            while(count<20)
            {
                int[] tempMas = mas;
                mas = new int[mas.Count() + 1];

                for(var i = 0; i< mas.Length; i++)
                {
                    mas[i] = tempMas[i];
                }
                mas[mas.Length-1] = count * 2;
                count*= 2;
            }
        }
    }
}
