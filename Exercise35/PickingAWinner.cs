using System;
using System.Collections.Generic;

namespace Exercise35;

internal static class PickingAWinner
{
    static void Main()
    {
        List<string> contestants = new List<string>();
        Random random = new Random();

        // Capture names until a blank entry is received
        while (true)
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name)) break;
            contestants.Add(name);
        }

        // Select and announce a random winner if there are any contestants
        if (contestants.Count > 0)
        {
            string winner = contestants[random.Next(contestants.Count)];
            Console.WriteLine($"The winner is... {winner}.");
        }
        else
        {
            Console.WriteLine("No contestants were entered.");
        }
    }
}