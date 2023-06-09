using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town=Console.ReadLine();
            double sales=double.Parse(Console.ReadLine());
            double comission = 0;

            switch (town)
            {
                case "Sofia":
                    if (0 <= sales && sales <= 500)
                    {
                        comission = 0.05;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        comission = 0.07;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        comission = 0.08;
                    }
                    else if (sales > 10000)
                    {
                        comission = 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (0 <= sales && sales <= 500)
                    {
                        comission = 0.045;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        comission = 0.075;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        comission = 0.10;
                    }
                    else if (sales > 10000)
                    {
                        comission = 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        comission = 0.055;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        comission = 0.08;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        comission = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        comission = 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                    default:
                    Console.WriteLine("error");
                    break;
            }
            double totalSum = sales * comission;
            if (comission > 0)
            {
                Console.WriteLine($"{totalSum:f2}");
            }
        }
    }
}
