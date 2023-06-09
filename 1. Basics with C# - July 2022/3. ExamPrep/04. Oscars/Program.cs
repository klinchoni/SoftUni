using System;

namespace _04._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoint = double.Parse(Console.ReadLine());
            int evaluatingNumber = int.Parse(Console.ReadLine());

            double finalPoints = academyPoint;


            for (int evaluationCounter = 1; evaluationCounter <= evaluatingNumber; evaluationCounter++)
            {
                string nameOfTheEvaluator = Console.ReadLine();
                double pointOfEvaluation = double.Parse(Console.ReadLine());

                int nameLength = nameOfTheEvaluator.Length;

                finalPoints += (nameLength * pointOfEvaluation) / 2.0;

                if (finalPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {finalPoints:f1}!");
                    break;
                }
            }

            if (finalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - finalPoints):f1} more!");
            }

        }
    }
}
