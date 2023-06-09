using System;

namespace _03._World_Snooker_Championship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string champStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());
            string trophyPhoto = Console.ReadLine(); // Y or N

            double pricePerTicket = 0;
            double price = 0;

            switch (champStage)
            {

                case "Quarter final":
                    switch (ticketType)
                    {
                        case "Standard":
                            pricePerTicket = 55.5;
                            break;
                        case "Premium":
                            pricePerTicket = 105.2;
                            break;
                        case "VIP":
                            pricePerTicket = 118.9;
                            break;
                    }
                    break;

                case "Semi final":
                    switch (ticketType)
                    {
                        case "Standard":
                            pricePerTicket = 75.88;
                            break;
                        case "Premium":
                            pricePerTicket = 125.22;
                            break;
                        case "VIP":
                            pricePerTicket = 300.4;
                            break;
                    }
                    break;
                case "Final":
                    switch (ticketType)
                    {
                        case "Standard":
                            pricePerTicket = 110.1;
                            break;
                        case "Premium":
                            pricePerTicket = 160.66;
                            break;
                        case "VIP":
                            pricePerTicket = 400;
                            break;
                    }
                    break;
            }

            price = pricePerTicket * ticketCount;

            bool isFreePhoto = false;
            if (price > 4000)
            {
                price *= 0.75;
                isFreePhoto = true;
            }
            else if (price > 2500)
            {
                price *= 0.9;
            }

            if (trophyPhoto == "Y" && isFreePhoto == false)
            {
                price += 40 * ticketCount;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
