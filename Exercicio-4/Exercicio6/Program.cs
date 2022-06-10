using System.Globalization;

namespace Exercicio6 {
    internal class Program {
        static void Main(string[] args) {
            double numb;

            numb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numb < 0.0 || numb > 100.0) {
                Console.WriteLine("Fora do intervalo");
            } else if (numb <= 25.0) {
                Console.WriteLine("Intervlo ( 0 , 25 )");
            } else if (numb <= 50.0) {
                Console.WriteLine("Intervalo ( 25 , 50 )");
            } else if (numb <= 75.0) {
                Console.WriteLine("Intervalo ( 50 , 75 )");
            } else {
                Console.WriteLine("Intervalo ( 75 , 100 )");
            }
        }
    }
}