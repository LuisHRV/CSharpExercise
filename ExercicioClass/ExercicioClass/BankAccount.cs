using System.Globalization;

namespace ExercicioClass {
    internal class BankAccount {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public BankAccount() {
        }
        public BankAccount(int number, string holder) {
            Number = number;
            Holder = holder;
        }
        public BankAccount(int number, string holder, double initialBalance) : this(number, holder) {
            Deposit(initialBalance);
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            Balance -= amount + 5.0;
        }

        public override string ToString() {
            return "Conta: "
                + Number
                + ", Titular: "
                + Holder
                + ", Saldo: $"
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
