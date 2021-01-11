using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210111_AbstrakciosKlasesFigura
{
    class Program
    {
        static void Main(string[] args)
        {
            Skritulys skr = new Skritulys();
            skr.R = 3;
            Skritulys skr1 = new Skritulys()
            {
                R = 3
            };
            var StaciakampisTrikampis = new StaciakampisTrikampis()
            {
                A = 5,
                B = 8
            };

            AtspausdintiFigurosPlota(skr);
            AtspausdintiFigurosPlota(skr1);
            AtspausdintiFigurosPlota(StaciakampisTrikampis);
            Console.Read();
            
        }

        private static void AtspausdintiFigurosPlota(Figura f)
        {
            Console.WriteLine(f.SkaiciuotiPlota());
        }
    }

    abstract class Figura
    {
        public abstract double SkaiciuotiPlota(); 
    }

    class StaciakampisTrikampis : Figura
    {
        public double A { get; set; }
        public double B { get; set; }
        public override double SkaiciuotiPlota()
        {
            return A * B / 2;
        }
    }
    class LygiakraštisTrikampis :Figura
    {
        private double A { get; }
        public LygiakraštisTrikampis(double a)
        {
            A = a;
        }
        public override double SkaiciuotiPlota()
        {
            return A*A * Math.Sqrt(3) * 4;
        }
    }

    class Kvadratas:Figura
    {
        private double A { get; }
        public Kvadratas(double A)
        {
            this.A = A;
        }
        public override double SkaiciuotiPlota()
        {
            return A * A;
        }
    }

    class Staciakampis:Figura
    {
        private double A { get; }
        private double B { get; }

        public override double SkaiciuotiPlota()
        {
            return A * B;
        }
    }

    class Skritulys:Figura
    {
        public double R { get; set; }
        public override double SkaiciuotiPlota()
        {
            return R * R * Math.PI;
        }
    }
}
