using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();

            double averageScoreForAllPresentation = 0;
            int counter = 0;

            while (nameOfPresentation != "Finish")
            {
                double averageScore = 0;

                for (int i = 0; i < jury; i++)
                {
                    double currentScore = double.Parse(Console.ReadLine());

                    averageScore += currentScore;
                    averageScoreForAllPresentation += currentScore;
                    counter++;
                }

                double averageScorePerPresentation = averageScore / jury;

                Console.WriteLine($"{nameOfPresentation} - {averageScorePerPresentation:F2}.");

                nameOfPresentation = Console.ReadLine();
            }

            double assesment = averageScoreForAllPresentation / counter;

            Console.WriteLine($"Student's final assessment is {assesment:F2}.");
        }
    }
}
