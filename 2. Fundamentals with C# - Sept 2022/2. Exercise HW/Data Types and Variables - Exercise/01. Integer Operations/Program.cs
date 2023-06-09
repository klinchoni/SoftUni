using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            long firstResult = (long)firstNumber + secondNumber;
            long secondResult = (long)firstResult/thirdNumber;
            long thirdResult = (long)secondResult*fourthNumber;
            Console.WriteLine(thirdResult);
        }
    }
}
