using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numberOfFlowers=int.Parse(Console.ReadLine());
            int budget=int.Parse(Console.ReadLine());

            double price = 0;
            switch (flowers)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price =3.80;
                    break;
                case "Tulips":
                    price =2.80;
                    break;
                case "Narcissus":
                    price =3;
                    break;
                case "Gladiolus":
                    price =2.50;
                    break;
            }

            double finalPrice = numberOfFlowers * price;

            if (flowers == "Roses" && numberOfFlowers > 80)
            {
                finalPrice *= 0.9;
            }
            else if (flowers == "Dahlias" && numberOfFlowers > 90)
            {
                finalPrice *= 0.85;
            }
            else if (flowers == "Tulips" && numberOfFlowers > 80)
            {
                finalPrice *= 0.85;
            }
            else if (flowers == "Narcissus" && numberOfFlowers < 120)
            {
                finalPrice *= 1.15;
            }
            else if (flowers == "Gladiolus" && numberOfFlowers < 80)
            {
                finalPrice *= 1.2;
            }

            double difference = Math.Abs(finalPrice - budget);

            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {difference:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
            }
        }
    }
}
