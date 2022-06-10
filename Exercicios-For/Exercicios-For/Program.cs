namespace Exercicio1 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantos Numero voce vai digitar?");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            int time = 0;

            for (int i = 0; i < n; i++) {

                time++;

                Console.Write($"Valor #{time}:");
                int value = int.Parse(Console.ReadLine());

                soma = soma + value;
            }

            Console.WriteLine($"Soma = {soma}");
        }
    }
}