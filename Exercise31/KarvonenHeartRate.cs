namespace Exercise31;

internal static class KarvonenHeartRate
{
    static void Main()
    {
        int age = GetValidInput("Enter your age: ", "Please enter a valid age as a positive number.");
        int restingHR = GetValidInput("Enter your resting heart rate: ", "Please enter a valid resting heart rate as a positive number.");

        // Display the table headers
        Console.WriteLine($"Resting Pulse: {restingHR} Age: {age}");
        Console.WriteLine("Intensity | Rate");
        Console.WriteLine("----------|--------");

        // Calculate and display the target heart rate for each intensity
        for (int intensity = 55; intensity <= 95; intensity += 5)
        {
            double TargetHeartRate = (((220 - age) - restingHR) * (intensity / 100.0)) + restingHR;
            Console.WriteLine($"{intensity}%       | {Math.Round(TargetHeartRate)} bpm");
        }
    }

    // Method to get valid integer input from the user
    static int GetValidInput(string prompt, string errorMessage)
    {
        int result;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
        {
            Console.WriteLine(errorMessage);
            Console.Write(prompt);
        }
        return result;
    }
}