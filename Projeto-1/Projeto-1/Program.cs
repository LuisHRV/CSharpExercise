using Projeto_1.Entities;
using Projeto_1.Entities.Enums;
using System;

namespace Projeto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };

            Console.WriteLine(order);
        }
    }
}

