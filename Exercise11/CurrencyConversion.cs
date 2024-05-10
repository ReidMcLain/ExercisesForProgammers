namespace Exercise11;
internal static class CurrencyConversion
{
    static void Main()
    {
        Console.Write("how many euros are you exchanging? ");
        string? euroInput = Console.ReadLine();
        Console.Write("What is the exchange rate? ");
        string? exchangeRateInput = Console.ReadLine();
        
        if (double.TryParse(euroInput, out double euroOutput) && double.TryParse(exchangeRateInput, out double exchangeRateOutput))
        {
            double usDollars = (euroOutput * exchangeRateOutput / 100);
            Console.WriteLine($"{euroOutput} euros at an exchange rate of {exchangeRateOutput} is");
            Console.WriteLine($"{usDollars.ToString("N2")} U.S. dollars.");
        }
        else
        {
            Console.WriteLine("Please enter an integer number");
        }
    }
}