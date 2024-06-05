namespace Exercise33;

internal static class Magic8Ball
{
    static void Main()
    {
        string[] responses = { "Yes", "No", "Maybe", "Ask again later" };
        Random random = new Random();

        Console.Write("What's your question? ");
        Console.ReadLine();  

        Console.WriteLine(responses[random.Next(responses.Length)]);
    }
}