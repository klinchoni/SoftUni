using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int currentNum = int.Parse(input);
                if (currentNum < minNumber)
                {
                    minNumber = currentNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
