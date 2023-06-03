using System;

namespace P3.Calculations
{
    internal class Program
    {

        static void addition(int a, int b)
        {
            Console.WriteLine($"{a + b}");
        }
        static void multiplication(int a, int b)
        {
            Console.WriteLine($"{a * b}");
        }

        static void substraction(int a, int b)
        {
            Console.WriteLine($"{a - b}");
        }

        static void division(int a, int b)
        {
            Console.WriteLine($"{a / b}");
        }
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (operation == "add")
            {
                addition(number1, number2);
            }
            else if (operation == "multiply")
            {
                multiplication(number1,number2);
            }
            else if (operation == "subtract")
            {
                substraction(number1, number2);
            }
            else if (operation == "divide")
            {
                division(number1, number2);
            }

         

        }

    }
}
