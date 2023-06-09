using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            string result = RepeatString(input, number);

            Console.WriteLine(result);
        }

        private static string RepeatString(string input, int number)
        {
            string result = "";

            for(int i = 0; i < number; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
