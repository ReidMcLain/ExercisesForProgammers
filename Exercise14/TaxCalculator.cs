namespace Exercise14;
internal static class TaxCalculator
{
    static void Main()
    {
        Console.Write("What is the order amount? ");
        string? orderInput = Console.ReadLine();
        Console.Write("What is the state? ");
        string? stateInput = Console.ReadLine()?.ToUpper();
        
        if (double.TryParse(orderInput, out double orderOutput)) 
        {
            double total = orderOutput;
            double tax = 5.5;
            double subtotal = total * tax/100;
            double taxedTotal = total + subtotal;
            Console.WriteLine($"The total is {total.ToString("C")}.");
            if (stateInput == "WI" || stateInput == "WISCONSIN")
            {
                Console.WriteLine($"The subtotal is {total.ToString("C")}.");
                Console.WriteLine($"The tax is {subtotal.ToString("C")}.");
                Console.WriteLine($"The total is {taxedTotal.ToString("C")}." );
            }
        }
        else
        {
            Console.WriteLine("Please enter an integer number");
        }
    }
}