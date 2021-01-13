using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210113_KortuZaidimas
{
    class Zaidimas
    {
        private static Random Rng = new Random();
        public List<Korta> ZaidimoKalade { get; set; }
        private int ZaidejuSkaicius { get; }
        public List<List<Korta>> ZaidejuRankos { get; set; }
        public Zaidimas(int zaidejuSk)
        {
            ZaidimoKalade = Korta.SukurtiKalade();
            if(zaidejuSk<4)
            {
                IsmestiDaliKortu();
            }
            ZaidimoKalade = Korta.IsmaisytiKortuKalade(ZaidimoKalade, Rng);
            ZaidejuRankos = Korta.IsdalintiKortas(zaidejuSk, ZaidimoKalade, 6);
        }

        private void IsmestiDaliKortu()
        {
            int i = 0;
            while(i<ZaidimoKalade.Count)
            {
                var korta = ZaidimoKalade[i];
                int reiksme = 10;
                int.TryParse(korta.Reiksme, out reiksme);

                if (korta.Reiksme == "JK")
                {
                    ZaidimoKalade.RemoveAt(i);
                }                
                else if(reiksme<7)
                {
                    ZaidimoKalade.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
