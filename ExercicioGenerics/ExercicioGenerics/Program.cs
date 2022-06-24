using ExercicioGenerics.Entities;
using System;

namespace ExercicioGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CounterList printService = new CounterList();

            Console.Write("How many values? ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine("First: "+ printService.First());
        }
    }
}
