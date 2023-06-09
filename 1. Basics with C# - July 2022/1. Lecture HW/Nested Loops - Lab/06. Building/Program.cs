using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors=int.Parse(Console.ReadLine());
            int rooms=int.Parse(Console.ReadLine());

            for(int currentFloor = floors; currentFloor >= 1; currentFloor--)
            {
                for(int currentRoom = 0; currentRoom < rooms; currentRoom++)
                {
                    if (currentFloor == floors)
                    {
                        Console.Write($"L{currentFloor}{currentRoom} ");
                    }

                    else if(currentFloor%2==0)
                    {
                        Console.Write($"O{currentFloor}{currentRoom} ");
                    }

                    else
                    {
                        Console.Write($"A{currentFloor}{currentRoom} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
