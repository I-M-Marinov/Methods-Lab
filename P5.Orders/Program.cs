using System;

namespace P5.Orders
{
    internal class Program
    {
        static void Coffee(double price, int quantity)
        {
            Console.WriteLine($"{price * quantity:f2}");
        }
        static void Water(double price, int quantity)
        {
            Console.WriteLine($"{price * quantity:f2}");
        }
        static void Coke(double price, int quantity)
        {
            Console.WriteLine($"{price * quantity:f2}");
        }
        static void Snacks(double price, int quantity)
        {
            Console.WriteLine($"{price * quantity:f2}");
        }
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                Coffee(1.50,quantity);
            }
            else if (product == "water")
            {
                Water(1.00,quantity);
            }
            else if (product == "coke")
            {
                Coke(1.40,quantity);
            }
            else if (product == "snacks")
            {
                Snacks(2.00,quantity);
            }
        }
    }
}
