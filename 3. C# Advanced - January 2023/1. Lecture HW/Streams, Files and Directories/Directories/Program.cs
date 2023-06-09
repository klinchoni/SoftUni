using System;
using System.IO;

namespace Directories
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // CREATE 

           //for (int i = 0; i < 10; i++)
           //{
           //    Directory.CreateDirectory($"../../../{i+1}.CustomFolder");
           //}

            // DELETE

            //for (int i = 0; i < 10; i++)
            //{
            //    Directory.Delete($"../../../{i + 1}.CustomFolder");
            //}

            // MOVE

           for (int i = 0; i < 10; i++)
           {
               Directory.Move($"../../../CustomFolder/{i + 1}.MovedCustomFolder", $"../../../CustomFolder/{i + 1}.CustomFolder");
           }
        }
    }
}
