using System;

namespace Exercicio1 {
    internal class Program {
        static void Main(string[] args) {
            int number;

            Console.Write("Digite um numero para saber se ele é posittivo ou negativo:");
            number = int.Parse(Console.ReadLine());

            if (number < 0) {
                Console.WriteLine("Seu numero é Negativo");
            } else {
                Console.WriteLine("Seu numero é Positivo");
            }
        }
    }
}