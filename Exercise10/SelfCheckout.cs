namespace Exercise10;
internal static class SelfCheckout
{
    static void Main()
    {
        Console.Write("Enter the price of item 1: ");
        string? price1Input = Console.ReadLine();
        Console.Write("What is the Ceiling Width? ");
        string? widthInput = Console.ReadLine();

        if (double.TryParse(lengthInput, out double lengthOutput) && double.TryParse(widthInput, out double widthOutput))
        {
            double squarefeet = lengthOutput * widthOutput;
            double gallons = Math.Ceiling(squarefeet / 350);
            Console.WriteLine($"You will need to purchase {gallons} gallons of ");
            Console.WriteLine($"paint to the cover {squarefeet} square feet.");
        }
        else
        {
            Console.WriteLine("Please enter an integer number");
        }
    }
}