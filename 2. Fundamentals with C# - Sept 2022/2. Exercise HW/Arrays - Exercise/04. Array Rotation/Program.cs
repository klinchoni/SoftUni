using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = Console.ReadLine()
            //   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //   .Select(int.Parse)
            //   .ToArray();
            //int rotationsCount = int.Parse(Console.ReadLine());
            //
            //int timesToRotate = rotationsCount % arr.Length;
            //for (int r = 1; r <= timesToRotate; r++)
            //{
            //    int firstEl = arr[0];
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        arr[i - 1] = arr[i];
            //    }
            //    arr[arr.Length - 1] = firstEl;
            //}
            //
            //Console.WriteLine(String.Join(" ", arr));

            int[] nums = Console.ReadLine()
                              .Split()
                              .Select(int.Parse)
                              .ToArray();

            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                int[] rotated = new int[nums.Length];
                rotated[nums.Length - 1] = nums[0];

                for (int k = 0; k < rotated.Length - 1; k++)
                {
                    rotated[k] = nums[k + 1];
                }

                nums = rotated;
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
