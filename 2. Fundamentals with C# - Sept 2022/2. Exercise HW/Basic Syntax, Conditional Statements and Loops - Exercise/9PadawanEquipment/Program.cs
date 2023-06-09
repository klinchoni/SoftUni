using System;

namespace _9PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double moneyAmount = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double priceOfLightSaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double totalLightSabersPrice = Math.Ceiling(studentCount + 0.1 * studentCount) * priceOfLightSaber;
            double totalRobesPrice = studentCount * priceOfRobe;
            double totalBeltPrice = studentCount * priceOfBelt;

            int freeBelt = (studentCount / 6);

            double totalPriceOfAll = totalLightSabersPrice + totalRobesPrice + (totalBeltPrice - (freeBelt * priceOfBelt));

            if (moneyAmount >= totalPriceOfAll)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPriceOfAll:f2}lv.");

            }

            else if (moneyAmount < totalPriceOfAll)
            {
                Console.WriteLine($"John will need {totalPriceOfAll - moneyAmount:f2}lv more.");
            }
        }
    }
}
