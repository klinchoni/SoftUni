using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTabs = int.Parse(Console.ReadLine()); 
            int salary = int.Parse(Console.ReadLine());

            
            for (int tab = 1; tab <= countTabs; tab++)
            {
                string website = Console.ReadLine();
                
                switch (website)
                {
                    case "Facebook":
                        salary -= 150; 
                        break;
                    case "Instagram":
                        salary -= 100; 
                        break;
                    case "Reddit":
                        salary -= 50; 
                        break;
                }

                
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
