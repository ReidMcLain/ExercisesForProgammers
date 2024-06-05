namespace Exercise40;

internal static class FilteringRecords
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

        // Prompt user for a search string
        Console.Write("Enter a search string: ");
        string searchString = Console.ReadLine().ToLower();

        // Filter employees by search string in first or last name
        var filteredEmployees = employees.Where(e => e["FirstName"].ToLower().Contains(searchString) || e["LastName"].ToLower().Contains(searchString)).ToList();

        // Print the results
        if (filteredEmployees.Count > 0)
        {
            Console.WriteLine("Results:");
            Console.WriteLine("Name                 | Position            | Separation Date");
            Console.WriteLine("---------------------|---------------------|----------------");

            foreach (var employee in filteredEmployees)
            {
                string fullName = employee["FirstName"] + " " + employee["LastName"];
                Console.WriteLine($"{fullName,-21}| {employee["Position"],-19}| {employee["SeparationDate"]}");
            }
        }
        else
        {
            Console.WriteLine("No results found.");
        }
    }
}