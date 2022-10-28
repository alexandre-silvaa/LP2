using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtNome.Focus();
        }

        private void btnValida_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double salarioBruto = 0;
            double salarioLiquido = 0;
            double salarioFamilia = 0;
            double descontoINSS = 0;
            double descontoIRPF = 0;
            double qtdFilhos = 0;


            //Verifica NOME
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Nome não pode ser vazio");
                lblDados.Text = "Dados";
                txtNome.Focus();
            }

            else if (txtNome.Text != string.Empty)
            {
                //Valida Salario
                if (double.TryParse(mskbxSalario.Text, out salarioBruto) &&
                    double.TryParse(nudQtdFilho.Text, out qtdFilhos))
                {
                    if (salarioBruto == 0)
                    {
                        MessageBox.Show("Salário deve ser maior que zero");

                        mskbxSalario.Clear();
                        mskbxSalario.Focus();
                    }
                    else if (salarioBruto > 0)
                    {
                        //Caixa de dados
                        lblDados.Text = "Os descontos de salário " + (rbtnFeminino.Checked ? " da Sra. " : " do Sr. ") + nome + " que é " + (rbtnCasado.Checked ? " casado " : " solteiro ") + " e tem " + qtdFilhos + " filho(s)";

                        //Desconto INSS
                        if (salarioBruto <= 800.47)
                        {
                            txtAliquotaINSS.Text = "7,65%";
                            descontoINSS = 0.0765 * salarioBruto;
                            txtDescontoINSS.Text = descontoINSS.ToString("N2");
                        }
                        else if (salarioBruto >= 800.48 && salarioBruto <= 1050.00)
                        {
                            txtAliquotaINSS.Text = "8,65%";
                            descontoINSS = 0.0865 * salarioBruto;
                            txtDescontoINSS.Text = descontoINSS.ToString("N2");
                        }
                        else if (salarioBruto >= 1050.01 && salarioBruto <= 1400.77)
                        {
                            txtAliquotaINSS.Text = "9,00%";
                            descontoINSS = 0.09 * salarioBruto;
                            txtDescontoINSS.Text = descontoINSS.ToString("N2");
                        }
                        else if (salarioBruto >= 1400.78 && salarioBruto <= 2801.56)
                        {
                            txtAliquotaINSS.Text = "11,00%";
                            descontoINSS = 0.11 * salarioBruto;
                            txtDescontoINSS.Text = descontoINSS.ToString("N2");
                        }
                        else if (salarioBruto > 2801.56)
                        {
                            txtAliquotaINSS.Text = "Teto";
                            descontoINSS = 308.17;
                            txtDescontoINSS.Text = descontoINSS.ToString("N2");
                        }

                        //Desconto IRPF
                        if (salarioBruto <= 1257.12)
                        {
                            txtAliquotaIRPF.Text = "Isento";
                            txtDescontoIRPF.Text = descontoIRPF.ToString("N2");
                        }
                        else if (salarioBruto >= 1257.13 && salarioBruto <= 2512.08)
                        {
                            txtAliquotaIRPF.Text = "15,00%";
                            descontoIRPF = 0.15 * salarioBruto;
                            txtDescontoIRPF.Text = descontoIRPF.ToString("N2");
                        }
                        else if (salarioBruto > 2512.08)
                        {
                            txtAliquotaIRPF.Text = "27.5%";
                            descontoIRPF = 0.275 * salarioBruto;
                            txtDescontoIRPF.Text = descontoIRPF.ToString("N2");
                        }

                        //Salario Familia
                        if (qtdFilhos > 0)
                        {
                            if (salarioBruto <= 435.52)
                            {
                                salarioFamilia = qtdFilhos * 22.33;
                                txtSalarioFamilia.Text = salarioFamilia.ToString("N2");
                            }
                            else if (salarioFamilia >= 435.53 && salarioFamilia <= 654.61)
                            {
                                salarioFamilia = qtdFilhos * 15.74;
                                txtSalarioFamilia.Text = salarioFamilia.ToString("N2");
                            }
                            else if (salarioFamilia > 654.61)
                            {
                                salarioFamilia = 0;
                                txtSalarioFamilia.Text = salarioFamilia.ToString("N2");
                            }
                        }
                        else
                        {
                            salarioFamilia = 0;
                            txtSalarioFamilia.Text = salarioFamilia.ToString("N2");
                        }

                        //Salario Liquido
                        salarioLiquido = salarioBruto - (descontoINSS + descontoIRPF) + salarioFamilia;
                        txtSalarioLiquido.Text = salarioLiquido.ToString("N2");
                    }
                }
                else
                {
                    MessageBox.Show("Salário não pode ser vazio e digite somente números");
                    mskbxSalario.Clear();
                    mskbxSalario.Focus();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskbxSalario.Clear();
            nudQtdFilho.ResetText();
            rbtnCasado.Checked = false;
            rbtnFeminino.Checked = false;
            rbtnMasculino.Checked = true;
            txtAliquotaINSS.Clear();
            txtAliquotaIRPF.Clear();
            txtDescontoINSS.Clear();
            txtDescontoIRPF.Clear();
            txtSalarioFamilia.Clear();
            txtSalarioLiquido.Clear();
            lblDados.Text = "";

            txtNome.Focus();

        }
    }
}
