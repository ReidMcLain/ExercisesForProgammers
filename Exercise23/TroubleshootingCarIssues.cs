namespace Exercise23;

internal static class TroubleshootingCarIssues
{
    static void Main()
    {
        Console.WriteLine("Car Troubleshooting Guide");
        StartTroubleshooting();
    }

    static void StartTroubleshooting()
    {
        if (AskQuestion("Is the car silent when you turn the key?"))
        {
            if (AskQuestion("Are the battery terminals corroded?"))
            {
                Console.WriteLine("Clean the terminals and try starting again.");
            }
            else
            {
                Console.WriteLine("Replace cables and try again.");
            }
        }
        else if (AskQuestion("Does the car make a clicking noise?"))
        {
            Console.WriteLine("Replace the battery.");
        }
        else if (AskQuestion("Does the car crank up but fail to start?"))
        {
            Console.WriteLine("Check spark plug connections.");
        }
        else if (AskQuestion("Does the engine start and then die?"))
        {
            if (AskQuestion("Does your car have fuel injection?"))
            {
                Console.WriteLine("Get it in for service.");
            }
            else
            {
                Console.WriteLine("Check to ensure the choke is opening and closing.");
            }
        }
        else
        {
            Console.WriteLine("Get it in for service.");
        }
    }

    static bool AskQuestion(string question)
    {
        Console.Write(question + " (y/n): ");
        string answer = Console.ReadLine().ToLower();
        while (answer != "y" && answer != "n")
        {
            Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no.");
            Console.Write(question + " (y/n): ");
            answer = Console.ReadLine().ToLower();
        }

        return answer == "y";
    }
}