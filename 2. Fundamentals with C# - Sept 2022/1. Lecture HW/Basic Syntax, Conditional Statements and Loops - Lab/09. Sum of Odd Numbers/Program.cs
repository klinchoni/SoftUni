using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            int startNum = 1;

            while (n > 0)
            {
                Console.WriteLine(startNum);

                sum += startNum;

                startNum += 2;

                n--;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
