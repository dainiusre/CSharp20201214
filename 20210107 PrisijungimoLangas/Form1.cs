using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210107_PrisijungimoLangas
{
    public partial class prisijungimoForma : Form
    {
        private List<Vartotojas> Vartotojai { get; set; }
        public prisijungimoForma()
        {
            InitializeComponent();
            UzpildytiVartotojais();
        }

        private void UzpildytiVartotojais()
        {
            Vartotojai = new List<Vartotojas>();
            Vartotojai.Add(new Vartotojas("justas","kopustas"));
            Vartotojai.Add(new Vartotojas("fjjjd", "alalalal"));
            Vartotojai.Add(new Vartotojas("sops", "wpw"));
            Vartotojai.Add(new Vartotojas("sdfo", "djdj"));
            Vartotojai.Add(new Vartotojas("ooooo", "l=lll=="));
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string ivestasVartotojas = userTextBox.Text;
            string ivestasSlaptazodis = passwordTextBox.Text;

            if(statusIndicationLabel.ForeColor == Color.Green)
            {
                MessageBox.Show("Vartotojas jau prisijunges!");
                return;
            }
            foreach (var vartotojas in Vartotojai)
            {
                if(vartotojas.TikrintiVartotoja(ivestasVartotojas, ivestasSlaptazodis))
                {
                    PrijungtiVartotoja(vartotojas);
                    break;
                }
            }
        }

        private void PrijungtiVartotoja(Vartotojas vartotojas)
        {
            statusIndicationLabel.Text = "prisijungta";
            statusIndicationLabel.ForeColor = Color.Green;
            loggedInUserIndicationLbl.Text = vartotojas.Vardas;
            userTextBox.Clear();
            passwordTextBox.Text = "";
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if(loggedInUserIndicationLbl.Text != "")
            {
                DialogResult rezultatas = MessageBox.Show($"Ar tikrai norite atsijungti nuo {loggedInUserIndicationLbl.Text} paskyros?", "Atsijungimas", MessageBoxButtons.YesNo);
                if(rezultatas == DialogResult.Yes)
                {
                    statusIndicationLabel.Text = "neprisijungta";
                    statusIndicationLabel.ForeColor = Color.Red;
                    loggedInUserIndicationLbl.Text = "";
                }
            }
        }

        private void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.UseSystemPasswordChar = true;
        }

        private void passwordTextBox_MouseEnter(object sender, EventArgs e)
        {
            if(sender is TextBox)
            {
                TextBox txt = (TextBox)sender;
                txt.UseSystemPasswordChar = false;
            }
        }
    
    }

    public class Vartotojas
    {
        public string Vardas { get; }
        private string Slaptazodis { get; }

        public Vartotojas(string vardas, string slaptazodis)
        {
            Vardas = vardas;
            Slaptazodis = slaptazodis;
        }
        public bool TikrintiVartotoja(string username, string password)
        {
            if (username != Vardas)
            {
                return false;
            }
            if(password != Slaptazodis)
            {
                return false;
            }
            return true;
        }
    }
}
