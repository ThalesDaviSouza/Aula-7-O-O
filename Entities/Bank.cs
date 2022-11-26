using System.Collections.Generic;

namespace Aula7.Entities {
    public class Bank {
        public List<Conta> Contas { get; private set; } = new List<Conta>();

        public void AdicionaConta(Conta conta) {
            Contas.Add(conta);
        }

        public Conta PegaConta(int id) {
            return Contas.ElementAt(id);
        }

        public int TotalContas() {
            return Contas.Count;
        }
    }
}
