using System;

namespace P7.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            RepeatTheString(input,number);

            static void RepeatTheString(string input, int number)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write(input);
                }
            }

            
        }
    }
}
