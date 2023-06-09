using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceForLaundry = double.Parse(Console.ReadLine());
            int priceForToy = int.Parse(Console.ReadLine());
            int toys = 0;
            int money = 0;
            int evenBirthdays = 0;
            int extraMoney = 0;

            for (int countOfBirthdays = 1; countOfBirthdays <= age; countOfBirthdays++)
            {
                if (countOfBirthdays % 2 == 0)
                {
                    evenBirthdays++;
                    extraMoney += 10;
                    money += extraMoney;
                }
                else
                {
                    toys++;
                }
            }

            int moneyFromToys = toys * priceForToy;
            int finalSum = (money + moneyFromToys) - evenBirthdays;

            if (finalSum >= priceForLaundry)
            {
                double moneyLeft = finalSum - priceForLaundry;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = priceForLaundry - finalSum;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
