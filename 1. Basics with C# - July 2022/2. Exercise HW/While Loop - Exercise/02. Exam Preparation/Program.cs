using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            double sum = 0;
            int counter = 0;
            int badGradesCount = 0;
            string lastProblem = string.Empty;

            string nameOfProblem = Console.ReadLine();

            while (nameOfProblem != "Enough")
            {
                int grade=int.Parse(Console.ReadLine());
                lastProblem = nameOfProblem;

                if (grade <= 4)
                {
                    badGradesCount++;

                    if (badGradesCount == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
                        break;
                    }
                }
                sum += grade;
                counter++;

                nameOfProblem = Console.ReadLine();
            }
            double averageScore = sum / counter;

            if (badGradesCount < badGrades)
            {
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
