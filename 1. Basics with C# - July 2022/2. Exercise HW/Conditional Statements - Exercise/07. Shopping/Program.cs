using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetOfPetar = double.Parse(Console.ReadLine());
            int countOfVideoCards = int.Parse(Console.ReadLine());
            int countOfProcessor = int.Parse(Console.ReadLine());
            int countOfRamMemory = int.Parse(Console.ReadLine());

            double priceForVideoCard = 250;
            double sumVideoCards = countOfVideoCards * priceForVideoCard;

            double pricePerProcessor = sumVideoCards * 0.35;
            double sumProcessor = countOfProcessor * pricePerProcessor;

            double pricePerRam = sumVideoCards * 0.10;
            double sumRam = pricePerRam * countOfRamMemory;

            double fullPrice = sumProcessor + sumRam + sumVideoCards;

            if (countOfVideoCards > countOfProcessor)
            {
                fullPrice = fullPrice - (fullPrice * 0.15);
            }
            else
            {
                fullPrice = sumProcessor + sumRam + sumVideoCards;
            }

            if (budgetOfPetar >= fullPrice)
            {
                double moneyLeft = budgetOfPetar - fullPrice;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                double moneyNeeded = fullPrice - budgetOfPetar;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }
        }
    }
}
