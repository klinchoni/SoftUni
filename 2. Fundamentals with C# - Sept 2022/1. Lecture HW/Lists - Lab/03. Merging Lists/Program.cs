using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstCollection = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            List<int> secondCollection = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            List<int> result = new List<int>();

            //1 2 3 4 - firstCollection
            //1 2 3 - secondCollection

            int n = Math.Min(firstCollection.Count, secondCollection.Count);

            for (int i = 0; i < n; i++)
            {
                result.Add(firstCollection[i]); //1
                result.Add(secondCollection[i]); //1
            }

            if (firstCollection.Count > secondCollection.Count)
            {
                for (int i = n; i < firstCollection.Count; i++)
                {
                    result.Add(firstCollection[i]);
                }
            }
            else if (secondCollection.Count > firstCollection.Count)
            {
                for (int i = n; i < secondCollection.Count; i++)
                {
                    result.Add(secondCollection[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
