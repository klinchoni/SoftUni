using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            int count1 = 0; 
            int count2 = 0;
            int count3 = 0; 
            int count4 = 0; 
            int count5 = 0;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                
                if (value < 200)
                {
                    
                    count1++;
                }
                else if (value >= 200 && value <= 399)
                {
                    
                    count2++;
                }
                else if (value >= 400 && value <= 599)
                {
                    
                    count3++;
                }
                else if (value >= 600 && value <= 799)
                {
                    
                    count4++;
                }
                else if (value >= 800)
                {
                    
                    count5++;
                }
            }

          
            double p1 = count1 * 1.0 / n * 100; 
            double p2 = count2 * 1.0 / n * 100; 
            double p3 = count3 * 1.0 / n * 100; 
            double p4 = count4 * 1.0 / n * 100; 
            double p5 = count5 * 1.0 / n * 100; 

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
