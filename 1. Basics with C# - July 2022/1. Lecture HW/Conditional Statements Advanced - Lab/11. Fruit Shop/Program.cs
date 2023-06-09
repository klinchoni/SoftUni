using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit=Console.ReadLine();
            string dayOfWeek=Console.ReadLine();
            double quantity=double.Parse(Console.ReadLine());
            double totalSum = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            totalSum = quantity * 2.50 ;
                            break;
                        case "apple":
                            totalSum = quantity * 1.20;
                            break;
                        case "orange":
                            totalSum = quantity * 0.85;
                            break;
                        case "grapefruit":
                            totalSum = quantity * 1.45;
                            break;
                        case "kiwi":
                            totalSum = quantity * 2.70;
                            break;
                        case "pineapple":
                            totalSum = quantity * 5.50;
                            break;
                        case "grapes":
                            totalSum = quantity * 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            totalSum = quantity * 2.70;
                            break;
                        case "apple":
                            totalSum = quantity * 1.25;
                            break;
                        case "orange":
                            totalSum = quantity * 0.90;
                            break;
                        case "grapefruit":
                            totalSum = quantity * 1.60;
                            break;
                        case "kiwi":
                            totalSum = quantity * 3.00;
                            break;
                        case "pineapple":
                            totalSum = quantity * 5.60;
                            break;
                        case "grapes":
                            totalSum = quantity * 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                        default:
                    Console.WriteLine("error");
                    break;
            }
            if (totalSum > 0)
            {
                Console.WriteLine($"{totalSum:f2}");
            }
        }
    }
}
