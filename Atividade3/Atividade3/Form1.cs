using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtAltura.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;

            if (double.TryParse(txtAltura.Text, out altura) && double.TryParse(txtPeso.Text, out peso))
            {
                if(altura > 0)
                {
                    imc = peso / Math.Pow(altura, 2);

                    if (imc < 18.5)
                    {
                        txtIMC.Text = imc.ToString("N1") + " - IMC MAGREZA";
                    }
                    else if (imc >= 18.5 && imc <= 24.9)
                    {
                        txtIMC.Text = imc.ToString("N1") + " - IMC NORMAL";
                    }
                    else if (imc >= 25 && imc <= 29.9)
                    {
                        txtIMC.Text = imc.ToString("N1") + " - IMC SOBREPESO";
                    }
                    else if (imc >= 30 && imc <= 40)
                    {
                        txtIMC.Text = imc.ToString("N1") + " - IMC OBESIDADE";
                    }
                    else
                        txtIMC.Text = imc.ToString("N1") + " - IMC OBESIDADE GRAVE";
                }
                else
                {
                    MessageBox.Show("Altura não pode igual a zero!");
                    txtAltura.Clear();
                    txtAltura.Focus();
                }

            }
            else
            {
                MessageBox.Show("Digite apenas números");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
