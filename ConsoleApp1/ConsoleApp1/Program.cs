using System;
using System.Globalization;

namespace AulaCSharp1 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.Write("Quantos quartos tem na sua casa ?:");
            string quartos = Console.ReadLine();
            Console.Write("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o seu ultimo nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');
            string sobrenome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture); 
            Console.WriteLine();

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
