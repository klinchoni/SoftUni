using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int counter = 0;
            while (counter <= number)
            {
                counter = counter * 2 + 1;
                if (counter <= number)
                {
                    Console.WriteLine(counter);
                }
            }
            
        }
    }
}
