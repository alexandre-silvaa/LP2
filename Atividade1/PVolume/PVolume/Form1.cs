using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtRaio.Focus();
            txtVolume.ReadOnly = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Clear();
            txtAltura.Clear();
            txtVolume.Clear();

            txtRaio.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double volume, raio, altura;

            if(double.TryParse(txtRaio.Text, out raio) &&
                double.TryParse(txtAltura.Text, out altura))
            {
                if((altura <= 0) || (raio <= 0))
                {
                    MessageBox.Show("Altura e Raio devem ser maiores que ZERO");
                    txtRaio.Focus();
                }
                else
                {
                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    txtVolume.Text = volume.ToString("N2");
                }    
            }
            else
            {
                MessageBox.Show("Valores inválidos");
                txtRaio.Focus();
            }
            

        }
    }
}
