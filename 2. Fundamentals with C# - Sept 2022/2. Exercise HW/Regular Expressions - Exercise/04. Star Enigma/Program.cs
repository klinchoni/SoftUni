using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
        
            string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:\d+[^\@\-\!\:\>]*?\!(?<attackType>A|D)\![^\@\-\!\:\>]*?\-\>\d+";
            Regex regex = new Regex(pattern);
        
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(encryptedMessage);
        
                Match match = regex.Match(decryptedMessage);
                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;
                    string attackType = match.Groups["attackType"].Value;
        
                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }
        
            PrintPlanets(attackedPlanets, "Attacked");
            PrintPlanets(destroyedPlanets, "Destroyed");
        }
        
        static string DecryptMessage(string encryptedMessage)
        {
            //We need to be fast!!!
            StringBuilder decryptedMessage = new StringBuilder();
            int decryptionStep = GetDecryptionStep(encryptedMessage);
        
            foreach (char oldCh in encryptedMessage)
            {
                decryptedMessage.Append((char)(oldCh - decryptionStep));
            }
        
            return decryptedMessage.ToString();
        }
        
        static int GetDecryptionStep(string encryptedMessage)
        {
            int decryptionStep = 0;
            foreach (char ch in encryptedMessage.ToLower())
            {
                if (ch == 's' || ch == 't' || ch == 'a' || ch == 'r')
                {
                    decryptionStep++;
                }
            }
        
            return decryptionStep;
        }
        
        static void PrintPlanets(List<string> planets, string attackType)
        {
            Console.WriteLine($"{attackType} planets: {planets.Count}");
            foreach (string planetName in planets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planetName}");
            }
        }

        // 2 WAY
       // static void Main(string[] args)
       // {
       //     int n = int.Parse(Console.ReadLine());
       //     List<string> attackedPlanets = new List<string>();
       //     List<string> destroyedPlanets = new List<string>();
       //
       //     for (int i = 0; i < n; i++)
       //     {
       //         string message = Console.ReadLine();
       //         string decrypted = string.Empty;
       //         MatchCollection matches = Regex.Matches(message, @"[STARstar]");
       //
       //         for (int k = 0; k < message.Length; k++)
       //         {
       //             decrypted += (char)(message[k] - matches.Count);
       //         }
       //
       //         string pattern = @"@[^@\-!:>]*?(?<planet>[A-Z][a-z]+)[^@\-!:>]*?:[^@\-!:>]*?(?<population>\d+)[^@\-!:>]*?![^@\-!:>]*?(?<attackType>[AD])[^@\-!:>]*?![^@\-!:>]*?->[^@\-!:>]*?(?<soldiers>\d+)[^@\-!:>]*?";
       //
       //         Match planet = Regex.Match(decrypted, pattern);
       //         if (planet.Groups["attackType"].Value == "A")
       //         {
       //             attackedPlanets.Add(planet.Groups["planet"].Value);
       //         }
       //         else if (planet.Groups["attackType"].Value == "D")
       //         {
       //             destroyedPlanets.Add(planet.Groups["planet"].Value);
       //         }
       //     }
       //
       //     Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
       //     foreach (string planet in attackedPlanets.OrderBy(x => x))
       //     {
       //         Console.WriteLine($"-> {planet}");
       //     }
       //
       //     Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
       //     foreach (string planet in destroyedPlanets.OrderBy(x => x))
       //     {
       //         Console.WriteLine($"-> {planet}");
       //     }
       // }
    }
}

