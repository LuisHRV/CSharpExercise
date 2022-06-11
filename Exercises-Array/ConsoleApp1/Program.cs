using System;
using System.Globalization;

namespace Exercicio2 {
    internal class Program {
        static void Main(string[] args) {

            double sum = 0.0;
            int n = int.Parse(Console.ReadLine());

            Product[] products = new Product[n];

            for (int i = 0; i < n; i++) {

                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                products[i] = new Product { Name = name, Price = price };

            }
            for (int i = 0; i < n; i++) {

                sum += products[i].Price;

            }
            double avg = sum / n;

            Console.WriteLine($"Media de valores é {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}