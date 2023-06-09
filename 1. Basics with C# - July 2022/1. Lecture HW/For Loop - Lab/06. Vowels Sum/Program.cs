using System;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();

            int textLength=text.Length;
            int sum = 0;

            for(int i = 0; i <= textLength-1; i++)
            {
                char letter = text[i];
                switch (letter)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;

                }
            }
            Console.WriteLine(sum);
        }
    }
}
