using System;

class Counting
{
    static void Main()
    { 
        Console.WriteLine("Show me what you got");
        string inputString = Console.ReadLine();
        int stringLength = inputString.Length;
        Console.WriteLine(inputString + " has " + stringLength + " characters");
    }
}