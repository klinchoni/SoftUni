using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mainNum=int.Parse(Console.ReadLine());
            int sum = 0;

            while (mainNum > sum)
            {
                int newNum=int.Parse(Console.ReadLine());
                sum += newNum;
            }
            Console.WriteLine(sum);
        }
    }
}
