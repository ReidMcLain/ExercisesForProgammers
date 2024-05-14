namespace Exercise16
{
    internal static class LegalDrivingAge
    {
        static void Main()
        {
            Console.Write("What is your age? ");
            string? ageInput = Console.ReadLine();
            
            if (int.TryParse(ageInput, out int ageOutput))
            {
                string legalDrivingAge = ageOutput >= 16 ? "You are old enough to legally drive." : "You are not old enough to legally drive.";
                Console.WriteLine(legalDrivingAge);
            }
            else
            {
                Console.WriteLine("Invalid age entered. Please enter a valid age.");
            }
        }
    }
}