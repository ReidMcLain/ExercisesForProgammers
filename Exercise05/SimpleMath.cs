namespace Exercise05;
internal static class SimpleMath
{
    static void Main()
    {
        Console.WriteLine("What is the first number: ");
        string? firstInput = Console.ReadLine();
        Console.WriteLine("What is the second number: ");
        string? secondInput = Console.ReadLine();

        //TryParse, takes parameter 1: a string then converts to parameter 2: an int 
        if (double.TryParse(firstInput, out double firstOutput) && double.TryParse(secondInput, out double secondOutput))
        {
            //we chose double here instead of int because numbers have decimals when divided
            double add = firstOutput + secondOutput;
            double subtract = firstOutput - secondOutput;
            double multiply = firstOutput * secondOutput;
            double divide = firstOutput / secondOutput;
            
            //the \n puts each result on the next line
            Console.WriteLine($" {firstOutput} + {secondOutput} = {add}\n" +
                              $" {firstOutput} - {secondOutput} = {subtract}\n" +
                              $" {firstOutput} * {secondOutput} = {multiply}\n" +
                              $" {firstOutput} / {secondOutput} = {divide}"); 
        }
        else
        {
            Console.WriteLine("Please enter an integer number");
        }
    }
}
