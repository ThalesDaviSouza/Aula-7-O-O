namespace Aula7.Entities {
    public class Conta {
        public double Saldo { get; private set; }
        
        // Contructors
        public Conta() { }
        public Conta(double saldo) {
            Saldo = saldo;
        }

        // Methods
        public virtual void Deposit(double amount) {
            Saldo += amount;
        }

        public void Withdraw(double amount) {
            Saldo -= amount;
        }

        public virtual void Update(double tax) {
            Saldo += Saldo * tax;
        }

    }
}
