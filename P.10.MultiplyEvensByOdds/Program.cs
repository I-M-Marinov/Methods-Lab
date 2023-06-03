using System;
using System.Linq;


namespace P._10.MultiplyEvensByOdds
{
    internal class Program
    {
        static int GetSumOfEvenDigits(int a, int[] b, int c)
        {
            int evenSum = 0;
            if (a > 0)
            {
                for (int i = 0; i < c; i++)
                {
                    if (b[i] % 2 == 0)
                    {
                        evenSum += b[i];
                    }
                }
            }
            else
            {
                for (int i = 1; i < c; i++)
                {
                    if (b[i] % 2 == 0)
                    {
                        evenSum += b[i];
                    }
                }
            }
            return evenSum;
        }


        static int GetSumOfOddDigits(int a, int[] b, int c)
        {
            int oddsSum = 0;

            if (a > 0)
            {
                for (int i = 0; i < c; i++)
                {
                    if (b[i] % 2 != 0)
                    {
                        oddsSum += b[i];
                    }
                }
            }
            else
            {
                for (int i = 1; i < c; i++)
                {
                    if (b[i] % 2 != 0)
                    {
                        oddsSum += b[i];
                    }
                }

            }
            return oddsSum;

        }
        static void GetMultipleOfEvenAndOdds(int a, int[] b, int c)
        {
            int sumOfEven = GetSumOfEvenDigits(a, b, c);
            int sumOfOdd = GetSumOfOddDigits(a, b, c);
            Console.WriteLine(sumOfEven * sumOfOdd);
        }
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine()); 
            int[] numberArray = inputNumber.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int arrayLength = numberArray.Length;

            GetMultipleOfEvenAndOdds(inputNumber,numberArray,arrayLength);
            
        }
    }
}
