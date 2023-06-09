using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours=int.Parse(Console.ReadLine());
            int minutes=int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes >= 60)
            {
                minutes -= 60;    
                hours += 1;       
            }

            if (hours == 24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
