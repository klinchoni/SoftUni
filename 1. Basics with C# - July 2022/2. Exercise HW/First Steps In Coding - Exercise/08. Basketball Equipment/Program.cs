using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double yearPaiment = double.Parse(Console.ReadLine());

            
            double priceForSneakers = yearPaiment * 0.6;
            double priceForOutfit = priceForSneakers * 0.8;
            double priceForBall = priceForOutfit / 4; 
            double priceForAccessories = priceForBall / 5; 

            double finalPrice = yearPaiment + priceForSneakers + priceForOutfit + priceForBall + priceForAccessories;

            
            Console.WriteLine(finalPrice);
        }
    }
}
