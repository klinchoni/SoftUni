﻿using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            string commonItems = string.Empty;

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr1.Contains(arr2[i]))
                {
                    commonItems += arr2[i] + " ";
                }
            }

            Console.WriteLine(commonItems.TrimEnd());
        }
    }
}
