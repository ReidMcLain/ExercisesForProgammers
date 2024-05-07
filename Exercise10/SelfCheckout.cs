namespace Exercise10;
internal static class SelfCheckout
{
    static void Main()
    {
        
        //Less effecient first try
        
        // Console.Write("Enter the price of item 1: ");
        // string? price1Input = Console.ReadLine();
        // Console.Write("Enter the quantity of item 1: ");
        // string? quantity1Input = Console.ReadLine();
        // Console.Write("Enter the price of item 2: ");
        // string? price2Input = Console.ReadLine();
        // Console.Write("Enter the quantity of item 2: ");
        // string? quantity2Input = Console.ReadLine();
        // Console.Write("Enter the price of item 3: ");
        // string? price3Input = Console.ReadLine();
        // Console.Write("Enter the quantity of item 3: ");
        // string? quantity3Input = Console.ReadLine();
        //
        //
        // if ((decimal.TryParse(price1Input, out decimal price1Output) && decimal.TryParse(quantity1Input, out decimal quantity1Output)
        //    && (decimal.TryParse(price2Input, out decimal price2Output) && decimal.TryParse(quantity2Input, out decimal quantity2Output)
        //    && (decimal.TryParse(price3Input, out decimal price3Output) && decimal.TryParse(quantity3Input, out decimal quantity3Output)))))
        // {
        //     decimal subtotal = (price1Output * quantity1Output) + (price2Output * quantity2Output) +
        //                        (price3Output * quantity3Output);
        //     decimal tax = subtotal * 0.055m; //m suffix for decimal literal
        //     decimal total = subtotal + tax;    
        //     Console.WriteLine($"Subtotal: {subtotal.ToString("C")}");
        //     Console.WriteLine($"Tax: {tax.ToString("C")}");
        //     Console.WriteLine($"Total: {total.ToString("C")}");
        // }
        // else
        // {
        //     Console.WriteLine("Please enter an integer number");
        // }
        
        //More efficient second try
        
        {
            const int itemCount = 3; // Number of items
            decimal[] prices = new decimal[itemCount]; // Array to store prices
            decimal[] quantities = new decimal[itemCount]; // Array to store quantities

            //Loop through itemCount and return the same prompt incrementing by 1 until 3 
            for (int i = 0; i < itemCount; i++)
            {
                Console.Write($"Enter the price of item {i + 1}: ");
                string? priceInput = Console.ReadLine();
                Console.Write($"Enter the quantity of item {i + 1}: ");
                string? quantityInput = Console.ReadLine();
                
                //still in the forloop, we convert price and quantity for indices 1-3
                if (decimal.TryParse(priceInput, out decimal price) && decimal.TryParse(quantityInput, out decimal quantity))
                {
                    prices[i] = price;
                    quantities[i] = quantity;
                }
                else
                {
                    Console.WriteLine("Please enter valid numeric values.");
                    return; // Exit the program if input is invalid
                }
            }

            decimal subtotal = 0; //instantiate subtotal
            
            //loop through each matching indices of price and quantity to create a new subtotal
            for (int i = 0; i < itemCount; i++)
            {
                subtotal += prices[i] * quantities[i];
            }

            decimal tax = subtotal * 0.055m; // Tax rate of 5.5%
            decimal total = subtotal + tax;

            Console.WriteLine($"Subtotal: {subtotal.ToString("C")}");
            Console.WriteLine($"Tax: {tax.ToString("C")}");
            Console.WriteLine($"Total: {total.ToString("C")}");
        }
    }
}