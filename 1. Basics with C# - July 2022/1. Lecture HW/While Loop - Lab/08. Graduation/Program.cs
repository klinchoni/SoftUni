using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            double rating = double.Parse(Console.ReadLine());
            double totalRating = 0;
            double averageRating = 0;
            int grade = 1;
            int fails = 0;

            while (grade <= 12)
            {
                if (rating < 4.00)
                {
                    fails++;
                }
                if (fails == 2)
                {
                    grade--;
                    Console.WriteLine($"{student} has been excluded at {grade} grade");
                    break;
                }
                totalRating += rating;
                averageRating = totalRating /grade;
                grade++;
                if (grade > 12)
                {
                    Console.WriteLine($"{student} graduated. Average grade: {averageRating:f2}");
                    break;
                }
                rating = double.Parse(Console.ReadLine());
            }
        }
    }
}
