using CalculaJurosService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJurosService.Model
{
    public class Financiamento: IFinanciamento, IModelBase
    {
        public int Id { get; set; }
        public double ValorInicial { get; set; }
        public double ValorFinal { get; set; }
        public double Juros { get; set; }
        public int Periodo { get; set; }

        public double GetValorFinal()
        {
            var parc = ValorInicial * (Math.Pow((1 + Juros), Periodo) * Juros) / (Math.Pow((1 + Juros), Periodo) - 1);
            var valTotal = Math.Round((parc * Periodo), 2);
            return valTotal;
        }
   

    }
}
