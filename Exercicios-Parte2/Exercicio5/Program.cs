using System;
using System.Globalization;

namespace Exercicio1 {
    internal class Program {
        static void Main(string[] args) {
            string[] frase;
            double hotDog, xSalad, xBacon, simpleToasty, soda;

            frase = Console.ReadLine().Split(' ');
            double numb1 = double.Parse(frase[0]);
            double numb2 = double.Parse(frase[1]);

            if (numb1 == 1) {
                hotDog = numb2 * 4.00;
                Console.WriteLine($"Voce pediu {numb2} Cachorros quentes e ficou um total de R$ {hotDog.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (numb1 == 2) {
                xSalad = numb2 * 4.50;
                Console.WriteLine($"Voce pediu {numb2} X-Saladas e ficou um total de R$ {xSalad.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (numb1 == 3) {
                xBacon = numb2 * 5.00;
                Console.WriteLine($"Voce pediu {numb2} X-Bacon e ficou um total de R$ {xBacon.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (numb1 == 4) {
                simpleToasty = numb2 * 2.00;
                Console.WriteLine($"Voce pediu {numb2} Torradas Simples e ficou um total de R$ {simpleToasty.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (numb1 == 5) {
                soda = numb2 * 1.50;
                Console.WriteLine($"Voce pediu {numb2} Refrigerantes e ficou um total de R$ {soda.ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}