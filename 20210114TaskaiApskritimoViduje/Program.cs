using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _20210114TaskaiApskritimoViduje
{
    class Program
    {
        static void Main(string[] args)
        {
            Apskritimas aps = new Apskritimas(5, 8, 10);

            Random rng = new Random();
            int kiekis = rng.Next(10,30);
            Dictionary<Taskas, bool> taskaiApskritimeArNe = new Dictionary<Taskas, bool>();
            
            while(taskaiApskritimeArNe.Count< kiekis)
            {
                Taskas pt = new Taskas(rng);
                taskaiApskritimeArNe.Add(pt, aps.ArTaskasApskritime(pt));
            }

            foreach(var i in taskaiApskritimeArNe)
            {
                Console.WriteLine(i.Key + " Tilpo: " + i.Value);
            }

            Console.ReadLine();
        }
    }

    class Apskritimas
    {
        Taskas Centras { get; }
        public double R { get; }

        public Apskritimas(double x, double y, double r)
        {
            Centras = new Taskas(x, y);            
            R = r;
        }
        public Apskritimas(Taskas pt, double r)
        {
            Centras = pt;
            R = r;
        }

        public bool ArTaskasApskritime(Taskas pt)
        {
            return R >= Centras.AtstumasIki(pt);
        }
    }
    class Taskas
    {
        public double X { get; }
        public double Y { get; }
        public Taskas(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Taskas(Random rng)
        {
            X = rng.Next(-10, 30);
            Y = rng.Next(-10, 30);
        }

        public double AtstumasIki(Taskas pt)
        {
            var x = Math.Pow(X - pt.X, 2);
            var y = Math.Pow(Y - pt.Y, 2);

            return Math.Sqrt(x + y);
        }

        public override string ToString()
        {
            return $"X {X} Y {Y}";
        }

    }
}
