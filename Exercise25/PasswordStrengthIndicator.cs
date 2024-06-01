using System.Text.RegularExpressions;

namespace Exercise25;

internal static class PasswordStrengthIndicator
{
    static void Main()
    {
        Console.Write("Enter a password: ");
        string? passwordString = Console.ReadLine();
        if (passwordString != null)
        {
            string strength = PasswordValidator(passwordString);
            Console.WriteLine($"The password '{passwordString}' is a {strength} password.");
        }
    }

    private static string PasswordValidator(string password)
    {
        bool hasLetters = Regex.IsMatch(password, "[a-zA-Z]");
        bool hasNumbers = Regex.IsMatch(password, "[0-9]");
        bool hasSpecialChars = Regex.IsMatch(password, "[^a-zA-Z0-9]");
        bool isAtLeastEightChars = password.Length >= 8;
        
        if (isAtLeastEightChars && hasLetters && hasNumbers && hasSpecialChars)
        {
            return "very strong";
        }
        else if (isAtLeastEightChars && hasLetters && hasNumbers)
        {
            return "strong";
        }
        else if (!isAtLeastEightChars && hasLetters && !hasNumbers)
        {
            return "weak";
        }
        else if (!isAtLeastEightChars && !hasLetters && hasNumbers)
        {
            return "very weak";
        }
        return "weak"; 
    }
}

