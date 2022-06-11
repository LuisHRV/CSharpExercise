using System;
using System.Globalization;

namespace Exercicio5 {
    internal class Program {
        static void Main(string[] args) {
            
            var studant = new Studant();

            Console.Write("Nome do aluno: ");
            studant.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            studant.FirstNote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            studant.SecondNote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            studant.ThirdNote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double finalGrade = studant.FinalGrade();

            Console.WriteLine($"Nota Final: {finalGrade.ToString("F2", CultureInfo.InvariantCulture)} ");

            if (finalGrade >= 60.00) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                finalGrade = 60 - finalGrade;
                Console.WriteLine($"Faltaram {finalGrade.ToString("F2", CultureInfo.InvariantCulture)} pontos");
            }

        }
    }
}