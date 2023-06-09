using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1 Converting string input "Peter George" in  string[] => ["Peter", "George] by using Spilt();
            // Step 2 - Creating Method that takes two arguments string input[0] and input[1];
            // step 3 - Create integer sum = 0 in which we will save the final sum of multiplication/ adding if the one string is longer then the other 
            // step 4 - Fiding string that is bigger than the other Math.Min(stringOne.length, stringTwo.length)
            // step 5 create for loop string from 0 till the minLength to go throught both strings 

            string[] input = Console.ReadLine().Split();
            GetStringSum(input[0], input[1]);
        }

        private static void GetStringSum(string firstString, string secondString)
        {
            int sum = 0;
            int minLength = Math.Min(firstString.Length, secondString.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            string longestLegthString = firstString;
            if (longestLegthString.Length < secondString.Length)
            {
                longestLegthString = secondString;
            }
            for (int i = minLength; i < longestLegthString.Length; i++)
            {
                sum += longestLegthString[i];
            }
            Console.WriteLine(sum);
        }
    }
}
