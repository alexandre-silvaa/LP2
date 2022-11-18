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

namespace Pmatrizes.Forms
{
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[4];
            int[] letras = new int[4];

            for (int i = 0; i < 4; i++)
            {
                nomes[i] = Interaction.InputBox("Digite o " + (i + 1) + "º nome:",
                    "Entrada dos Nomes");

                letras[i] = nomes[i].Replace(" ", "").Length;

                lbxNomes.Items.Add("O nome: " + nomes[i] + " tem " + letras[i] + " caracteres" + "\n");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbxNomes.Items.Clear();
        }
    }
}
