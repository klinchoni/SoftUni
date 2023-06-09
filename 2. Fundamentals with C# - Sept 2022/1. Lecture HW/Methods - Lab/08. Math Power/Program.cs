using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        public static double RaiseToPower(double number, int power)
        {
            double result = number;
            for (int num = 1; num < power; num++)
            {
                result *= number;
            }
            return result;
        }
    }
}
