namespace Exercise22;

internal static class ComparingNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 == num2 || num1 == num3 || num2 == num3)
        {
            Console.WriteLine("Numbers are not all different. Exiting the program.");
            return;
        }

        int largest = num1;

        if (num2 > largest)
        {
            largest = num2;
        }

        if (num3 > largest)
        {
            largest = num3;
        }

        Console.WriteLine($"The largest number is {largest}.");
    }
}