using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCounter=int.Parse(Console.ReadLine());
            double headsetPrice=double.Parse(Console.ReadLine());
            double mousePrice=double.Parse(Console.ReadLine());
            double keyboardPrice=double.Parse(Console.ReadLine());
            double displayPrice=double.Parse(Console.ReadLine());

            int headsetCounter = lostGamesCounter / 2;
            int mouseCounter=lostGamesCounter / 3;
            int keyboardCounter=lostGamesCounter / 6;
            int displayCounter=lostGamesCounter / 12;

            double expenses=(headsetCounter*headsetPrice)+(mouseCounter*mousePrice)+
                (keyboardCounter*keyboardPrice)+(displayCounter*displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
