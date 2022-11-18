using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmetodos.Forms
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            int num1, num2, sorteado;
            Random sorteio = new Random();

            if (int.TryParse(txtNum1.Text, out num1) && int.TryParse(txtNum2.Text, out num2))
            {
                sorteado = sorteio.Next(num1, num2);

                MessageBox.Show("Sorteado: " + sorteado);
            }
            else
            {
                MessageBox.Show("Escreva um número válido!");
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();
            }
        }
    }
}
