using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int numberOfStatits=int.Parse(Console.ReadLine());
            double priceForOneSuit=double.Parse(Console.ReadLine());

            double clothesPrice = numberOfStatits * priceForOneSuit;
            double decor = 0.1 * movieBudget;

            if (numberOfStatits > 150)
            {
                clothesPrice = 0.9 * clothesPrice;
            }

            double expenses = decor + clothesPrice;

            if (expenses > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                double needMoney = expenses - movieBudget;
                Console.WriteLine($"Wingard needs {needMoney:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                double moneyLeft = movieBudget - expenses;
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
        }
    }
}
