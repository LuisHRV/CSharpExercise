using Excercicio4;
using System.Globalization;

namespace Exercicio4 {
    class Program {
        static void Main(string[] args) {

            Rectangle r = new Rectangle();

            Console.Write("Entre com a largura do retângulo:");
            r.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com a altura do retângulo:");
            r.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaCalculate = r.Area();
            double perimeterCalculate = r.Perimeter();
            double diagonalCalculate = r.Diagonal();

            Console.WriteLine("Area: " + areaCalculate.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + perimeterCalculate.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + diagonalCalculate.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}