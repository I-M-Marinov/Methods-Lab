using System;

namespace P8.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());
            CalculateMathPower(baseNumber,powerNumber);

            static void CalculateMathPower(double a, double b)
            {
                Console.WriteLine(Math.Pow(a,b));
            }
        }
    }
}
