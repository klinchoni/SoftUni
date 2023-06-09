using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int count = 0;
            string currentBook = Console.ReadLine();
            while (currentBook!=favBook)
            {
                if(currentBook == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    break;
                }
                count++;
                currentBook = Console.ReadLine();
            }
            if (currentBook == favBook)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            
        }
    }
}
