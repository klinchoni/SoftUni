using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month=Console.ReadLine();
            int numberOfNights=int.Parse(Console.ReadLine());

            double priceForStudio = 0;
            double priceForApartment = 0;

            
            if (month == "May" || month == "October")
            {
                priceForStudio = 50;
                priceForApartment = 65;

                if (numberOfNights > 7 && numberOfNights <= 14)
                {
                    priceForStudio *= 0.95;
                }
                else if (numberOfNights > 14)
                {
                    priceForStudio *= 0.7;
                    priceForApartment *= 0.9;
                }

            }
            else if (month == "June" || month == "September")
            {
                priceForStudio = 75.20;
                priceForApartment = 68.70;

                if (numberOfNights > 14)
                {
                    priceForStudio *= 0.8;
                    priceForApartment *= 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceForStudio = 76;
                priceForApartment = 77;

                if (numberOfNights > 14)
                {
                    priceForApartment *= 0.9;
                }
            }

            double finalPriceForStudio = numberOfNights * priceForStudio;
            double finalPriceForApartment = numberOfNights * priceForApartment;

            Console.WriteLine($"Apartment: {finalPriceForApartment:F2} lv.");
            Console.WriteLine($"Studio: {finalPriceForStudio:F2} lv.");
        }
    }
}
