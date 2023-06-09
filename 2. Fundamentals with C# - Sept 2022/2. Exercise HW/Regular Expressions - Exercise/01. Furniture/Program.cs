using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<string> furniture = new List<string>();
             double totalMoneySpend = 0;
            
             string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
             //Instance regex
             Regex regex = new Regex(pattern);
            
             string inputLine;
             while ((inputLine = Console.ReadLine()) != "Purchase")
             {
                 Match match = regex.Match(inputLine);
                 if (match.Success)
                 {
                     string furnitureName = match.Groups["furnitureName"].Value;
                     double pricePerUnit = double.Parse(match.Groups["price"].Value);
                     int quantity = int.Parse(match.Groups["quantity"].Value);
            
                     furniture.Add(furnitureName);
                     totalMoneySpend += pricePerUnit * quantity;
                 }
             }
            
             Console.WriteLine($"Bought furniture:");
             foreach (string furnitureName in furniture)
             {
                 Console.WriteLine(furnitureName);
             }
             Console.WriteLine($"Total money spend: {totalMoneySpend:f2}");

            // 2 WAY

           // string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";
           // decimal sum = 0.0M;
           // List<string> furnitureList = new List<string>();
           //
           // while (true)
           // {
           //     string input = Console.ReadLine();
           //     if (input == "Purchase")
           //     {
           //         break;
           //     }
           //
           //     MatchCollection matches = Regex.Matches(input, pattern);
           //     foreach (Match furniture in matches)
           //     {
           //         furnitureList.Add(furniture.Groups["furniture"].Value);
           //         sum += decimal.Parse(furniture.Groups["price"].Value) * int.Parse(furniture.Groups["quantity"].Value);
           //     }
           // }
           //
           // Console.WriteLine("Bought furniture:");
           // if (furnitureList.Count != 0)
           // {
           //     Console.WriteLine(String.Join(Environment.NewLine, furnitureList));
           // }
           // Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
