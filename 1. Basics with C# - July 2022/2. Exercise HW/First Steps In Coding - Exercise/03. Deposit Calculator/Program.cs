using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double lihva = deposit * percent / 100;
            double lihvaZaMesec = lihva / 12;

            double sum = deposit + months * lihvaZaMesec;

            Console.WriteLine(sum);
        }
    }
}
