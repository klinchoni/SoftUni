using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string nameOfTheArchitect=Console.ReadLine();
            int numberOfProjects=int.Parse(Console.ReadLine());
            int individualProjectTime = 3;
            int timeForAllProjects = numberOfProjects * individualProjectTime;
            Console.WriteLine($"The architect {nameOfTheArchitect} will need {timeForAllProjects} hours to complete {numberOfProjects} project/s.");
        }
    }
}
