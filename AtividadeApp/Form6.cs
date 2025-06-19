using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeApp
{
    public partial class frmcircunferencia : Form
    {
        public frmcircunferencia()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double raio, area;
            raio = Convert.ToDouble(txtraio.Text);

            area = Math.PI * Math.Pow(raio, 2);
            txtarea.Text = area.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtarea.Clear();
            txtraio.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
