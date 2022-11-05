namespace Aula7.Entities {
    public class Bank {
        private Conta[] contas = new Conta[0];

        public Conta[] GetContas() {
            return contas;
        }

        public void Adiciona(Conta conta) {
            Conta[] novoVetor = new Conta[contas.Length+1];
            for(int i = 0; i < contas.Length; i++) {
                novoVetor[i] = contas[i];
            }
            novoVetor[novoVetor.Length-1] = conta;
            contas = novoVetor;
        }

        public Conta PegaConta(int id) {
            return contas[id];
        }

        public int TotalContas() {
            return contas.Length;
        }
    }
}
