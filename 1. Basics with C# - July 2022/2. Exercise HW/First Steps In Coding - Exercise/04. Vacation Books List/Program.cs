using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages=int.Parse(Console.ReadLine());
            int readPagesPerHour=int.Parse(Console.ReadLine()); 
            int numberOfDays=int.Parse(Console.ReadLine());

            int hoursForRead = numberOfPages / readPagesPerHour;
            int daysForRead = hoursForRead / numberOfDays;

            Console.WriteLine(daysForRead);
        }
    }
}
