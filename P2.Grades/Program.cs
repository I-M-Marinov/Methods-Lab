using System;

namespace P2.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            checkGradeDefinition(grade);
        }

        static void checkGradeDefinition(double number)
        {
            if (number >= 2 && number <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (number >= 3 && number <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (number >= 3.50 && number <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (number >= 4.50 && number <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (number >= 5.50 && number <= 6.00)
            {
                Console.WriteLine("Excellent");

            }
        }
    }
}


