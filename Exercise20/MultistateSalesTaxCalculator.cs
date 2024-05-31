namespace Exercise20;

internal static class MultistateSalesTaxCalculator
{
    static void Main()
    {
        Console.Write("What is the order amount? ");
        double orderAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("What state do you live in? ");
        string state = Console.ReadLine().Trim();

        double taxRate = 0.0;
        double totalTax = 0.0;
        double totalAmount = orderAmount;

        switch (state.ToLower())
        {
            case "wisconsin":
                Console.Write("What county do you live in? ");
                string county = Console.ReadLine().Trim().ToLower();

                if (county == "eau claire")
                {
                    taxRate = 0.005;
                }
                else if (county == "dunn")
                {
                    taxRate = 0.004;
                }
                break;
            case "illinois":
                taxRate = 0.08;
                break;
        }

        if (taxRate > 0)
        {
            totalTax = Math.Ceiling(orderAmount * taxRate * 100) / 100;
            totalAmount += totalTax;
        }

        if (totalTax > 0)
        {
            Console.WriteLine($"The tax is {totalTax.ToString("C")}.");
        }
        Console.WriteLine($"The total is {totalAmount.ToString("C")}.");
    }
}