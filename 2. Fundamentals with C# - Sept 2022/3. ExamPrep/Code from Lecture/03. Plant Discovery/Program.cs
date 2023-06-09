using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // With Two Dictionaries 

            Dictionary<string, List<double>> plantRaitings = new Dictionary<string, List<double>>();
            Dictionary<string, int> plantRarities = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = input[0];
                int rarity = int.Parse(input[1]);

                if (!plantRarities.ContainsKey(plantName))
                {
                    plantRarities.Add(plantName, rarity);
                    plantRaitings.Add(plantName, new List<double>());
                }
                else
                {
                    plantRarities[plantName] = rarity;
                }
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] commandInfo = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

                string commandName = commandInfo[0];
                string plantName = commandInfo[1];

                if (commandName == "Rate")
                {
                    double rating = double.Parse(commandInfo[2]);

                    if (plantRaitings.ContainsKey(plantName))
                    {
                        plantRaitings[plantName].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "Update")
                {
                    int rarity = int.Parse(commandInfo[2]);

                    if (plantRarities.ContainsKey(plantName))
                    {
                        plantRarities[plantName] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "Reset")
                {
                    if (plantRaitings.ContainsKey(plantName))
                    {
                        plantRaitings[plantName].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var (plantName, rarity) in plantRarities)
            {
                double average = plantRaitings[plantName].Count > 0
                    ? plantRaitings[plantName].Average()
                    : 0;

                Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {average:F2}");
            }
        }
    }
}
