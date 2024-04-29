namespace Exercise02;
internal static class Counting
{
    static void Main()
    { 
        Console.WriteLine("Show me what you got");
        //added ? to string to make inputString nullable
        string? inputString = Console.ReadLine();
        //The ! at the end of inputString is a Null-forgiving Operater, tells compiler to assume inputString is not null 
        int stringLength = inputString!.Length;
        Console.WriteLine(inputString + " has " + stringLength + " characters");
    }
}