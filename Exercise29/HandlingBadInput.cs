namespace Exercise29;

internal static class HandlingBadInput
{
    static void Main()
    {
        while (true)  // Loop indefinitely until a valid input is received
        {
            Console.Write("What is the rate of return? ");
            string RateOfReturnString = Console.ReadLine();

            try
            {
                double rateOfReturnDouble = Convert.ToDouble(RateOfReturnString); //double is good for decimal and calculations

                if (rateOfReturnDouble <= 0)  //handle for inputs equal to or below zero
                {
                    Console.WriteLine("Sorry. That's not a valid input.");
                }
                else
                {
                    int years = (int)(72 / rateOfReturnDouble); //we want int here for integer years
                    Console.WriteLine($"It will take {years} years to double your initial investment.");
                    break;  // Exit the loop on valid input
                }
            }
            catch (FormatException)  // Handle non-numeric input
            {
                Console.WriteLine("Sorry. That's not a valid input.");
            }
        }
    }
}

