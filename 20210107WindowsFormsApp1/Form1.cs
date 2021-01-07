using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210107WindowsFormsApp1
{
    public partial class pvzForm : Form
    {
        public pvzForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void uzdarymoMygtukas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(((TextBox)sender).Text);
        }
    }
}
