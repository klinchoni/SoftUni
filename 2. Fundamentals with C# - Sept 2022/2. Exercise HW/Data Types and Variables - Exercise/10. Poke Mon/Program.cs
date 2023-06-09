using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int counter = 0;
            double percent = (double)power * 0.50;
            while (power >= distance)
            {
                counter++;
                power -= distance;
                if (power==percent && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
