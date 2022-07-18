using System;
using ExtensionMetods.Extensions;

namespace ExtensionMetods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 7,8,11,20,20);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
