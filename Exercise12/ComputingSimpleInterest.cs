namespace Exercise12;
internal static class ComputingSimpleInterest
{
    static void Main()
    {
        Console.Write("Enter the principal: ");
        string? principalInput = Console.ReadLine();
        Console.Write("Enter the rate of interest: ");
        string? interestInput = Console.ReadLine();
        Console.Write("Enter the number of years: ");
        string? yearsInput = Console.ReadLine();
        
        if (double.TryParse(principalInput, out double principalOutput) && double.TryParse(interestInput, out double interestOutput)
            && double.TryParse(yearsInput, out double yearsOutput))
        {
            double investment = (principalOutput * (1 + ((interestOutput/100) * yearsOutput )));
            Console.WriteLine($"After {yearsOutput} at {interestOutput}%, the investment will");
            Console.WriteLine($"be worth {investment.ToString("C")}");
        }
        else
        {
            Console.WriteLine("Please enter an integer number");
        }
    }
}