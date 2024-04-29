namespace Exercise01;
internal static class SayingHello
{
    static void Main()
    {
        Console.WriteLine("New Phone, who dis?");
        var inputName = Console.ReadLine();
        Console.WriteLine("Hello, " + inputName + "!");
    }
}