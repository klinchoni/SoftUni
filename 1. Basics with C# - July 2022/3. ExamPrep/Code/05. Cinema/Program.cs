using System;

namespace _05._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int totalSeats = 0;

            string command = Console.ReadLine();
            while (command != "Movie time!")
            {
                int numberOfPeople = int.Parse(command);
                totalSeats += numberOfPeople;
                if (totalSeats > capacity)
                {
                    Console.WriteLine("The cinema is full.");
                    Console.WriteLine($"Cinema income - {totalSum} lv.");
                    break;
                }
                if (numberOfPeople % 3 == 0)
                {
                    totalSum += numberOfPeople * 5 - 5;
                }
                else
                {
                    totalSum += numberOfPeople * 5;
                }
                command = Console.ReadLine();
            }

            if (totalSeats <= capacity)
            {
                Console.WriteLine($"There are {capacity - totalSeats} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {totalSum} lv.");
            }

        }
    }
}
