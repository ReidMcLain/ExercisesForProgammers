namespace Exercise18;

internal static class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Press C to convert from Fahreneit to Celsius.");
        Console.WriteLine("Press F to convert from Celsius to Farenheit.");
        string? temperatureScale = Console.ReadLine().ToUpper();

        if (temperatureScale == "C")
        {
            Console.Write("Please enter the temperature in Fahrenheit: ");
            string? fahrenheitString = Console.ReadLine();
            if (double.TryParse(fahrenheitString, out double fahrenheitDouble))
            {
                double celsius = (fahrenheitDouble - 32) * 5 / 9;
                Console.Write($"Your temperature in celsius is: {celsius}");
            }
        }
        
        else if (temperatureScale == "F")
        {
            Console.Write("Please enter the temperature in Celsius: ");
            string? celsiusString = Console.ReadLine();
            if (double.TryParse(celsiusString, out double celsiusDouble))
            {
                double fahrenheit = (celsiusDouble * 9 / 5) + 32;
                Console.Write($"Your temperature in celsius is: {fahrenheit}");
            }
        }
        else
        {
            Console.Write("Invalid, please type c or f");
        }
    }
}