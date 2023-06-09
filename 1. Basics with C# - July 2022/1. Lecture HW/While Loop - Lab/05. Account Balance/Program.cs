using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0;

            while (input != "NoMoreMoney")
            {
                double moneyIncrease = double.Parse(input);
                if (moneyIncrease < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {moneyIncrease:f2}");
                totalSum += moneyIncrease;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
