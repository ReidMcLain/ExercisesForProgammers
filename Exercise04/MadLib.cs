namespace Exercise04;
internal static class MadLib
{
    static void Main()
    {
        Console.WriteLine("Enter a noun: ");
        var inputNoun = Console.ReadLine();
        Console.WriteLine("Enter a verb: ");
        var inputVerb = Console.ReadLine();
        Console.WriteLine("Enter an adjective: ");
        var inputAdjective = Console.ReadLine();
        Console.WriteLine("Enter an adverb: ");
        var inputAdverb = Console.ReadLine();
        Console.WriteLine($"Do you {inputVerb} your {inputAdjective} {inputNoun} {inputAdverb}? That's hilarious!");
    }
}