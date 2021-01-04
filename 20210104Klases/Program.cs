using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210104Klases
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobilis manoAutomobilis = new Automobilis("Audi", "A4", 2005);
            Automobilis auto1 = new Automobilis("Mazda", "3", 2010);
            Automobilis auto2 = new Automobilis("Tesla", "Model 3");
            Automobilis auto3 = new Automobilis();
            auto3.InformacijaApieAutomobili();
            manoAutomobilis.InformacijaApieAutomobili();
            auto1.InformacijaApieAutomobili();
            auto2.InformacijaApieAutomobili();

            Console.Read();
        }
    }

    class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int GamybosMetai;
        public DateTime GamybosData;

        public Automobilis()
        {

        }

        public Automobilis(string marke, string modelis, int gamybosMetai)
        {
            Marke = marke;
            Modelis = modelis;
            GamybosMetai = gamybosMetai;
        }
        public Automobilis(string marke, string modelis)
        {
            Marke = marke;
            Modelis = modelis;
            GamybosMetai = 2020;
        }

        public void InformacijaApieAutomobili()
        {
            Console.WriteLine($"Marke: {Marke}, Modelis: {Modelis}, GamybosMetai: {GamybosMetai}");
        }
    }
}
