using System;
using OrderBasic.Entities;
using OrderBasic.Entities.Enums;

namespace OrderBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 3082,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine("Pedido: " + order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Shipped");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
