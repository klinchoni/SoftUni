using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  

           

            
            int maxNumber = int.MinValue;

            
            int sum = 0;

            for (int number = 1; number <= n; number++) 
            {
                int value = int.Parse(Console.ReadLine()); 
                sum = sum + value; 
                if (value > maxNumber)
                {
                    maxNumber = value;
                }
            }

            
            int sumOthers = sum - maxNumber; 
            if (maxNumber == sumOthers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxNumber - sumOthers));
            }
        }
    }
}
