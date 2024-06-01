using System.Text.RegularExpressions;
namespace Exercise27;

internal static class ValidatingInputs
{
    static void Main()
    {
        Console.Write("Enter the first name: ");
        string? firstNameString = Console.ReadLine();
        Console.Write("Enter the last name: ");
        string? lastNameString = Console.ReadLine();
        Console.Write("Enter the ZIP code: ");
        string? ZIPstring = Console.ReadLine();
        Console.Write("Enter an employee ID: ");
        string? EmployeeIDString = Console.ReadLine();
        
        string result = ValidateInput(firstNameString, lastNameString, ZIPstring, EmployeeIDString);
        Console.WriteLine(result);
    }

    private static string ValidateInput(string? firstName, string? lastName, string? zipCode, string? employeeId)
    {
        string result = "";
        result += ValidateFirstName(firstName);
        result += ValidateLastName(lastName);
        result += ValidateZipCode(zipCode);
        result += ValidateEmployeeId(employeeId);

        return string.IsNullOrEmpty(result) ? "There were no errors found." : result;
    }

    private static string ValidateFirstName(string? firstName)
    {
        if (string.IsNullOrEmpty(firstName))
        {
            return "The first name must be filled in.\n";
        }
        if (firstName.Length < 2)
        {
            return $"\"{firstName}\" is not a valid first name. It is too short.\n";
        }
        return "";
    }

    private static string ValidateLastName(string? lastName)
    {
        if (string.IsNullOrEmpty(lastName))
        {
            return "The last name must be filled in.\n";
        }
        if (lastName.Length < 2)
        {
            return $"\"{lastName}\" is not a valid last name. It is too short.\n";
        }
        return "";
    }

    private static string ValidateZipCode(string? zipCode)
    {
        if (string.IsNullOrEmpty(zipCode) || !Regex.IsMatch(zipCode, @"^\d+$"))
        {
            return "The ZIP code must be numeric.\n";
        }
        return "";
    }

    private static string ValidateEmployeeId(string? employeeId)
    {
        if (string.IsNullOrEmpty(employeeId) || !Regex.IsMatch(employeeId, @"^[A-Za-z]{2}-\d{4}$"))
        {
            return $"{employeeId} is not a valid ID.\n";
        }
        return "";
    }
}