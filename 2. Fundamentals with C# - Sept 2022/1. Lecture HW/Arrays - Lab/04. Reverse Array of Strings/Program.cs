using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // string[] text = Console.ReadLine()
          //     .Split()
          //     .ToArray();
          //
          // for (int i = 0; i < text.Length / 2; i++)
          // {
          //     string temp = text[i];
          //     text[i] = text[text.Length - i - 1];
          //     text[text.Length - i - 1] = temp;
          // }
          // Console.WriteLine(String.Join(' ', text));

            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').ToArray().Reverse().ToArray()));
        }
    }
}
