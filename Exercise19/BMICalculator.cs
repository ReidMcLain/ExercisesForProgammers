namespace Exercise19;

internal static class BMICalculator
{
    static void Main()
    {
        Console.Write("What is your height in inches? ");
        string? heightstring = Console.ReadLine();
        Console.Write("What is your weight in pounds? ");
        string? weightString = Console.ReadLine();

        if (double.TryParse(heightstring, out double heightDouble) && double.TryParse(weightString, out double weightDouble) )
        {
            double bmi = (weightDouble / (heightDouble * heightDouble)) * 703;
            if (bmi < 18.5)
            {
                Console.WriteLine($"Your BMI is {bmi}.");
                Console.WriteLine("You are underweight. You should see your doctor.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine($"Your BMI is {bmi}.");
                Console.WriteLine("You are within the ideal weight range");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine($"Your BMI is {bmi}");
                Console.WriteLine("You are overweight. You should see your doctor.");
            }
            else if (bmi >= 30)
            {
                Console.WriteLine($"Your BMI is {bmi}");
                Console.WriteLine("You are obese. You should see your doctor.");
            }
        }
    }
}