using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(expression.Reverse());

            while (stack.Count > 1)
            {
                int n1 = int.Parse(stack.Pop());
                char operand = char.Parse(stack.Pop());
                int n2 = int.Parse(stack.Pop());

                switch (operand)
                {
                    case '+':
                        stack.Push((n1 + n2).ToString());
                        break;

                    case '-':
                        stack.Push((n1 - n2).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
