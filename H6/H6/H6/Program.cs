using System;

namespace H6
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService menu = new OrderService();
            menu.mainInteraction();
            menu.Export();
        }
    }
}
