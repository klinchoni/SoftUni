using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int total = 0;
            int cycleCopy = 0;
            bool isSpecialNum = false;

            for (int cycle = 1; cycle <= digit; cycle++)
            {
                cycleCopy = cycle;

                while (cycleCopy > 0)
                {
                    total += cycleCopy % 10;
                    cycleCopy /= 10;
                }

                isSpecialNum = total == 5 || total == 7 || total == 11;
                Console.WriteLine($"{cycle} -> {isSpecialNum}");

                total = 0;
            }
        }
    }
}
