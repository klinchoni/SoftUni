using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue= Console.ReadLine();
            string secondValue= Console.ReadLine();

            if (type == "int")
            {
                int firstInt=int.Parse(firstValue);
                int secondInt=int.Parse(secondValue);

                int result=GetMax(firstInt, secondInt);

                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar=char.Parse(firstValue);
                char secondChar=char.Parse(secondValue);

                char result=GetMax(firstChar, secondChar);

                Console.WriteLine(result);
            }
            else if(type == "string")
            {
               string result= GetMax(firstValue, secondValue);

                Console.WriteLine(result);
            }
        }

        static string GetMax(string a, string b)
        {

            //"aaa".CompareTo("bbb")
            //->(<0)(0)(>0)
            //if left side is lower - < 0
            //if equal - 0
            //if left side is greater - > 0


           int result=a.CompareTo(b);

            if (result > 0)
            {
                return a;
            }

            return b;
        }

        static char GetMax(char a,char b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        static int GetMax(int a,int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}
