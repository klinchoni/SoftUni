using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //
            //int[] firstArray = new int[n];
            //int[] secondArray = new int[n];
            //for (int i = 1; i <= n; i++)
            //{
            //    //[1, 4]
            //    int[] numbers = Console.ReadLine()
            //        .Split(" ")
            //        .Select(int.Parse)
            //        .ToArray();
            //    int firstNum = numbers[0];
            //    int secondNum = numbers[1];
            //
            //    if (i % 2 != 0)
            //    {
            //        //Odd -> 1, 3, 5, 7...
            //        firstArray[i - 1] = firstNum;
            //        secondArray[i - 1] = secondNum;
            //    }
            //    else
            //    {
            //        //Even -> 2, 4, 6, 8...
            //        firstArray[i - 1] = secondNum;
            //        secondArray[i - 1] = firstNum;
            //    }
            //}
            //
            //Console.WriteLine(String.Join(" ", firstArray));
            //Console.WriteLine(String.Join(" ", secondArray));

            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] currentArray = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToArray();

                if (i % 2 != 0)   // odds
                {
                    arr1[i - 1] = currentArray[0];
                    arr2[i - 1] = currentArray[1];
                }
                else  // evens
                {
                    arr1[i - 1] = currentArray[1];
                    arr2[i - 1] = currentArray[0];
                }
            }

            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
