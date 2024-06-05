
internal static class ComputingStatistics
{
    static void Main()
    {
        List<int> responseTimes = new List<int>();
        string input;

        // Collecting response times
        while (true)
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            if (int.TryParse(input, out int time))
            {
                responseTimes.Add(time);
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number or 'done' to finish.");
            }
        }

        if (responseTimes.Count > 0)
        {
            // Computing statistical data
            double mean = CalculateMean(responseTimes);
            int min = int.MaxValue;
            int max = int.MinValue;
            double sumOfSquares = 0;

            foreach (int time in responseTimes)
            {
                if (time < min) min = time;
                if (time > max) max = time;
                sumOfSquares += Math.Pow(time - mean, 2);
            }

            double standardDeviation = Math.Sqrt(sumOfSquares / responseTimes.Count);

            // Output results
            Console.WriteLine("Numbers: " + string.Join(", ", responseTimes));
            Console.WriteLine($"The average is {mean}.");
            Console.WriteLine($"The minimum is {min}.");
            Console.WriteLine($"The maximum is {max}.");
            Console.WriteLine($"The standard deviation is {standardDeviation:N2}.");
        }
        else
        {
            Console.WriteLine("No valid numbers were entered.");
        }
    }

    static double CalculateMean(List<int> numbers)
    {
        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Count;
    }
}