namespace Exercise06;
internal static class RetirementCalculator
{
    static void Main()
    {
        Console.WriteLine("What is your current age? ");
        string? ageInput = Console.ReadLine();
        Console.WriteLine("At what age would you like to retire? ");
        string? retirementAgeInput = Console.ReadLine();
        
        if (int.TryParse(ageInput, out int ageOutput) && int.TryParse(retirementAgeInput, out int retirementAgeOutput))
        {
            int yearsTillRetirement = retirementAgeOutput - ageOutput;
            int currentYear = DateTime.Now.Year;
            int retirementYear = currentYear + yearsTillRetirement;
            
            Console.WriteLine($"You have {yearsTillRetirement} years left until you can retire.");
            Console.WriteLine($"It's {currentYear}, so you can retire in {retirementYear}.");
        }
        else
        {
            Console.WriteLine("Please enter an integer number");
        }
    }
}