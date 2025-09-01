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
    public partial class frmccp : Form
    {
        public frmccp()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int codigo;
            string nome, preco;

            codigo = Convert.ToInt16(txtcodigo.Text);

            switch (codigo)
            {
                case 100:
                    nome = "Cachorro-quente";
                    preco = "R$25,00";
                    break;
                case 101:
                    nome = "Bauru";
                    preco = "R$15,00";
                    break;
                case 102:
                    nome = "X-Burguer";
                    preco = "R$35,00";
                    break;
                case 103:
                    nome = "Triplo X-Burguer";
                    preco = "R$47,00";
                    break;
                default:
                    nome = "Produto não cadastrado!";
                    preco = "Preço indisponível";
                    break;
            }
            txtresulnome.Text = nome;
            txtresulpreco.Text = preco;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtcodigo.Focus();
            txtresulnome.Clear();
            txtresulpreco.Clear();
        }
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}

