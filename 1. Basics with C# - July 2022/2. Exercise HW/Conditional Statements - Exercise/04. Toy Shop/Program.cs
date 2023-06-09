using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForTheTrip=double.Parse(Console.ReadLine());
            int numberOfPuzzels = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double priceForPuzzels = numberOfPuzzels * 2.60;
            double priceForDolls = numberOfDolls * 3.0;
            double priceForBears = numberOfBears * 4.10;
            double priceForMinions = numberOfMinions * 8.20;
            double priceForTrucks = numberOfTrucks * 2.0;


            double incom = priceForPuzzels + priceForDolls + priceForBears + priceForMinions + priceForTrucks;
            int AllToys = numberOfPuzzels + numberOfDolls + numberOfBears + numberOfMinions + numberOfTrucks;

            if (AllToys >= 50)
            {
                double discount = incom * 0.25;
                incom = incom - discount;
            }

            double rent = incom * 0.1;

            double finalIncom = incom - rent;

            if (finalIncom >= priceForTheTrip)
            {
                double moneyLeft = finalIncom - priceForTheTrip;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                double moneyNeeded = priceForTheTrip - finalIncom;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
        }
    }
}
