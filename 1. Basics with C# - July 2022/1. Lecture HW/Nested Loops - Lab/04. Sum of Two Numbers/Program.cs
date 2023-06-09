using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinations = 0;
            bool hasMagicNumberBeenFound = false;

            for (int firstNumber = startingNumber; firstNumber <= endNumber; firstNumber++)
            {
                for (int secondNumber = startingNumber; secondNumber <= endNumber; secondNumber++)
                {
                    combinations++;
                    if (firstNumber + secondNumber == magicNumber)
                    {
                        hasMagicNumberBeenFound = true;
                        Console.WriteLine($"Combination N:{combinations}({firstNumber} + {secondNumber} = {magicNumber})");
                        break;
                    }
                }
                if (!hasMagicNumberBeenFound)
                {
                    break;
                }
            }
            if (!hasMagicNumberBeenFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
