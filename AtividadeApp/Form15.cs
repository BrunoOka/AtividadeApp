using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeApp
{
    public partial class frmfc : Form
    {
        public frmfc()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double f, i;
            for (i = 10; i <= 100; i = i + 10)
            {
                f = (i * 9 / 5) + 32;
                txtfc.Text = String.Format(txtfc.Text + "\n" + f.ToString() + Environment.NewLine);
            }
        }

        private void btnw_Click(object sender, EventArgs e)
        {
            double f, i;
            i = 10;
            while (i <= 100)
            {
                f = (i * 9 / 5) + 32;
                i = i + 10;
                txtfc.Text = String.Format(txtfc.Text + "\n" + f.ToString() + Environment.NewLine);
            }
        }

        private void btndw_Click(object sender, EventArgs e)
        {
            double f, i;
            i = 10;
            do
            {
                f = (i * 9 / 5) + 32;
                i = i + 10;
                txtfc.Text = String.Format(txtfc.Text + "\n" + f.ToString() + Environment.NewLine);
            }
            while (i <= 100);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtfc.Clear();
            txtfc.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu(); ;
            menu.Show();
        }
    }
}
