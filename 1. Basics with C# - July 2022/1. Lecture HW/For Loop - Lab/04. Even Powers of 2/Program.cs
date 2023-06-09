using System;

namespace _04._Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            int num = 1;
            for(int value = 0; value <= number; value += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}
