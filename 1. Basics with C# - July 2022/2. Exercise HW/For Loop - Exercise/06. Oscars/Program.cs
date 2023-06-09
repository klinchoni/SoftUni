using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int numberJudges = int.Parse(Console.ReadLine());
            double countPoints = academyPoints;



            for (int judge = 1; judge <= numberJudges; judge++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());
                countPoints += (judgeName.Length * judgePoints) / 2;

                if (countPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {countPoints:f1}!");
                    break;
                }

            }


            if (countPoints <= 1250.5)
            {
                double diff = 1250.5 - countPoints;
                Console.WriteLine($"Sorry, {actorName} you need {diff:f1} more!");
            }

        }
    }
}
