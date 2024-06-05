namespace Exercise38;

internal static class FilteringValues
{
    static void Main()
    {
        Console.Write("Enter a list of numbers, separated by spaces: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int[] evenNumbers = filterEvenNumbers(numbers);

        Console.WriteLine("The even numbers are " + string.Join(" ", evenNumbers));
    }

    static int[] filterEvenNumbers(string[] numbers)
    {
        int[] temp = new int[numbers.Length];
        int count = 0;
        foreach (string num in numbers)
        {
            if (int.TryParse(num, out int number) && number % 2 == 0)
            {
                temp[count++] = number;
            }
        }
        int[] evenNumbers = new int[count];
        Array.Copy(temp, evenNumbers, count);
        return evenNumbers;
    }
}

