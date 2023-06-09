using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.00;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

            }
            else if (typeOfGroup == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }

            }
            else if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            double totalPrice = countOfPeople * price;
            double discount = 0.00;

             if (typeOfGroup == "Students" && countOfPeople >= 30)
             {
                discount = totalPrice * 0.15;

             }
            else if (typeOfGroup == "Business" && countOfPeople >= 100)
            {
                discount = 10 * price;

            }
            else if (typeOfGroup == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                discount = totalPrice * 0.05;

            }

            Console.WriteLine($"Total price: {totalPrice - discount:F2}");
        }
    }
}
