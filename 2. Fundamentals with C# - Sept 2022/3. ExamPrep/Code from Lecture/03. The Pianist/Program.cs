using System;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //key -> Piece
            //value -> "composer:key"

            Dictionary<string, string> pieces
                = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');
                string piece = input[0];
                string composerAndKey = $"{input[1]}:{input[2]}";

                if (!pieces.ContainsKey(piece))
                {
                    pieces.Add(piece, composerAndKey);
                }
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandInfo = command.Split('|');
                string action = commandInfo[0]; //Add

                if (action == "Add")
                {
                    string piece = commandInfo[1];
                    string composer = commandInfo[2];
                    string key = commandInfo[3];

                    if (!pieces.ContainsKey(piece))
                    {
                        pieces.Add(piece, $"{composer}:{key}");
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    string piece = commandInfo[1];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (action == "ChangeKey")
                {
                    string piece = commandInfo[1];
                    string newKey = commandInfo[2];

                    if (!pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        //Moonlight Sonata|Beethoven|C# Minor
                        //["Moonlight Sonata", "Beethoven:C# Minor"]

                        string[] value = pieces[piece].Split(':');
                        value[1] = newKey;

                        pieces[piece] = string.Join(":", value);

                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var piece in pieces)
            {
                string[] composerKey = piece.Value.Split(':');
                Console.WriteLine($"{piece.Key} -> Composer: {composerKey[0]}, Key: {composerKey[1]}");
            }
        }
    }
}
