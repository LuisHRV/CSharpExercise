using System;
using System.Globalization;

namespace AulaCSharp3 {
    internal class Program {
        static void Main(string[] args) {
            int employees, hours;
            double valueForCaulculate, valueToRecive;

            employees = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            valueForCaulculate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valueToRecive = hours * valueForCaulculate;

            Console.WriteLine($"NUMBER = {employees}");
            Console.WriteLine("SALARY = U$ " + valueToRecive.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}