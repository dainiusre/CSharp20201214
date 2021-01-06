using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210106PaveldejimasGyvunasSuo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gyvunas gyv1 = new Gyvunas("vardenis");
            //gyv1.Informacija();

            Gyvunas gyv2 = new Suo("Brisius", "KiemusSargus", false);
            Suo suo1 = new Suo("Rexas", "Vokieciu Aviganis", true);
            Zinduolis znd = new Suo("vrd", "vsl", true);
            Gyvunas gv = new Suo();
            InformacijaApieGyvuna(gyv1);
            InformacijaApieGyvuna(gyv2);
            InformacijaApieGyvuna(suo1);
            Console.Read();
        }

        public static void InformacijaApieGyvuna(Gyvunas gyv)
        {
            gyv.Informacija();
            Console.WriteLine("___________________________");
        }
    }

    class Gyvunas
    {
        protected string Vardas { get; set; }
        protected DateTime GimimoData { get; set; }

        public Gyvunas(string vardas, DateTime gimimoData)
        {
            Vardas = vardas;
            GimimoData = gimimoData;
        }

        public Gyvunas(string vardas)
        {
            Vardas = vardas;
            GimimoData = DateTime.Now;
        }

        public virtual void Informacija()
        {
            Console.WriteLine("Vardas: " + Vardas);
            Console.WriteLine("Gimimo data: " + GimimoData);
        }
    }

    class Zinduolis:Gyvunas
    {
        bool Gimdo { get; set; }
        public Zinduolis(string vardas, bool gimdo): base(vardas)
        {
            Gimdo = gimdo;
        }
        public Zinduolis(string vardas, DateTime gimimoData, bool gimdo) : base(vardas, gimimoData)
        {
            Gimdo = gimdo;
        }

        public Zinduolis(string vardas) : base(vardas)
        {
            Gimdo = false;
        }

    }

    class Suo : Zinduolis
    {
        public string Veisle { get; set; }

        public Suo(string vardas, DateTime gimimoData, string veisle, bool gimdo) : base(vardas, gimimoData, gimdo)
        {
            Veisle = veisle;
        }
        public Suo(string vardas, string veisle, bool gimdo) : base(vardas, gimdo)
        {
            Veisle = veisle;
        }
        public Suo(string vardas):base(vardas)
        {
            Veisle = "Lenciugus";
        }

        public Suo() :base("____")
        {

        }

        public override void Informacija()
        {
            base.Informacija();
            Console.WriteLine(Veisle);
        }
    }
}
