using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            // 1 way:

            //string[] words = Console.ReadLine().Split();
            //
            //foreach(var word in words)
            //{
            //    if (word.Length % 2 == 0)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

            // 2 way:

           // string[]words=Console.ReadLine()
           //     .Split()
           //     .Where(x=>x.Length%2==0)
           //     .ToArray();
           //
           // foreach(var word in words)
           // {
           //    Console.WriteLine(word);
           // }

            // 3 way: static void main - не трябва да има {}

          // =>Console.ReadLine()
          //     .Split()
          //     .Where(x => x.Length % 2 == 0)
          //     .ToList()
          //     .ForEach(Console.WriteLine);
        }
    }
}

