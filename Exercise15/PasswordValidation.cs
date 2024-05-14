namespace Exercise15;
internal static class PasswordValidation
{
    //First Try
    
    // static void Main()
    // {
    //     Console.Write("What is the password? ");
    //     string? passwordInput = Console.ReadLine();
    //
    //     if (passwordInput == "abc$123")
    //     {
    //         Console.WriteLine("Welcome!");
    //     }
    //     else
    //     {
    //         Console.WriteLine("I don't know you.");
    //     }
    // }
    
    //Second Try
    static void Main()
    {
        Console.Write("What is the password? ");
        string? passwordInput = Console.ReadLine();
            
        //separation of concerns, take the Validate password logic out of the main method
        string message = ValidatePassword(passwordInput);

        Console.WriteLine(message);
    }

    static string ValidatePassword(string? passwordInput)
    {
        try
        {
            //ternary operator if this ? then this : otherwise this
            return passwordInput == "abc$123" ? "Welcome!" : "I don't know you.";
        }
        catch (Exception ex)
        {
            return "An error occurred: " + ex.Message;
        }
    }
}