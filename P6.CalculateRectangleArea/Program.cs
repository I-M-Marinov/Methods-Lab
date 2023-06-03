using System;

namespace P6.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void CalculateRectangleArea(int a, int b)
            {
                Console.WriteLine(a * b);
            }
            int number1 = int.Parse(Console.ReadLine());    
            int number2 = int.Parse(Console.ReadLine());
            CalculateRectangleArea(number1,number2);
        }
    }
}
