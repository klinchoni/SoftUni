using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine(); // Programming is cool!
            var sb = new StringBuilder();
            foreach (char currentChar in text)
            {
                int currentPositon = currentChar; // currChar = "P" in int => 80
                currentPositon += 3;
                sb.Append((char)currentPositon); // 83 int into char => 'S'
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
