namespace Exercise07;
internal static class AreaOfARectangularRoom
{
    static void Main()
    {
        Console.Write("What is the length of the room in feet? ");
        string? lengthInput = Console.ReadLine();
        Console.Write("What is the wdith of the room in feet? ");
        string? widthInput = Console.ReadLine();

        if (double.TryParse(lengthInput, out double lengthOutput) && double.TryParse(widthInput, out double widthOutput))
        {
            double area = lengthOutput * widthOutput;
            double metricArea = area * 0.09290304;
            Console.WriteLine($"You entered dimensions of {lengthOutput} feet by {widthOutput} feet.");
            Console.WriteLine("The area is");
            Console.WriteLine($"The area is {area} square feet");
            Console.WriteLine($"{metricArea} square meters");
        }
        else
        {
            Console.WriteLine("Please enter an integer number");
        }
    }
}