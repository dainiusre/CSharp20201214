using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210111_absrakciosKlasesPVz
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new B();
        }
    }

    abstract class A
    {
        public int T;
        public abstract void Metodas();

        public void KviestiDaugVeiksmu()
        {
            Metodas();
            Console.WriteLine("Standartinis veiksmas");
        }
    }

    class B : A 
    {
        public override void Metodas()
        {
            Console.WriteLine("Veiksmas");
        }
    }

}
