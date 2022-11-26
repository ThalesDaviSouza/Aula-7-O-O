using Aula7.Interfaces;

namespace Aula7.Entities {
    internal class SeguroDeVida : ITaxable{
        public string? Company { get; private set; }
        public int Tier { get; private set; }
        public double Value { get; private set; }

        public SeguroDeVida(string company, int tier, double value) {
            Company = company;
            Tier = tier;
            Value = value;
        }

        public double CalculateTaxes() {
            return 42;
        }

    }
}
