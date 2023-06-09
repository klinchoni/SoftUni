using System;

namespace _06._Barcode_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number1=int.Parse(Console.ReadLine());
           int number2=int.Parse(Console.ReadLine());   
           
            for(int barcode1 = number1 / 1000; barcode1 <= number2/1000; barcode1++)
            {
                if (barcode1 % 2 == 0)
                {
                    continue;
                }
                for(int barcode2 = number1 / 100 % 10; barcode2 <= number2 / 100 % 10; barcode2++)
                {
                    if (barcode2 % 2 == 0)
                    {
                        continue;
                    }
                    for(int barcode3 = number1 / 10 % 10; barcode3 <= number2 / 10 % 10; barcode3++)
                    {
                        if(barcode3 % 2 == 0)
                        {
                            continue;
                        }
                        for(int barcode4 = number1 % 10; barcode4 <= number2 % 10; barcode4++)
                        {
                            if(barcode4 % 2 == 0)
                            {
                                continue;
                            }

                            Console.Write($"{barcode1}{barcode2}{barcode3}{barcode4} ");
                        }
                    }
                }
            }
        }
    }
}
