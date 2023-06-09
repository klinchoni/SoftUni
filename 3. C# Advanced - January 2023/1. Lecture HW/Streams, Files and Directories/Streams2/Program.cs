using System;
using System.IO;
using System.Linq;

namespace Streams2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("../../../myfile2.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[3];
                while (fileStream.Read(buffer, 0, 3) > 0)
                {
                    Console.WriteLine("Reading next 3 bytes: ");
                    Console.WriteLine($"{String.Join(" ", buffer)}");
                    Console.WriteLine($"{String.Join("", buffer.Select(b => (char)b))}");
                    Console.WriteLine($"Stream position: {fileStream.Position}");

                    // Reads infinity

                    // if(fileStream.Position>=6)
                    // {
                    //   fileStream.Position = 0;
                    // }


                    while (fileStream.Read(buffer, 0, 3) > 0)
                    {
                        Console.WriteLine("Reading next 3 bytes: ");
                        Console.WriteLine($"{String.Join(" ", buffer)}");
                        Console.WriteLine($"{String.Join("", buffer.Select(b => (char)b))}");
                       Console.WriteLine($"Stream position: {fileStream.Position}");
                    }
                }
                fileStream.Position = 0;
            }
        }
    }
}
