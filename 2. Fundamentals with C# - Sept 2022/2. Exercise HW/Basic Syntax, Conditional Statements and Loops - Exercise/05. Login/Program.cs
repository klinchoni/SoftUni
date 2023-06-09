using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username=Console.ReadLine();
            string password = string.Empty;

            for(int i=username.Length-1; i>=0; i--)
            {
                char currCh = username[i];
                password += currCh;
            }

            int totalTries = 1;
            string enteredPass;

            while ((enteredPass = Console.ReadLine()) != password)
            {
                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                totalTries++;
            }
            if (totalTries < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
