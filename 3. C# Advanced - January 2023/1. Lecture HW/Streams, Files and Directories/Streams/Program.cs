using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("../../../myfile.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[]
                {
                    65,66
                };
                
                fileStream.Write(buffer);
            }
        }
    }
}

