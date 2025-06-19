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
    public partial class frmrealdolar : Form
    {
        public frmrealdolar()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double reais, dolares, resultado;
            reais = Convert.ToDouble(txtvalorreais.Text);
            dolares = Convert.ToDouble(txtcambio.Text);

            resultado = dolares / reais;

            txtvalordolares.Text = resultado.ToString();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtvalordolares.Clear();
            txtcambio.Clear();
            txtvalorreais.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
