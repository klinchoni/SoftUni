using System;
using System.IO;

namespace _01._Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 WAY 

            // StreamReader reader = new StreamReader("../../../input.txt");

            // string input = reader.ReadToEnd();
            //
            // reader.Close();
            //
            // Console.WriteLine(input);

            //2 WAY

            // StreamReader reader = new StreamReader("../../../input.txt");
            //
            // using (reader)
            // {
            //     string input = reader.ReadToEnd();
            //
            //     Console.WriteLine(input);
            // }
            //
            // Console.WriteLine("Stream is closed!");

            //3 WAY 

            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string input = reader.ReadToEnd();

                Console.WriteLine(input);
            }

            Console.WriteLine("Stream is closed!");
        }
    }
}
