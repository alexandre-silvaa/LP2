using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtLadoA.Focus();
        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            double ladoA, laboB, ladoC;

            if (double.TryParse(txtLadoA.Text, out ladoA) && double.TryParse(txtLadoB.Text, out laboB) &&
                double.TryParse(txtLadoC.Text, out ladoC))
            {
                if (ladoA < (laboB + ladoC) && ladoA > Math.Abs(laboB - ladoC) &&
                    laboB < (ladoA + ladoC) && laboB > Math.Abs(ladoA - ladoC) &&
                    ladoC < (ladoA + laboB) && ladoC > Math.Abs(ladoA - laboB))
                {
                    if (ladoA == laboB && laboB == ladoC)
                    {
                        txtTipo.Text = "Triângulo Equilátero";
                    }
                    else if (ladoA == laboB || laboB == ladoC || ladoC == ladoA)
                    {
                        txtTipo.Text = "Triângulo Isósceles";
                    }
                    else
                    {
                        txtTipo.Text = "Triângulo Escaleno";
                    }
                }
                else
                {
                    MessageBox.Show("Números inválidos para formar um triângulo");

                    txtLadoA.Clear();
                    txtLadoB.Clear();
                    txtLadoC.Clear();
          
                    txtLadoA.Focus();
                }
               
            }
            else
            {
                MessageBox.Show("Insira apenas números");

                txtLadoA.Clear();
                txtLadoB.Clear();
                txtLadoC.Clear();

                txtLadoA.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtTipo.Clear();

            txtLadoA.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
