using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201223Romeniski
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = int.Parse(IvestiesMetodas("Iveskite teigiama sveikaji skaiciu iki 4000:"));

            int tukstanciai = skaicius / 1000;
            skaicius -= tukstanciai * 1000;
            //skaicius = skaicius % 1000;
            int simtai = skaicius / 100;
            skaicius -= simtai * 100;
            int desimt = skaicius / 10;
            int vienetai = skaicius - desimt * 10;

            string atsakymas = "";
            atsakymas += KonvertuotiIRoman(tukstanciai, "M", "", "");
            atsakymas += KonvertuotiIRoman(simtai, "C", "D", "M");
            atsakymas += KonvertuotiIRoman(desimt, "X", "L", "C");
            atsakymas += KonvertuotiIRoman(vienetai, "I", "V", "X");
            Console.WriteLine(atsakymas);
            Console.ReadLine();
        }
        private static string IvestiesMetodas(string uzklausa)
        {
            Console.WriteLine(uzklausa);
            string ivestis = Console.ReadLine();
            return ivestis;
        }

        private static string KonvertuotiIRoman(int skaicius, string vnt, string pnkt, string desmt)
        {
            string atsakymas = "";
            if(skaicius == 9)
            {
                atsakymas = vnt+desmt;
            }
            else if(skaicius == 4)
            {
                atsakymas = vnt+pnkt;
            }
            else if (skaicius>4)
            {
                atsakymas = pnkt;
                for( int i = 0; i< skaicius-5; i++)
                {
                    atsakymas += vnt;
                }
            }
            else
            {
                for (int i = 0; i < skaicius; i++)
                {
                    atsakymas += vnt;
                }
            }
            return atsakymas;
        }
    }
}
