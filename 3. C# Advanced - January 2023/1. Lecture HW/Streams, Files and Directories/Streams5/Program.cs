﻿using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Streams5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("../../../myfile5.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[3];

                while (fileStream.Read(buffer, 0, 3) > 0)
                {
                    string bufferAsString=Encoding.UTF8.GetString(buffer);
                    Console.WriteLine("Reading next 3 bytes: ");
                    Console.WriteLine($"{String.Join(" ", buffer)}");
                    Console.WriteLine($"{bufferAsString}");
                    Console.WriteLine($"Stream position: {fileStream.Position}");
                }

                fileStream.Position = 0;
            }

            using (var stream = new FileStream("../../../myfile5.txt", FileMode.Append))
            {
                string input = Console.ReadLine();

                byte[] writeBuffer = Encoding.Unicode.GetBytes(input);

                stream.Write(writeBuffer, 0, writeBuffer.Length);
            }
        }
    }
}
