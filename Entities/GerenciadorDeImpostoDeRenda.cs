using System.Collections.Generic;
using Aula7.Interfaces;

namespace Aula7.Entities {
    internal class GerenciadorDeImpostoDeRenda {
        public List<ITaxable> Taxables = new List<ITaxable>();

        public GerenciadorDeImpostoDeRenda(params ITaxable[] taxables) {
            foreach (ITaxable taxable in taxables) {
                Taxables.Add(taxable);
            }
        }

        public double TotalTaxes() {
            double total = 0;
            foreach (ITaxable taxable in Taxables) {
                total += taxable.CalculateTaxes();
            }
            return total;
        }
    
    }
}
