using System;
using System.Globalization;

namespace AulaCSharp3 {
    internal class Program {
        static void Main(string[] args) {
            double pi, raio, soma, resultado;
            pi = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = Math.Pow(raio, 2.0);
            resultado = pi * soma;
            Console.WriteLine(resultado.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}