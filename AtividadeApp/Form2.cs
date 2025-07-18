﻿using System;
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
    }
}