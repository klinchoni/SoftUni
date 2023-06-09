using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] pplInWagons = new int[wagons];
            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                pplInWagons[i] = people;
                sum += people;
            }

            Console.WriteLine(String.Join(" ", pplInWagons));
            Console.WriteLine(sum);
        }
    }
}

