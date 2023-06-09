using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int currentNum = int.Parse(input);
                if (currentNum > maxNumber)
                {
                    maxNumber = currentNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
