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
    public partial class frmmedia : Form
    {
        public frmmedia()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, resultado;
            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);
            resultado = (nota1 * 2) + (nota2 * 3) + (nota3 * 5) / 10;
            txtresultado.Text = resultado.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtresultado.Clear();
            txtnota1.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
