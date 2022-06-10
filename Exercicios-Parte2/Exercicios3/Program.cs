using System;

namespace Exercicio1 {
    internal class Program {
        static void Main(string[] args) {
            string[] frase;
            int number1, number2;

            Console.WriteLine("Digite um numero para saber se são multiplos: ");
            frase = Console.ReadLine().Split(' ');
            number1 = int.Parse(frase[0]);
            number2 = int.Parse(frase[1]);
            

            if (number1 % number2 ==0 || number2 % number1 ==0 ) {
                Console.WriteLine("São Multiplos");
            } else {
                Console.WriteLine("Não São Multiplos");
            }
        }
    }
}