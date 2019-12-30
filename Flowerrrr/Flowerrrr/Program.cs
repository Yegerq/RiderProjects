using System;

namespace FlowerShop4
{
    public class Program
    {
        static int Main(string[] args)
        {
            OrderProcessing order = new OrderProcessing();

            order.ProcessOrder();
            Console.WriteLine();

            order.ShowOrder();
            Console.WriteLine();
            return 0;
        }
    }
}