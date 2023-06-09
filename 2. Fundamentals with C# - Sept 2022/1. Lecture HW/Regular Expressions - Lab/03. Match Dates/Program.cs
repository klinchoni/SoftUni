using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
            string input = Console.ReadLine();
            
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

            //2 WAY

           // string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
           // string message = Console.ReadLine();
           //
           // var dates = Regex.Matches(message, pattern);
           //
           // foreach (Match date in dates)
           // {
           //     string day = date.Groups["day"].Value;
           //     string month = date.Groups["month"].Value;
           //     string year = date.Groups["year"].Value;
           //
           //     Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
           // }
        }
    }
}
