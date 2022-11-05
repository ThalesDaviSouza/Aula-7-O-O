using System.Text;

namespace Aula7.Entities {
    public class Updater {
        private static double _totalAmount = 0;
        private static double _selic = 0;

        public static void UpdateSelic(double selic) {
            Updater._selic = selic;
        }

        public static double GetTotalAmount() {
            return Updater._totalAmount;
        }

        public static void Update(Conta conta) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Saldo anterior [R$ {conta.getSaldo().ToString("F2")}]");
            conta.Update(_selic);
            sb.AppendLine($"Saldo final [R$ {conta.getSaldo().ToString("F2")}]");
            Console.WriteLine(sb.ToString());
            Updater._totalAmount += conta.getSaldo();
        }
    }
}
