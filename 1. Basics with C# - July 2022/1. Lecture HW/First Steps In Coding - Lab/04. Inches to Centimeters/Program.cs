using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double number = double.Parse(Console.ReadLine());
           double inches = 2.54;
            double centimetres = number * inches;
            Console.WriteLine(centimetres);
        }
    }
}
