using Exercicio2.Entities;
using Exercicio2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        public static NumberStyles Cult { get; private set; }

        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter th number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)?: ");
                char rorc = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Red/Green/Blue): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(rorc =='r' || rorc == 'R')
                {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
                Console.WriteLine();
                Console.WriteLine("Shape areas: ");
                foreach (Shape shape in list)
                {
                    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
