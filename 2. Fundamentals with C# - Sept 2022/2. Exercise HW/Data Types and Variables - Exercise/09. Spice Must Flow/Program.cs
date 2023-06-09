using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int exstractedYeld = startingYield;
            int days = 0;
            int total = 0;
            while (exstractedYeld >= 100)
            {
                days++;
                total = total + exstractedYeld - 26;
                exstractedYeld -= 10;
            }
            if (exstractedYeld >= 26 && days > 0)
            {
                total -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(total);
        }
    }
}
