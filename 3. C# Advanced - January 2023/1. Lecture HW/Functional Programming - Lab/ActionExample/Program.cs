﻿Action<string> print = PrintHello;

print("Yoanna");

Action printWithoutName = Print;
printWithoutName();


void PrintHello(string name)
{
    Console.WriteLine("Hello " + name);
}

void Print()
{
    Console.WriteLine("Hello ");
}
