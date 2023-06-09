using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(word))
            {
                int startIndex = text.IndexOf(word);

                text=text.Remove(startIndex, word.Length);  
            }

            Console.WriteLine(text);
           // 2 WAY
            //string pattern = Console.ReadLine();
            //string str = Console.ReadLine();
            //
            //while (true)
            //{
            //    int index = str.ToLower().IndexOf(pattern.ToLower());
            //    if (index < 0)
            //    {
            //        break;
            //    }
            //    str = str.Remove(index, pattern.Length);
            //}
            //
            //Console.WriteLine(str);
        }
    }
}
