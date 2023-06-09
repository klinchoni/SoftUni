using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery___with_a_Class
{
    class Plant
    {
        public Plant()
        {
            Rating = new List<double>();
        }

        public int Rarity { get; set; }

        public List<double> Rating { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = input[0];
                int rarity = int.Parse(input[1]);

                if (!plants.ContainsKey(plantName))
                {
                    Plant plant = new Plant
                    {
                        Rarity = rarity
                    };

                    plants.Add(plantName, plant);
                }

                plants[plantName].Rarity = rarity;
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

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rating.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (commandName == "Update")
                {
                    int rarity = int.Parse(commandInfo[2]);

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rarity = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (commandName == "Reset")
                {
                    if (plants.ContainsKey(plantName))
                    {
                        plants[plantName].Rating.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var (plantName, plant) in plants)
            {
                double average = plant.Rating.Count > 0
                    ? plant.Rating.Average()
                    : 0;

                Console.WriteLine($"- {plantName}; Rarity: {plant.Rarity}; Rating: {average:F2}");
            }
        }
    }
}
