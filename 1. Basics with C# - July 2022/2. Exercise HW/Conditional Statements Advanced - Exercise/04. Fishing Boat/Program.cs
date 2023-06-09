using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            int fishermen=int.Parse(Console.ReadLine());

            int shipRentAtSpring = 3000;
            int shipRentAtSummerAndAutumn = 4200;
            int shipRentAtWinter = 2600;

            double totalSum = 0;
            double discount = 0;

            switch (season)
            {
                case "Spring":
                    totalSum = shipRentAtSpring;
                    break;
                case "Summer":
                    totalSum = shipRentAtSummerAndAutumn;
                    break;
                case "Autumn":
                    totalSum = shipRentAtSummerAndAutumn;
                    break;
                case "Winter":
                    totalSum = shipRentAtWinter;
                    break;
            }
            if (fishermen <= 6)
            {
                discount = totalSum * 0.10;
                totalSum = totalSum - discount;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                discount = totalSum * 0.15;
                totalSum = totalSum - discount;
            }
            else if (fishermen >= 12)
            {
                discount = totalSum * 0.25;
                totalSum = totalSum - discount;
            }
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                double secondDiscount = totalSum * 0.05;
                totalSum = totalSum - secondDiscount;
            }
            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (totalSum > budget)
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
