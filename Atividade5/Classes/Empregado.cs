using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasse
{
    abstract class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula
        {
            get { return matricula;  }
            set { matricula = value; }
        }

        public string NomeEmpregado //propriedade
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        //metodos
        public string VerificaHome()
        {
            if (homeOffice == 'S' || homeOffice == 's')
                return "Empregado Trabalha HomeOffice";
            else
                return "Empregado Não Trabalha HomeOffice";
        }

        public virtual int TempoTrabalho()  // virtual -> pode ser sobrescrito
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);

            return (span.Days);
        }

        public abstract double SalarioBruto(); //não precisa implementar
    }
}
