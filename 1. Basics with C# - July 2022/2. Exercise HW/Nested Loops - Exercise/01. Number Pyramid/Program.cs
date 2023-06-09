using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int currentNumber = 1;
            bool isBigger = false;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (currentNumber > number)
                    {
                        isBigger = true;
                        break;
                    }

                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                }

                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
