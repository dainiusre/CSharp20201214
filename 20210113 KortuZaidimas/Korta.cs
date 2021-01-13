using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210113_KortuZaidimas
{
    public class Korta
    {
        public Color Spalva { get; }
        public string Reiksme { get; }
        public string Zymejimas { get; }

        public Korta(string reiksme, string zymejimas)
        {
            Reiksme = reiksme;
            Zymejimas = zymejimas;
            if(Zymejimas == "Kryziai" || Zymejimas == "Pikai")
            {
                Spalva = Color.Black;
            }
            else if(Zymejimas == "Sirdys" || Zymejimas == "Bugnai")
            {
                Spalva = Color.Red;
            }
        }
        public Korta(int reiksme, string zymejimas)
        {
            Reiksme = KonvertuotiIsSkaiciausIReiksme(reiksme);
            Zymejimas = zymejimas;
            if (Zymejimas == "Kryziai" || Zymejimas == "Pikai")
            {
                Spalva = Color.Black;
            }
            else if (Zymejimas == "Sirdys" || Zymejimas == "Bugnai")
            {
                Spalva = Color.Red;
            }
        }

        private string KonvertuotiIsSkaiciausIReiksme(int sk)
        {
            if(sk == 1)
            {
                return "A";
            }
            else if(sk == 11)
            {
                return "J";
            }
            else if (sk == 12)
            {
                return "Q";
            }
            else if (sk == 13)
            {
                return "K";
            }
            else
            {
                return sk.ToString();
            }
        }

        public static List<Korta> SukurtiKalade()
        {
            List<Korta> kortuKalade = new List<Korta>();
            string[] zenklai = { "Kryziai", "Sirdys", "Bugnai", "Pikai" };
            foreach(var zenklas in zenklai)
            {
                for(var i = 1; i< 14; i++)
                {
                    Korta korta = new Korta(i, zenklas);
                    kortuKalade.Add(korta);
                }
            }

            kortuKalade.Add(new Korta("JK", "Pikai"));
            kortuKalade.Add(new Korta("JK", "Sirdys"));

            return kortuKalade;
        }

        public static List<Korta> IsmaisytiKortuKalade(List<Korta> kalade, Random rng)
        {
            List<Korta> IsmaisytaKalade = new List<Korta>();
            while(kalade.Any())
            {
                int indexas =  rng.Next(0, kalade.Count);
                IsmaisytaKalade.Add(kalade[indexas]);
                kalade.RemoveAt(indexas);
            }
            return IsmaisytaKalade;
        }

        public static List<List<Korta>> IsdalintiKortas(int zaidejuSk, List<Korta> kalade, int kortuSkRankoje)
        {
            List<List<Korta>> isdalintosKortos = new List<List<Korta>>();

            for(var i = 0; i< zaidejuSk; i++)
            {              
                isdalintosKortos.Add(new List<Korta>());
            }

            for(var j = 0; j<kortuSkRankoje; j++)
            {
                for (var i = 0; i < zaidejuSk; i++)
                {                    
                    isdalintosKortos[i].Add(kalade.First());
                    kalade.Remove(kalade.First());
                }
            }
            return isdalintosKortos;
        }


    }
}
