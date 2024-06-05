namespace Exercise39;

internal static class SortingRecords
{
    static void Main()
    {
        // List of dictionaries to store employee data
        List<Dictionary<string, string>> employees = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string>{{"FirstName", "John"}, {"LastName", "Johnson"}, {"Position", "Manager"}, {"SeparationDate", "2016-12-31"}},
            new Dictionary<string, string>{{"FirstName", "Tou"}, {"LastName", "Xiong"}, {"Position", "Software Engineer"}, {"SeparationDate", "2016-10-05"}},
            new Dictionary<string, string>{{"FirstName", "Michaela"}, {"LastName", "Michaelson"}, {"Position", "District Manager"}, {"SeparationDate", "2015-12-19"}},
            new Dictionary<string, string>{{"FirstName", "Jake"}, {"LastName", "Jacobson"}, {"Position", "Programmer"}, {"SeparationDate", ""}},
            new Dictionary<string, string>{{"FirstName", "Jacquelyn"}, {"LastName", "Jackson"}, {"Position", "DBA"}, {"SeparationDate", ""}},
            new Dictionary<string, string>{{"FirstName", "Sally"}, {"LastName", "Weber"}, {"Position", "Web Developer"}, {"SeparationDate", "2015-12-18"}}
        };

        // Sorting the list by last name
        var sortedEmployees = employees.OrderBy(e => e["LastName"]).ToList();

        // Print the header
        Console.WriteLine("Name                 | Position            | Separation Date");
        Console.WriteLine("---------------------|---------------------|----------------");

        // Printing each employee's data
        foreach (var employee in sortedEmployees)
        {
            string fullName = employee["FirstName"] + " " + employee["LastName"];
            Console.WriteLine($"{fullName,-21}| {employee["Position"],-19}| {employee["SeparationDate"]}");
        }
    }
}