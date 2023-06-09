using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read the input from the console
            string[] usernames = Console.ReadLine()
                  .Split(", ");
            // interate throug all the usernames 
            foreach (string currentName in usernames)
            {
                // sh //pesho
                if (currentName.Length > 3 && currentName.Length <= 16)
                {
                    // check if the userName is valid 
                    bool isUsarnameValid = true;
                    foreach (char currentChar in currentName) // => charrArray = [s, h]
                                                              // => [p, e, s, h, o]
                    {
                        if (!(char.IsLetterOrDigit(currentChar) || currentChar == '-' || currentChar == '_'))
                        {
                            isUsarnameValid = false;
                            break;
                        }
                    }

                    if (isUsarnameValid)
                    {
                        Console.WriteLine(currentName);  // pesho
                    }
                }
            }
        }
    }
}
