using System;

namespace _07.Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();

            double totalSum = 0.0;

            while (coins != "Start")
            {
                double currentSum = double.Parse(coins);

                if (currentSum != 0.1
                    && currentSum != 0.2
                    && currentSum != 0.5
                    && currentSum != 1
                    && currentSum != 2)
                {
                    Console.WriteLine($"Cannot accept {currentSum}");
                }
                else
                {
                    totalSum += currentSum;
                }

                coins = Console.ReadLine();
            }

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {

                double currentPrice = 0;
                bool invalidProduct = false;

                switch (input)
                {
                    case "nuts":
                        currentPrice = 2;
                        break;
                    case "water":
                        currentPrice = 0.7;
                        break;
                    case "crisps":
                        currentPrice = 1.5;
                        break;
                    case "soda":
                        currentPrice = 0.8;
                        break;
                    case "coke":
                        currentPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        invalidProduct = true;
                        break;
                }

                if (invalidProduct == false)
                {
                    if (totalSum >= currentPrice)
                    {
                        totalSum -= currentPrice;
                        Console.WriteLine($"Purchased {input.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change: {totalSum:f2}");
        }
    }
}
