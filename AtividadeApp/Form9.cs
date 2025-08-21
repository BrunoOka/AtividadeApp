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
    public partial class frmrtj : Form
    {
        public frmrtj()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double popular, geral, arquibancada, cadeiras, totpubl, rdp = 0, rdg = 0, rda = 0, rdc = 0, rendatot;

            totpubl = Convert.ToDouble(txttotpub.Text);

            // Cálculo da quantidade de ingressos por tipo

            popular = totpubl * 0.10;
            geral = totpubl * 0.50;
            arquibancada = totpubl * 0.30;
            cadeiras = totpubl * 0.10;

            if (popular > 0)
                rdp = popular * 5;

            if (geral > 0)
                rdg = geral * 10;

            if (arquibancada > 0)
                rda = arquibancada * 20;

            if (cadeiras > 0)
                rdc = cadeiras * 30;

            //Cálculo da renda total

            rendatot = rdp + rdg + rda + rdc;

            txtrt.Text = rendatot.ToString();
        }
    }
}
