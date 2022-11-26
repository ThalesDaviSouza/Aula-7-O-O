namespace Aula7.Entities {
    public class ContaPoupanca : Conta{
        // Contructors
        public ContaPoupanca() : base() { }
        public ContaPoupanca(double saldo) : base(saldo) { }

        
        public override void Update(double tax) {
            this.Saldo +=  Saldo * tax * 3;
        }


    }
}
