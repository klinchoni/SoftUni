using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape=Console.ReadLine();
            double area = 0;
            if (shape == "square")
            {
                double side=double.Parse(Console.ReadLine());
                area = side * side;
                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "rectangle")
            {
                double sideA=double.Parse(Console.ReadLine());
                double sideB=double.Parse(Console.ReadLine());
                area=sideA * sideB;
                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "circle")
            {
                double radius=double.Parse(Console.ReadLine());
                area = (radius * radius) * Math.PI;
                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double h=double.Parse(Console.ReadLine());
                area = (sideA * h)/2;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
