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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnQtdNum_Click(object sender, EventArgs e)
        {
            int cont = 0, tam = rtxtTexto.Text.Length;

            if (rtxtTexto.Text == "")
                MessageBox.Show("Não há nada escrito!");
            else
            {
                for (var i = 0; i < tam; i++)
                {
                    if (Char.IsNumber(rtxtTexto.Text, i))
                        cont++;
                }

                MessageBox.Show("Tem " + cont + " caracteres numéricos no texto");
            }
        }

        private void btnLocalizaEspaco_Click(object sender, EventArgs e)
        {
            int tamanho = 0;

            if (rtxtTexto.Text == "")
                MessageBox.Show("Não há nada escrito!");
            else
            {
                while (tamanho != rtxtTexto.Text.Length)
                {
                    if (Char.IsWhiteSpace(rtxtTexto.Text, tamanho))
                    {
                        MessageBox.Show("Caracter branco localizado! Posição: " + (tamanho + 1));

                        tamanho = rtxtTexto.Text.Length;
                    }
                    else
                        tamanho++;
                }
            }
        }

        private void btnQtdAlfabetico_Click(object sender, EventArgs e)
        {
            string texto = rtxtTexto.Text;
            int cont = 0;

            if (rtxtTexto.Text == "")
                MessageBox.Show("Não há nada escrito!");
            else
            {
                foreach (var caracter in texto)
                {
                    if (Char.IsLetter(caracter))
                        cont++;
                }

                MessageBox.Show("Tem " + cont + " caracteres alfabéticos no texto");
            }
        }
    }
}
