
namespace P9.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void GetMaxInt(int a, int b)
            {
                if (a > b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }

            }
            static void GetMaxChar(char a, char b)
            {
                if (a > b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }

            }
            static void GetMaxString(string a, string b)
            {
                int result = String.Compare(a, b);

                if (result > 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }


            string getType = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (getType == "int")
            {
                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);
                GetMaxInt(num1,num2);
            }
            else if (getType == "char")
            {
                char char1 = char.Parse(input1);
                char char2 = char.Parse(input2);
                GetMaxChar(char1,char2);
            }
            else if (getType == "string")
            {
                GetMaxString(input1, input2);
            }


        }
    }
}
