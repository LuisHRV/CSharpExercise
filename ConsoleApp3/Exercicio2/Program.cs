using System;
using System.Globalization;

namespace AulaCSharp3 {
    internal class Program {
        static void Main(string[] args) {
            int a, b, c, d, diferença;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferença = a * b - c * d;
            Console.WriteLine(diferença);
        }
    }
}