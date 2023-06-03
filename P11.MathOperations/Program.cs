using System;

namespace P11.MathOperations
{
    internal class Program
    { 
        static double Calculate(double a, string b, double c)
        {
            double result = 0;

            if (b == "/")
            {
                result = a / c;
            }
            else if (b == "*")
            {
                result = a * c;
            }
            else if (b == "+")
            {
                result = a + c;
            }
            else if (b == "-")
            {
                result = a - c;
            }

            return result; // why would this shit not RETURN THE FUCKING ANSWER ?!?!?!?!?!!?!?!?!?
        }

        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double number2 = double.Parse(Console.ReadLine());

            Calculate(number1, operation, number2);
        }
    }
}
