using System;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string otherSymbols = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    digits += str[i];
                }
                else if (Char.IsLetter(str[i]))
                {
                    letters += str[i];
                }
                else
                {
                    otherSymbols += str[i];
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherSymbols);
        }
    }
}
