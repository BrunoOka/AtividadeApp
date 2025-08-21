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
    public partial class frmcvl : Form
    {
        public frmcvl()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double l, c;
            l = Convert.ToDouble(txtlivros.Text);
            if(l>10)
            { c = l * 8;
              txtresultado.Text= c.ToString();
            }
            else
            {
              c = l * 12;
              txtresultado.Text = c.ToString();
            }
        }
    }
}
