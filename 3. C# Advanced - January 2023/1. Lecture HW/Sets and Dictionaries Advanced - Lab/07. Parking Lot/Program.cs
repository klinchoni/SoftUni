﻿using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                string[] tokens = command.Split(", ");
                switch (tokens[0])
                {
                    case "IN":
                        cars.Add(tokens[1]);
                        break;
                    case "OUT":
                        cars.Remove(tokens[1]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(cars.Count != 0 ? $"{String.Join(Environment.NewLine, cars)}" : "Parking Lot is Empty");
        }
    }
}
