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
    public partial class frmsq3n : Form
    {
        public frmsq3n()
        {
            InitializeComponent();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, q, s;
            n1 = Convert.ToDouble(txtn1.Text);
            n2 = Convert.ToDouble(txtn2.Text);
            n3 = Convert.ToDouble(txtn3.Text);
            s = n1 + n2 + n3;
            q = Math.Pow(s, 2);
            txtr.Text = q.ToString();
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
            txtr.Clear();
            txtn1.Focus();
        }

        private void btnv_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            Hide();
            menu.Show();
        }
    }
}
