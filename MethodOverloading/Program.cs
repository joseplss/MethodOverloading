using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddMethod(1, 2));
            Console.WriteLine(AddMethod(4.1m, 4.2m));
            Console.WriteLine(AddMethod(5, 8, true));

        }
        static public int AddMethod (int num1, int num2)
        {
            return num1 + num2;
        }
        static public decimal AddMethod (decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        static public string AddMethod (int num1, int num2, bool isNumOnly1)
        {
            int numSum = AddMethod(num1, num2);
            if (isNumOnly1 && numSum > 1 || numSum == 0)
            {
                return $"{numSum} dollars";
            }
            else if (isNumOnly1 && numSum == 1)
            {
                return $"{numSum} dollar";
            }
            else
            {
                return numSum.ToString();
            }
        }

    }
}
