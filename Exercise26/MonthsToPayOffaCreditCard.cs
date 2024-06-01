namespace Exercise26;

internal static class MonthsToPayOffaCreditCard
{
    static void Main()
    {
        Console.Write("What is your balance? ");
        string? balanceString = Console.ReadLine();
        Console.Write("What is the APR on the card (as a percent)? ");
        string? APRString = Console.ReadLine();
        Console.Write("What is the monthly payment you can make? ");
        string? monthlyPaymentString = Console.ReadLine();
        if (double.TryParse(balanceString, out double balance) && 
            double.TryParse(APRString, out double APR) &&
            double.TryParse(monthlyPaymentString, out double monthlyPayment))
        {
            int months = CalculateMonthsUntilPaidOff(balance, APR, monthlyPayment);
            Console.WriteLine($"It will take you {months} months to pay off this card.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
    }

    private static int CalculateMonthsUntilPaidOff(double balance, double APR, double monthlyPayment)
    {
        double dailyRate = APR / 36500;  // APR is entered as a percentage and divided by 36500 to get daily rate.
        double numerator = Math.Log(1 + (balance / monthlyPayment) * (1 - Math.Pow(1 + dailyRate, 30)));
        double denominator = Math.Log(1 + dailyRate);
        double months = -1 / 30.0 * numerator / denominator;
        return (int)Math.Ceiling(months);  // Round up to the nearest month
    }
}