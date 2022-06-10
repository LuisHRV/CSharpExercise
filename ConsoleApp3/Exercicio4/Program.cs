using System;
using System.Globalization;

namespace AulaCSharp4 {
    internal class Program {
        static void Main(string[] args) {
            string[] frase1, frase2;
            int codPeca1, codPeca2, numPeca1, numPeca2;
            double valorPeca1, valorPeca2 , aPagar1, aPagar2 , soma;

            Console.WriteLine("Digite o codigo, a quantidade e o valor das pelças: ");
            frase1 = Console.ReadLine().Split(' ');
            frase2 = Console.ReadLine().Split(' ');

            codPeca1 = int.Parse(frase1[0]);
            codPeca2 = int.Parse(frase2[0]);
            numPeca1 = int.Parse(frase1[1]);
            numPeca2 = int.Parse(frase2[1]);
            valorPeca1 = double.Parse(frase1[2], CultureInfo.InvariantCulture);
            valorPeca2 = double.Parse(frase2[2], CultureInfo.InvariantCulture);



            aPagar1 = numPeca1 * valorPeca1;
            aPagar2 = numPeca2 * valorPeca2;
            soma = aPagar1 + aPagar2;

            Console.Write("Valor a Pagar " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}