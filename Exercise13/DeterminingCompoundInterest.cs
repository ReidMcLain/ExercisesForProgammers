namespace Exercise13;
internal static class DeterminingCompoundInterest
{
    static void Main()
    {
        Console.Write("What is the principal amount? ");
        string? principalInput = Console.ReadLine();
        Console.Write("What is the rate? ");
        string? rateInput = Console.ReadLine();
        Console.Write("What is the number of year? ");
        string? yearsInput = Console.ReadLine();
        Console.Write("What is the number of times the interest in compounded per year? ");
        string? compoundInput = Console.ReadLine();
        
        if (double.TryParse(principalInput, out double principalOutput) && double.TryParse(rateInput, out double rateOutput) 
         && double.TryParse(yearsInput, out double yearsOutput) && double.TryParse(compoundInput, out double compoundOutput))
        {
            double investment = principalOutput * Math.Pow((1 + ((rateOutput/100) / compoundOutput)), (compoundOutput * yearsOutput));
            Console.WriteLine($"{principalOutput.ToString("C")} invested at {rateOutput}% for {yearsOutput} years");
            Console.WriteLine($"compounded 4 times per year is {investment.ToString("C")}");
        }
        else
        {
            Console.WriteLine("Please enter an integer number");
        }
    }
}