using Aula7.Entities;

class Program {
    static void Main(string[] args) {
        Conta conta0 = new ContaCorrente(1250);
        Conta conta1 = new ContaCorrente(2100);
        Conta conta2 = new ContaCorrente(100);
        Conta conta3 = new ContaCorrente(3280);
        Conta conta4 = new ContaCorrente(1468);
        Conta conta5 = new ContaPoupanca(1260);
        Conta conta6 = new ContaPoupanca(260);
        Conta conta7 = new ContaPoupanca(60);
        Conta conta8 = new ContaPoupanca(12605);
        Conta conta9 = new ContaPoupanca(5600);

        Bank bank = new Bank();
        bank.Adiciona(conta0);
        bank.Adiciona(conta1);
        bank.Adiciona(conta2);
        bank.Adiciona(conta3);
        bank.Adiciona(conta4);
        bank.Adiciona(conta5);
        bank.Adiciona(conta6);
        bank.Adiciona(conta7);
        bank.Adiciona(conta8);
        bank.Adiciona(conta9);

        Updater.UpdateSelic(0.13);

        foreach(Conta conta in bank.GetContas()) {
            Updater.Update(conta);
        }

        Console.WriteLine("Saldo total: {0}", Updater.GetTotalAmount());

    }
}