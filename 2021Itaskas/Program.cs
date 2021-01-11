using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _2021Itaskas
{
    class Program
    {
        static void Main(string[] args)
        {
            Taskas2D t = new Taskas2D();
            t.X = 2;
            t.Y = 30;

            Taskas2D t1 = new Taskas2D();
            t1.X = 2;
            t1.Y = 3;

            Taskas2D t2 = new Taskas2D();
            t2.X = 1;
            t2.Y = 1;


            List<Taskas2D> taskai = new List<Taskas2D>() { t2, t1, t };
            foreach(var i in taskai)
            {
                Console.WriteLine(i);
            }
            taskai.Sort();
            Console.WriteLine("_________________________");
            foreach (var i in taskai)
            {
                Console.WriteLine(i);
            }

            if (t.Equals(t1))
            {
                Console.WriteLine("Jie lygus");
            }

            Tiese2D t2d = new Tiese2D(t1, t2);
            Console.WriteLine("start " + t2d.PradziosTaskas);
            Console.WriteLine("end " + t2d.PabaigosTaskas);
            Console.WriteLine("bandomas " + t);
            Console.WriteLine(t2d.ArTaskasTieseje(t));


            Console.WriteLine(t);
            Console.ReadLine();
        }
    }

    public interface ITaskas
    {
        double X { get; set; }
        double Y { get; set; }
        void Spausdinti();
    }

    public interface ITiese
    {
        ITaskas PradziosTaskas { get; set; }
        ITaskas PabaigosTaskas { get; set; }
        bool ArTaskasTieseje(ITaskas taskas);
    }

    public class Taskas2D : ITaskas, IFormattable, IEquatable<Taskas2D>, IComparable<Taskas2D>, IDisposable
    {
        public double X { get; set; }
        public double Y { get; set; }

        public int CompareTo(Taskas2D other)
        {
            if(Math.Sqrt(X*X+Y*Y) > Math.Sqrt(other.X * other.X + other.Y * other.Y))
            {
                return -1;
            }
            if(Math.Sqrt(X * X + Y * Y) < Math.Sqrt(other.X * other.X + other.Y * other.Y))
            {
                return 1;
            }
            return 0;
        }

        public void Dispose()
        {
            X = 0;
            Y = 0;
        }

        public bool Equals(Taskas2D other)
        {
            if (X != other.X)
            {
                return false;
            }

            if (Y != other.Y)
            {
                return false;
            }
            return true;
        }

        public void Spausdinti()
        {
            Console.WriteLine(this);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return $"X {X} Y {Y}";
        }

        public override string ToString()
        {
            return $"X {X} Y {Y}";
        }
    }

    public class Tiese2D : ITiese
    {
        public ITaskas PradziosTaskas { get; set; }
        public ITaskas PabaigosTaskas { get; set; }
        private double K { get; }
        private double B { get; }

        public Tiese2D(Taskas2D start, Taskas2D end)
        {
            PradziosTaskas = start;
            PabaigosTaskas = end;
            
            K = (end.Y - start.Y) /(end.X-start.X);
            B = start.Y - K * start.X;
            
        }

        public bool ArTaskasTieseje(ITaskas t)
        {
            if(t.X*K+B == t.Y)
            {
                return true;
            }
            return false;
        }
    }
}
