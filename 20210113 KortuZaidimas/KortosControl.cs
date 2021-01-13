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
    public partial class KortosControl : UserControl
    {
        public KortosControl(Korta korta)
        {
            InitializeComponent();
            ZymejimasLbl.Text = KonvertuotiISimbolius(korta.Zymejimas) + " " + korta.Reiksme;
            ZymejimasLbl.ForeColor = korta.Spalva;
        }

        private string KonvertuotiISimbolius(string zymejimas)
        {
            if(zymejimas == "Sirdys")
            {
                return "♥";
            }
            else if(zymejimas == "Pikai")
            {
                return "♠";
            }
            else if(zymejimas == "Bugnai")
            {
                return "♦";
            }
            else if(zymejimas == "Kryziai")
            {
                return "♣";
            }
            return "";
        }
    }
}
