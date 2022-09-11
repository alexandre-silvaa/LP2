using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtNum1.Focus();
            txtResultado.ReadOnly = true;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = double.Parse(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resultado = (num1 + num2);

            txtResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = double.Parse(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resultado = (num1 - num2);

            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;

            num1 = double.Parse(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            if (num2 == 0)
            {
                MessageBox.Show("Impossível realizar divisão por 0");
            }
            else
            {
                resultado = (num1 / num2);
            }

            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = double.Parse(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resultado = (num1 * num2);

            txtResultado.Text = resultado.ToString();
        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {
            double num1;

            if (!double.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Digite apenas números");
                txtNum1.Focus();
            }
        }

        private void txtNum2_Validated(object sender, EventArgs e)
        {
            double num2;

            if (!double.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Digite apenas números");
                txtNum2.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
