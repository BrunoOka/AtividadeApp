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
    public partial class frmretangulo : Form
    {
        public frmretangulo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double b, a, resultado;
            b = Convert.ToDouble(txtbase.Text);
            a = Convert.ToDouble(txtaltura.Text);
            resultado = b * a;
            txtresultado.Text = resultado.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtbase.Clear();
            txtaltura.Clear();
            txtresultado.Clear();
            txtbase.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
