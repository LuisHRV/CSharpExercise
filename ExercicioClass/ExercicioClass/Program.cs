using System.Globalization;

namespace ExercicioClass {
    internal class Program {
        static void Main(string[] args) {

            BankAccount account;

            Console.Write("Entre o numero da conta: ");
            int number =int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string holder = (Console.ReadLine());

            Console.Write("Haverá depósito inicial (s/n)? : ");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 's' || answer == 'S') {
                Console.Write("Entre o valor de depóstito inicial: $");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(number, holder, initialDeposit);
            } else {
                account = new BankAccount(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Entre um valor para deposito: $");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(amount);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: $");
            double amount2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(amount2);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(account);
            Console.WriteLine();

        }
    }
}