namespace Exercise28;

internal static class AddingNumbers
{
    static void Main()
    {
        int total = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            total += number;
        }

        Console.WriteLine("The total is " + total);
    }
}