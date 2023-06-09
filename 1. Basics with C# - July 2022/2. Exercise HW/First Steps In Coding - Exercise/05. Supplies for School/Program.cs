using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double priceForPens = 5.8;
            double priceForMarkers = 7.2;
            double priceForDetergent = 1.2;

            
            int numberOfPens = int.Parse(Console.ReadLine());
            int numberOfMarkers = int.Parse(Console.ReadLine());
            int litresOfDetergent = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            
            double finalPriceForPens = priceForPens * numberOfPens;
            double finalPriceForMarkers = priceForMarkers * numberOfMarkers;
            double finalPriceForDetergent = priceForDetergent * litresOfDetergent;
            double sum = finalPriceForPens + finalPriceForMarkers + finalPriceForDetergent;

            double finalPrice = sum - (sum * percent / 100);

            
            Console.WriteLine(finalPrice);
        }
    }
}
