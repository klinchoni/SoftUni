using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine()); //15
            List<int> lift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList(); //[4, 4, 0, 0]

            for (int i = 0; i < lift.Count; i++)
            {
                if (lift[i] < 4) // 
                {
                    while (lift[i] < 4 && people > 0)
                    {
                        lift[i]++;
                        people--;
                    }
                }
            }

            if (people == 0 && lift.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people == 0 && lift.All(x => x == 4))
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
