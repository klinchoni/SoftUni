using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string kegName = string.Empty;
            for (int i=0; i<n; i++)
            {
                string model=Console.ReadLine();
                float radius=float.Parse(Console.ReadLine());
                int height=int.Parse(Console.ReadLine());
                double volume= Math.PI * radius * radius * height;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    kegName = model;
                }
            }
            Console.WriteLine(kegName);
        }
    }
}
