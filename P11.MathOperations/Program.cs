﻿using System;

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

            Console.WriteLine(result); // Why do I need to tell the console to write it 
            return result;            // if I am using RETURN to get the result printed ????? 
            
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
