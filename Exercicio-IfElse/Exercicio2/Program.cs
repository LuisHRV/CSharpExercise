using System;

namespace Exercicio1 {
    internal class Program {
        static void Main(string[] args) {
            int number, mod;

            Console.Write("Digite um numero para saber se ele é Par ou Impar: ");
            number = int.Parse(Console.ReadLine());
            mod = number % 2;

            if (mod != 0) {
                Console.WriteLine("Seu numero é Impar");
            } else {
                Console.WriteLine("Seu numero é Par");
            }
        }
    }
}