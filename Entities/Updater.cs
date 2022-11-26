using System.Text;

namespace Aula7.Entities {
    public class Updater {
        public static double TotalAmount { get; private set; } = 0;
        public static double Selic { get; private set; } = 0;

        public static void UpdateSelic(double selic) {
            Updater.Selic = selic;
        }

        public static double GetTotalAmount() {
            return Updater.TotalAmount;
        }

        public static void Update(Conta conta) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Saldo anterior [R$ {conta.Saldo.ToString("F2")}]");
            conta.Update(Selic);
            sb.AppendLine($"Saldo final [R$ {conta.Saldo.ToString("F2")}]");
            Console.WriteLine(sb.ToString());
            Updater.TotalAmount += conta.Saldo;
        }
    }
}
