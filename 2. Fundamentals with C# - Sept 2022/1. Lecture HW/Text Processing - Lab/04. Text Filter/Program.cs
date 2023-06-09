using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords=Console.ReadLine()
                .Split(", ");
            string text=Console.ReadLine();

            foreach(var currentBannedWord in bannedWords)
            {
                text=text.Replace(
                    currentBannedWord,
                    new string('*',currentBannedWord.Length));
            }

            Console.WriteLine(text);
            //2 WAY
           // string[] forbiddenWords = Console.ReadLine().Split(", ");
           // string text = Console.ReadLine();
           //
           // foreach (string forbiddenWord in forbiddenWords)
           // {
           //     text = text.Replace(forbiddenWord, new string('*', forbiddenWord.Length));
           // }
           //
           // Console.WriteLine(text);
        }
    }
}
