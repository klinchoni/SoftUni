﻿using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Streams3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("../../../myfile3.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[3];
                while (fileStream.Read(buffer, 0, 3) > 0)
                {
                    Console.WriteLine("Reading next 3 bytes: ");
                    Console.WriteLine($"{String.Join(" ", buffer)}");
                    Console.WriteLine($"{String.Join("", buffer.Select(b => (char)b))}");
                    Console.WriteLine($"Stream position: {fileStream.Position}");
                }

                fileStream.Position = 0;

            }
            using (var stream = new FileStream("../../../myfile3.txt", FileMode.Append))
            {
                string input = Console.ReadLine();

                 byte[] writeBuffer = input.ToCharArray().Select(c => (byte)c).ToArray();

                stream.Write(writeBuffer, 0, writeBuffer.Length);
            }
        }
    }
}
