namespace Aula7.Entities {
    public abstract class Conta {
        public double Saldo { get; private protected set; }
        
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

        public abstract void Update(double tax);

    }
}
