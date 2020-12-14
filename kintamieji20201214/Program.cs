using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kintamieji20201214
{
    class Program
    {
        static void Main(string[] args)
        {

            string vardas = "Justas";
            string pavarde = "Puodzius";
            int amzius = 23;
            double ugis = 1.79;
            float svoris = 72.3f;
            string aukstojiMokykla = "KTU";
            string AGKodas = "ERB-62";
            int kursas = 4;
            string studijuPav = "Robotika";
            int kredituSk = 90;

            //string veiksmas = "Nupirkti pieno";

            //Console.WriteLine("Justo Programa:");
            //Console.WriteLine("1. " + "Pavedzioti suni");
            //Console.Write("2" + ". " + veiksmas + "\n");
            //Console.WriteLine("3. Eiti paprogramuot");
            //Console.ReadLine();

            //Console.WriteLine("STUDENTO DUOMENYS");
            //Console.WriteLine($"{vardas} {pavarde} ({amzius}m.)");
            //Console.WriteLine("Jo ugis yra {0} m., jo svoris {1} kg. jis zino, kad sveria {1} ir zino, kad jo ugis {0}", ugis, svoris);
            //Console.WriteLine("Jis mokosi auksotjoje mokykloje: " + aukstojiMokykla + " (" + studijuPav + ")");
            //Console.WriteLine("Jis siuo metu yra baiges {0} ir mokosi {1}", kursas-1, kursas);
            //Console.ReadLine();

            Console.WriteLine("Iveskite kazka:");
            string ivestis = Console.ReadLine();
            Console.WriteLine($"Ivede: {ivestis}");
            Console.WriteLine("Iveskite sveika skaiciu: ");

            int sk;
            if(int.TryParse(ivestis, out sk))
            {

            }
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivestas skaicius plius vienas " + (sk+1));
            Console.ReadLine();
        }
    }
}
