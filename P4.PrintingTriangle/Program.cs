using System;

namespace P4.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void PrintLine(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            }
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }
            for (int i = number-1; i >=1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
