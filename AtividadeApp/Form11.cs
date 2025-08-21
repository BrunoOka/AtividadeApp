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
    public partial class frmabono : Form
    {
        public frmabono()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double idade, salario, a = 0, c;
            string nome, sexo;

            idade = Convert.ToDouble(txtidade.Text);
            salario = Convert.ToDouble(txtsalario.Text);
            sexo = txtsexo.Text.ToLower();

            if ((sexo == "m" || sexo == "masculino") && idade >= 30)
                a = 100;
            else if ((sexo == "m" || sexo == "masculino") && idade < 30)
                a = 50;
            else if ((sexo == "f" || sexo == "feminino") && idade >= 30)
                a = 200;
            else if ((sexo == "f" || sexo == "feminino") && idade < 30)
                a = 150;
            c = salario + a;
            txtresult.Text = c.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtsexo.Clear();
            txtidade.Clear();
            txtsalario.Clear();
            txtresult.Clear();
            txtnome.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
