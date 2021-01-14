using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210113_KortuZaidimas
{
    public partial class KortuStalas : Form
    {
        public KortuStalas()
        {
            InitializeComponent();

            Zaidimas zaidimas = new Zaidimas(2);
            
            foreach(var korta in zaidimas.ZaidejuRankos[0])
            {
                var kortosKontrole = new KortosControl(korta);
                kortosKontrole.Click += KortosKontrole_Click;
                Zaidejas1RankaPanel.Controls.Add(kortosKontrole);
            }
            foreach (var korta in zaidimas.ZaidejuRankos[1])
            {
                var kortosKontrole = new KortosControl(korta);
                kortosKontrole.Click += KortosKontrole_Click;
                Zaidejas2RankaPanel.Controls.Add(kortosKontrole);
            }
        }

        private void KortosKontrole_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void KortosKontrole_Click(object sender, EventArgs e)
        {            
            var kortosKontrole = (KortosControl)sender;
            ZaidimoZonaPanel.Controls.Clear();
            //kortosKontrole.Parent.Controls.Remove(kortosKontrole);
            ZaidimoZonaPanel.Controls.Add(kortosKontrole);
            kortosKontrole.Location = new Point(0, 0);
        }
    }
}
