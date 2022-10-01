using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteClasse.Forms
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();

            txtNome.Focus();
        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            // criar ou instaciar objeto da classe mensalista
            Horista objHorista = new Horista();

            //set
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntradaEmpresa.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioMensal.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHoras.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);
            if (rbtnSim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" +
                            "Nome: " + objHorista.NomeEmpregado + "\n" +
                            "Data Entrada: " +
                            objHorista.DataEntradaEmpresa.ToShortDateString() +
                            "\n" +
                            "Salário Bruto: " + objHorista.SalarioBruto().ToString("N2") +
                            "\n" +
                            "Tempo Empresa (dias): " + objHorista.TempoTrabalho() +
                            '\n' + objHorista.VerificaHome());
        }
    }
}
