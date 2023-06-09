using System;

namespace _02._Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            double slowingTime = Math.Floor(distance / 50);
            double totalTime = (distance * timeForMeter) + (slowingTime * 30);

            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(totalTime - recordInSeconds):F2} seconds slower.");
            }
        }
    }
}
