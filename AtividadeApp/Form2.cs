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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();

        }

        private void tsmicf_Click(object sender, EventArgs e)
        {
            Hide();
            frmconversor conversor = new frmconversor();
            conversor.Show();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmidlg_Click(object sender, EventArgs e)
        {
            Hide();
            frmdl dl = new frmdl();
            dl.Show();
        }

        private void tsmisq3n_Click(object sender, EventArgs e)
        {
            Hide();
            frmsq3n sq3n = new frmsq3n();
            sq3n.Show();
        }

        private void tsmidpr_Click(object sender, EventArgs e)
        {
            Hide();
            frmrealdolar realdolar = new frmrealdolar();
            realdolar.Show();

        }

        private void tmsiarea_Click(object sender, EventArgs e)
        {
            Hide();
            frmcircunferencia circunferencia = new frmcircunferencia();
            circunferencia.Show();
        }

        private void tsmimedia_Click(object sender, EventArgs e)
        {
            Hide();
            frmmedia media = new frmmedia();
            media.Show();
        }

        private void tsmiar_Click(object sender, EventArgs e)
        {
            Hide();
            frmretangulo retangulo = new frmretangulo();
            retangulo.Show();
        }

        private void tsmirtj_Click(object sender, EventArgs e)
        {
            Hide();
            frmrtj rtj = new frmrtj();
            rtj.Show();
        }

        private void tsmicvl_Click(object sender, EventArgs e)
        {
            Hide();
            frmcvl cvl = new frmcvl();
            cvl.Show();
        }

        private void tsmiabono_Click(object sender, EventArgs e)
        {
            Hide();
            frmabono abono = new frmabono();
            abono.Show();
        }

        private void tsmiccp_Click(object sender, EventArgs e)
        {
            Hide();
            frmccp ccp = new frmccp();
            ccp.Show();
        }

        private void tsmiimc_Click(object sender, EventArgs e)
        {
            Hide();
            frmimc imc = new frmimc();
            imc.Show();
        }

        private void tsmitabuada_Click(object sender, EventArgs e)
        {
            Hide();
            frmtabuada tabuada = new frmtabuada();
            tabuada.Show();
        }

        private void tsmifc_Click(object sender, EventArgs e)
        {
            Hide();
            frmfc fc = new frmfc();
            fc.Show();
        }
    }
}