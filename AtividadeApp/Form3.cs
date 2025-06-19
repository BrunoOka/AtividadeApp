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
    public partial class frmdl : Form
    {
        public frmdl()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double v, t, d, lg;
            v = Convert.ToDouble(txtvelo.Text);
            t = Convert.ToDouble(txttemp.Text);
            d = t * v;
            txtdist.Text = d.ToString();
            lg = d / 12;
            txtlitros.Text = lg.ToString();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdist.Clear();
            txtlitros.Clear();
            txttemp.Clear();
            txtvelo.Clear();
            txtvelo.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            Hide();
            menu.Show();
        }
    }
}
