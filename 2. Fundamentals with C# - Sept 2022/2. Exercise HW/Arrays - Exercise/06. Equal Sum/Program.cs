using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            if (nums.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int left = i - 1; left >= 0; left--)
                {
                    leftSum += nums[left];
                }

                for (int right = i + 1; right < nums.Length; right++)
                {
                    rightSum += nums[right];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
