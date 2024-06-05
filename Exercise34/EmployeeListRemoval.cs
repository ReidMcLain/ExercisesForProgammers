namespace Exercise34;

internal static class EmployeeListRemoval
{
    static void Main()
    {
        List<string> employees = new List<string>
        //A list is dynamic in size so useful for this exercise
        {
            "John Smith",
            "Jackie Jackson",
            "Chris Jones",
            "Amanda Cullen",
            "Jeremy Goodwin"
        };
        
        Console.WriteLine($"There are {employees.Count} employees:");
        foreach (string employee in employees)
        {
            Console.WriteLine(employee);
        }
        
        Console.Write("Enter an employee name to remove: ");
        string nameToRemove = Console.ReadLine();

        // Remove the specified employee name
        employees.Remove(nameToRemove);
        
        Console.WriteLine($"There are {employees.Count} employees:");
        foreach (string employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}

