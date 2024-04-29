namespace Exercise03;
internal static class AuthorQuote
{
    static void Main()
    {
        Console.WriteLine("What is the quote? ");
        var inputQuote = Console.ReadLine();
        Console.WriteLine("Who said it? ");
        var inputAuthor = Console.ReadLine();
        Console.WriteLine($"{inputAuthor} says, \"{inputQuote}\"");
    }
}