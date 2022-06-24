using System;
using ExercicioTypeSafety.Entities;

namespace ExercicioTypeSafety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintServises<int> printServices = new PrintServises<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printServices.AddValues(x);
            }

            printServices.Print();
            Console.WriteLine($"First: {printServices.First()}");
        }
    }
}
