using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startNum = int.Parse(Console.ReadLine());


            if (startNum <= 10)
            {
                for (int i = startNum; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
            else
            {
                Console.WriteLine($"{n} X {startNum} = {n * startNum}");
            }
        }
}   }

