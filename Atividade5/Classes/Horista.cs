using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasse
{
    class Horista : Empregado 
    {
        // propriedade
        public double SalarioHora { get; set; }
        public double NumeroHora { get; set; }
        public int DiasFalta { get; set; }

        // sobrescrever metodo
        public override double SalarioBruto()
        {
            return (SalarioHora * NumeroHora)-(NumeroHora * DiasFalta);
        }

        public override int TempoTrabalho()
        {
            // o metodo retorna um tipo de span
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days - DiasFalta);
        }
    }
}
