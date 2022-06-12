using System;

namespace Exercicio_Matriz {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite a quantidade da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine("Digite os numeros da matris");
            for (int i = 0; i < n; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {

                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Main Diagonal :");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i]);
            }

            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Negative numbers: {count}");
        }
    }
}
