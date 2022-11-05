namespace Aula7.Entities {
    public class Conta {
        private double _saldo;
        
        // Contructors
        public Conta() {
            _saldo = 0;
        }
        public Conta(double saldo) {
            _saldo = saldo;
        }

        // Getters and Setters
        public double getSaldo() {
            return _saldo;
        }

        // Methods
        public virtual void Deposit(double amount) {
            _saldo += amount;
        }

        public void Withdraw(double amount) {
            _saldo -= amount;
        }

        public virtual void Update(double tax) {
            _saldo += _saldo * tax;
        }

    }
}
