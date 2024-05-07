namespace Exercise08;
internal static class PizzaParty
{
    static void Main()
    {
        Console.Write("How many people? ");
        string? peopleInput = Console.ReadLine();
        Console.Write("How many pizzas do you have? ");
        string? pizzaInput = Console.ReadLine();
        Console.Write("How many slices per pizza? ");
        string? slicesInput = Console.ReadLine();

        if (double.TryParse(peopleInput, out double peopleOutput) && double.TryParse(pizzaInput, out double pizzaOutput) 
            && double.TryParse(slicesInput, out double slicesOutput))
        {
            double totalSlices = pizzaOutput * slicesOutput;
            double slicesPerPerson = Math.Floor(totalSlices / peopleOutput);
            double leftOver = totalSlices % peopleOutput; 
            Console.WriteLine($"{pizzaOutput} people with {pizzaOutput} pizzas");
            Console.WriteLine($"Each person gets {slicesPerPerson} pieces of pizza.");
            Console.WriteLine($"There are {leftOver} leftover pieces.");
        }
        else
        {
            Console.WriteLine("Please enter an integer number");
        }
    }
}