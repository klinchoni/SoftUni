using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {

              //Field
              //Array of integers
              //0 -> No ladybug
              //1 -> Ladybug
              int fieldSize = int.Parse(Console.ReadLine());
              int[] ladybugsIndexes = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
            
              //Initialize the field
              int[] field = new int[fieldSize];
              for (int index = 0; index < fieldSize; index++)
              {
                  if (ladybugsIndexes.Contains(index))
                  {
                      //If index is present in ladybugsIndexes then there is a ladybug
                      field[index] = 1;
                  }
              }
            
              string command;
              while ((command = Console.ReadLine()) != "end")
              {
                  string[] cmdArgs = command
                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                      .ToArray();
            
                  int initialIndex = int.Parse(cmdArgs[0]);
                  string direction = cmdArgs[1];
                  int flyLength = int.Parse(cmdArgs[2]);
            
                  //First always check if index is valid!!!
                  if (initialIndex < 0 || initialIndex >= field.Length)
                  {
                      //Nothing happens, next iteration (command)
                      //Skips the command
                      continue;
                  }
            
                  //We have valid index, then we check if there is a ladybug
                  //If there isn't a ladybug
                  if (field[initialIndex] == 0)
                  {
                      continue;
                  }
            
                  //Ladybug starts flying
                  //Initial index set to 0, bcos there is no ladybug anymore
                  field[initialIndex] = 0;
            
                  //Calculate where the next index is
                  int nextIndex = initialIndex;
                  while (true)
                  {
                      if (direction == "right")
                      {
                          nextIndex += flyLength;
                      }
                      else if (direction == "left")
                      {
                          nextIndex -= flyLength;
                      }
            
                      if (nextIndex < 0 || nextIndex >= field.Length)
                      {
                          //Next index is invalid (outside of the field)
                          //The ladybug is gone into the void
                          break;
                      }
            
                      if (field[nextIndex] == 0)
                      {
                          //The next index is empty and valid to land
                          //Then we land the ladybug there
                          break;
                      }
                  }
            
                  if (nextIndex >= 0 && nextIndex < field.Length)
                  {
                      //The next calculated index is valid!!!
                      //The ladybug lands there
                      field[nextIndex] = 1;
                  }
              }
            
              Console.WriteLine(String.Join(" ", field));


            //int fieldSize = int.Parse(Console.ReadLine());
            //int[] ladyBugs = new int[fieldSize];
            //int[] initialIndexes = Console.ReadLine()
            //                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //                              .Select(int.Parse)
            //                              .ToArray();
            //
            //for (int i = 0; i < ladyBugs.Length; i++) // Fill bugs on field
            //{
            //    if (initialIndexes.Contains(i))
            //    {
            //        ladyBugs[i] = 1;
            //    }
            //}
            ////------------------------------------------------------------------------------------------
            //
            //string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //while (command[0].ToLower() != "end")
            //{
            //    int index = int.Parse(command[0]);
            //
            //    if (index < 0 || index >= ladyBugs.Length)   // If index is inside the field
            //    {
            //        command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //        continue;
            //    }
            //
            //    if (ladyBugs[index] == 0)   // cell is empty (NO Lady Bug)
            //    {
            //        command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //        continue;
            //    }
            //
            //    //------------- Fly like the wind -------------
            //    string direction = command[1];
            //    int flyLength = int.Parse(command[2]);
            //    if (flyLength < 0)  // If flyLength is negative, change direction, and make it positive
            //    {
            //        flyLength = Math.Abs(flyLength);
            //        switch (direction)
            //        {
            //            case "right":
            //                direction = "left";
            //                break;
            //            case "left":
            //                direction = "right";
            //                break;
            //        }
            //    }
            //
            //    ladyBugs[index] = 0; // Lift off in 3...2...1
            //    bool isBugFlying = true;
            //    while (isBugFlying)
            //    {
            //        switch (direction)
            //        {
            //            case "right":
            //                if (index + flyLength >= ladyBugs.Length) // Lady Bug flew away (outside field)
            //                {
            //                    isBugFlying = false;
            //                }
            //                else
            //                {
            //                    if (ladyBugs[index + flyLength] == 0) //  is cell empty (no Lady Bug at index)
            //                    {
            //                        ladyBugs[index + flyLength] = 1; // Lady Bug landed
            //                        isBugFlying = false;
            //                    }
            //                    else
            //                    {
            //                        isBugFlying = true; // Lady Bug continues to fly
            //                        index += flyLength;
            //                    }
            //                }
            //                break;
            //
            //            case "left":
            //                if (index - flyLength < 0) // Lady Bug flew away (outside field)
            //                {
            //                    isBugFlying = false;
            //                }
            //                else
            //                {
            //                    if (ladyBugs[index - flyLength] == 0) //  is cell empty (no Lady Bug at index)
            //                    {
            //                        ladyBugs[index - flyLength] = 1; // Lady Bug landed
            //                        isBugFlying = false;
            //                    }
            //                    else
            //                    {
            //                        isBugFlying = true; // Lady Bug continues to fly
            //                        index -= flyLength;
            //                    }
            //                }
            //                break;
            //        }
            //    }
            //
            //    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //}
            //
            //Console.WriteLine(String.Join(" ", ladyBugs));
        } 
    }
}
