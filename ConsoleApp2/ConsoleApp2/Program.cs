using System;
using System.Globalization;

namespace AulaCSharp1 {
    internal class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'F';

            double preco1, preco2, medida;
            preco1 = 2100.0;
            preco2 = 650.50;
            medida = 53.234567;

            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1:F2},");
            Console.WriteLine($"{produto2}, cujo o preço é $ {preco2:F2}\n");

            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e gênero: {genero}\n");

            Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondando (três casa decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
