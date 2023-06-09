using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)  //rows
            {
                PrintColumns(i);
            }

            for(int i=number-1;i>=1;i--) //rows
            {
                PrintColumns(i);
            }
            
        }

        private static void PrintColumns(int i)
        {
                for (int j =1; j <= i; j++) //columns
                {
                    Console.Write(j + " ");
                }
            Console.WriteLine();
        }
    }
}
