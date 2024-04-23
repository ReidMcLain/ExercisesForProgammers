using System;

class AuthorQuote
{
    static void Main()
    {
        Console.Write("What is the quote? ");
        var inputQuote = Console.ReadLine();
        Console.Write("Who said it? ");
        var inputAuthor = Console.ReadLine();
        Console.WriteLine($"{inputAuthor} says, \"{inputQuote}\"");
    }
}