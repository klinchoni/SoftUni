using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //2 WAY
             
           // string pattern = @"\+359(-| )2\1\d{3}\1\d{4}\b";
           // string phones = Console.ReadLine();
           //
           // MatchCollection matches = Regex.Matches(phones, pattern);
           //
           // string[] matchedPhones = matches.Cast<Match>()
           //                                 .Select(x => x.Value.Trim())
           //                                 .ToArray();
           //
           // Console.WriteLine(String.Join(", ", matchedPhones));
        }
    }
}
