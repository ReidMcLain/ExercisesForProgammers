namespace Exercise30;

internal static class MultipleTable
{
    static void Main()
    {
        for (int i = 0; i <= 12; i++)  // Outer loop for each multiplication table
        {
            for (int j = 0; j <= 12; j++)  // Inner loop for each line of the table
            {
                Console.WriteLine($"{i} x {j} = {i * j}");  // Print the product
            }
            Console.WriteLine();  // Print a blank line after each table for better readability
        } 
    }
}