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
    public partial class frmimc : Form
    {
        public frmimc()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;
            string classe;

            altura = Convert.ToDouble(txtaltura.Text);
            peso = Convert.ToDouble(txtpeso.Text);
            classe = txtresul.Text;
            imc = peso / (altura * altura);

            if (imc < 17)
                classe = "Magreza severa";
            else if (imc >= 17 && imc < 18.5)
                classe = "Magreza Leve";
            else if (imc >= 18.5 && imc < 25)
                classe = "Peso normal";
            else if (imc >= 25 && imc < 30)
                classe = "Sobrepeso";
            else if (imc >= 30 && imc < 35)
                classe = "Obesidade classe 1";
            else if (imc >= 35 && imc < 40)
                classe = "Obesidade classe 2";
            else if (imc >= 40)
                classe = "Obesidade classe 3";

            txtresul.Text = classe;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu(); ;
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtaltura.Focus();
            txtpeso.Clear();
            txtresul.Clear();
        }

        private void frmimc_Load(object sender, EventArgs e)
        {

        }
    }
}
