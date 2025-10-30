using Microsoft.VisualBasic;
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
    public partial class frmar : Form
    {

        public frmar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcw_Click(object sender, EventArgs e)
        {
            int totalComodos = Convert.ToInt32(txtqc.Text);
            int contador = 1;
            double areaTotal = 0;

            while (contador <= totalComodos)
            {
                double largura = Convert.ToDouble(
                    Interaction.InputBox($"Digite a largura do cômodo {contador} (m):", "Largura"));

                double comprimento = Convert.ToDouble(
                    Interaction.InputBox($"Digite o comprimento do cômodo {contador} (m):", "Comprimento"));

                double areaComodo = largura * comprimento;
                areaTotal += areaComodo;
                txtac.Text += $"Cômodo {contador}: {areaComodo:F2} m²{Environment.NewLine}";
                contador++;
            }
            txtar.Text = $"{areaTotal:F2} m²";

        }

        private void btncalcdw_Click(object sender, EventArgs e)
        {
            int totalComodos = Convert.ToInt32(txtqc.Text);
            int contador = 1;
            double areaTotal = 0;


            do
            {
                double largura = Convert.ToDouble(
                    Interaction.InputBox($"Digite a largura do cômodo {contador} (m):", "Largura"));

                double comprimento = Convert.ToDouble(
                    Interaction.InputBox($"Digite o comprimento do cômodo {contador} (m):", "Comprimento"));

                double areaComodo = largura * comprimento;
                areaTotal += areaComodo;
                txtac.Text += $"Cômodo {contador}: = {areaComodo:F2} m²{Environment.NewLine}";
                contador++;
            }
            while (contador <= totalComodos);
            txtar.Text = $"{areaTotal:F2} m²";
        }

        private void frmar_Shown(object sender, EventArgs e)
        {
            txtqc.Focus();
        }

        private void btncalcf_Click(object sender, EventArgs e)
        {
            int totalComodos = Convert.ToInt32(txtqc.Text);
            int contador;
            double areaTotal = 0;
            for(contador=1;contador<=totalComodos;contador++)
            {
                double largura = Convert.ToDouble(
                    Interaction.InputBox($"Digite a largura do cômodo {contador} (m):", "Largura"));
                double comprimento = Convert.ToDouble(
                    Interaction.InputBox($"Digite o comprimento do cômodo {contador} (m):", "Comprimento"));
                double areaComodo = largura * comprimento;
                areaTotal += areaComodo;
                txtac.Text += $"Cômodo {contador}: = {areaComodo:F2} m²{Environment.NewLine}";
            }
            txtar.Text = $"{areaTotal:F2} m²";
        }
    }
}
