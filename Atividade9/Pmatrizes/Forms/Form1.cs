using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Pmatrizes.Forms;

namespace Pmatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInverterVetor_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string aux;
            string saida = "";

            for (int i = 0; i < 20; i++)
            {
                int proximo = i + 1;
                aux = Interaction.InputBox(proximo + "º Número:",
                    "Entrada de Dados");

                if(!int.TryParse(aux , out vetor[i]))
                {
                    MessageBox.Show("Valor inválido!");
                    i--;
                }
                else
                {
                    saida = vetor[i] + "\n" + saida;
                }
            }

            MessageBox.Show(saida);
        }

        private void BtnArmazem_Click(object sender, EventArgs e)
        {
            double[] qtde = new double[10];
            double[] preco = new double[10];
            string aux; ;
            double faturamento = 0;

            for(var i = 0; i < 9; i++)
            {
                aux = Interaction.InputBox("Digite a quantidade da mercadoria " + (i+1),
                    "Entrada das Quantidades");

                if (!double.TryParse(aux, out qtde[i]))
                {
                    MessageBox.Show("Quantidade Inválida!");
                    i--;
                }

                else
                {
                    while (preco[i] <= 0)
                    {
                        aux = Interaction.InputBox("Digite o preço da mercadoria " + (i+1),
                            "Entrada dos preços");

                        if (!double.TryParse(aux, out preco[i]))
                        {
                            MessageBox.Show("Preço inválido");
                        }

                        else
                        {
                            if (preco[i] <= 0)
                            {
                                MessageBox.Show("Preço deve ser maior que zero!");
                            }
                        }
                    }

                    faturamento += qtde[i] * preco[i];
                }
            }

            MessageBox.Show("Faturamento: "+faturamento.ToString("N2"));
        }

        private void BtnTamanhoString_Click(object sender, EventArgs e)
        {
            string[] alunos = {"Viviane", "André", "Hélio", "Denise", "Júnior",
            "Leonardo", "José", "Nelma", "Tobby"};
            Int32 i, total = 0;
            Int32 n = alunos.Length;

            for(i = 0; i < n-1; i++)
            {
                total += alunos[i].Length;
            }

            MessageBox.Show(total.ToString());
            //RESPOSTA FINAL = 46
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            string saida = "";

            lista.Add("Ana");
            lista.Add("André");
            lista.Add("Débora");
            lista.Add("Fátima");
            lista.Add("João");
            lista.Add("Janete");
            lista.Add("Otávio");
            lista.Add("Marcelo");
            lista.Add("Pedro");
            lista.Add("Thais");

            lista.Remove("Otávio");

            foreach (string item in lista)
            {
                saida = item + "\n" + saida;
            }

            MessageBox.Show(saida);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            string[,] notas = new string[20, 3];
            double nota;
            double media;
            string saida = "";

            for (var i = 0; i < 20; i++)
            {
                media = 0;

                for (var j = 0; j < 3; j++)
                {
                    notas[i, j] = Interaction.InputBox("Digite a nota " + (j + 1) + " do aluno(a) " + (i + 1),
                    "Entrada de Notas");

                    if (double.TryParse(notas[i, j], out nota))
                    {
                        if (nota >= 0)
                            media += nota;
                        else
                        {
                            MessageBox.Show("Insira uma nota maior ou igual a zero");
                            j--;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira uma nota válida!");
                        j--;
                    }
                }

                media = media / 3;
                saida = "Aluno " + (i + 1) + ": média: " + media + "\n" + saida;
            }

            MessageBox.Show(saida);
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            frmExercicio6 frm = new frmExercicio6();
            frm.Show();
        }
    }
}
