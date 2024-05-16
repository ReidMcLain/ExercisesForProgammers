namespace Exercise17
{
    internal static class BloodAlcoholCalculator
    {
        static void Main()
        {
            Console.Write("What is your weight? (pounds) ");
            string? weightString = Console.ReadLine();
            Console.Write("What is your gender? (male/female) ");
            string? genderString = Console.ReadLine();
            Console.Write("How many drinks have you had? (full can) ");
            string? drinksString = Console.ReadLine();
            Console.Write("What is the amount of alcohol by volume in these drinks? (percentage) ");
            string? alcoholByVolumeString = Console.ReadLine();
            Console.Write("How long has it been since your last drink? (hours) ");
            string? timeString = Console.ReadLine();
            
            if (int.TryParse(weightString, out int weightInteger) && (int.TryParse(drinksString, out int drinksInteger) 
                && (decimal.TryParse(alcoholByVolumeString, out decimal alcoholByVolumeInteger) && (int.TryParse(timeString, out int timeInteger)))))
            {
                double bacMultipler = ParseGender(genderString); //decouple this logic outside the main method
                decimal drinksInFluidOunces = drinksInteger * 12; //assume a total can of beer has 12 fluid ounces
                decimal alcoholByVolumeIntegerConverted = alcoholByVolumeInteger / 100m; //convert the percentage to correct decimal
                decimal totalAlcohol = drinksInFluidOunces * alcoholByVolumeIntegerConverted; //multiply how many fluid ounces in one drink by the percent of Alcohol
                double BAC = CalculateBAC(weightInteger, bacMultipler, totalAlcohol, timeInteger); //pass in all converted arguments into decoupled method
                string BACtoDrive = BAC >= 0.08 ? "It is not legal for you to drive." : "It is legal for you to drive.";
                Console.WriteLine($"Your BAC is {BAC}");
                Console.WriteLine(BACtoDrive);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static double ParseGender(string? gender)
        {
            if (gender != null && (gender.ToLower() == "male" || gender.ToLower() == "m") )
            {
                return 0.73;
            }
            else if (gender != null && (gender.ToLower() == "female" || gender.ToLower() == "f") )
            {
                return 0.66;
            }
            {
                throw new ArgumentException("Invalid gender input.");
            }
        }

        static double CalculateBAC(int weight, double genderMultiplier, decimal alcohol, int time)
        {
            return (((double)alcohol * 5.14)/(weight * genderMultiplier) - (0.15 * time));
        }
    }
}