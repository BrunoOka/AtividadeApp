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
    public partial class frmtabuada : Form
    {
        public frmtabuada()
        {
            InitializeComponent();
        }

        private void btnw_Click(object sender, EventArgs e)
        {
            int num, i, calc;
            i = 1;
            calc = 0;
            num = Convert.ToInt32(txtnum.Text);
            while (num <= 9 && num >= 1 && i <= 10)
            {
                calc = num * i;
                i++;
                txtresult.Text = String.Format(txtresult.Text + "\n" + calc.ToString() + Environment.NewLine);
            }
        }

        private void btndw_Click(object sender, EventArgs e)
        {
            int num, i, calc;
            i = 1;
            calc = 0;
            num = Convert.ToInt32(txtnum.Text);
            if (num < 1 || num > 9)
            {
                return;
            }

            do
            {
                calc = num * i;
                i++;
                txtresult.Text = String.Format(txtresult.Text + "\n" + calc.ToString() + Environment.NewLine);
            }
            while (i <= 10);
        }

        private void btnf_Click(object sender, EventArgs e)
        {
            int num, i, calc;
            calc = 0;
            num = Convert.ToInt32(txtnum.Text);
            if (num < 1 || num > 9)
            {
                return;
            }
            for (i = 1; i <= 10; i++)
            {
                calc = num * i;
                txtresult.Text = String.Format(txtresult.Text + "\n" + calc.ToString() + Environment.NewLine);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
            txtnum.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu(); ;
            menu.Show();
        }
    }
}
