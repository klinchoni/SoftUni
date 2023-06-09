using System;
using System.IO;

namespace Streams1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("../../../myfile1.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, (int)fileStream.Length);
                
                 Console.WriteLine($"{String.Join(" ",buffer)}");
            }
        }
    }
}
