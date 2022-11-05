namespace Aula7.Entities {
    public class ContaCorrente : Conta {
        // Contructors
        public ContaCorrente() : base() { }
        public ContaCorrente(double saldo) : base(saldo) { }

        public override void Update(double tax) {
            base.Update(tax*2);
        }
        public override void Deposit(double amount) {
            base.Deposit(amount+0.1);
        }

    }
}
