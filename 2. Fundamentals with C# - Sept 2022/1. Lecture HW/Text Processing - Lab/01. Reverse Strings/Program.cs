using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            while (str != "end")
            {
                string reversed = string.Empty;
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reversed += str[i];
                }

                Console.WriteLine($"{str} = {reversed}");
                str = Console.ReadLine();
            }
        }
    }
}
