namespace Exercise24;

internal static class AnagramChecker
{
    static void Main()
    {
        Console.WriteLine("Enter two strings and I'll tell you if they are anagrams: ");
        Console.Write("Enter the first string: ");
        string? firstString = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string? secondString = Console.ReadLine();

        bool result = isAnagram(firstString, secondString);
        if (result)
        {
            Console.WriteLine($"{firstString} and {secondString} are anagrams.");
        }
        else
        {
            Console.WriteLine($"{firstString} and {secondString} are not anagrams.");
        }
    }

    static bool isAnagram(string first, string second)
    {
        if (first.Length != second.Length)
        {
            return false;
        }

        char[] firstArray = first.ToLower().ToCharArray();
        char[] secondArray = second.ToLower().ToCharArray();
        Array.Sort(firstArray);
        Array.Sort(secondArray);
        return Enumerable.SequenceEqual(firstArray, secondArray);
    }
}

