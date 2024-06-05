using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise37
{
    internal static class PasswordGenerator
    {
        static void Main()
        {
            // Character sets
            List<char> letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
            List<char> specialChars = "!@#$%^&*()-_+=[]{}|;:,.<>?".ToList();
            List<char> numbers = "0123456789".ToList();

            // Random number generator
            Random random = new Random();

            // User input for password criteria
            Console.Write("What's the minimum length? ");
            int minLength = int.Parse(Console.ReadLine());
            Console.Write("How many special characters? ");
            int specialCount = int.Parse(Console.ReadLine());
            Console.Write("How many numbers? ");
            int numberCount = int.Parse(Console.ReadLine());

            // Ensure the minimum length can accommodate the requested number of specials and numbers
            int totalRequiredChars = specialCount + numberCount;
            int letterCount = minLength - totalRequiredChars;

            if (letterCount < 1)  // Ensure there is at least one letter if total specials and numbers exceed minLength
            {
                letterCount = 1;
                minLength = totalRequiredChars + letterCount;  // Adjust minimum length to fit at least one letter
            }

            // Construct the password
            List<char> passwordChars = new List<char>();

            // Add random special characters
            AddRandomChars(specialChars, specialCount, passwordChars, random);

            // Add random numbers
            AddRandomChars(numbers, numberCount, passwordChars, random);

            // Fill the rest with random letters
            AddRandomChars(letters, letterCount, passwordChars, random);

            // Shuffle the characters to randomize their order
            passwordChars = ShuffleList(passwordChars, random);

            // Convert list to string and display the password
            string password = new string(passwordChars.ToArray());
            Console.WriteLine($"Your password is\n{password}");
        }

        // Method to add random characters from a given set
        static void AddRandomChars(List<char> charSet, int count, List<char> passwordChars, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                passwordChars.Add(charSet[random.Next(charSet.Count)]);
            }
        }

        // Method to shuffle characters in a list
        static List<char> ShuffleList(List<char> list, Random random)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int swapIndex = random.Next(i + 1);
                char temp = list[i];
                list[i] = list[swapIndex];
                list[swapIndex] = temp;
            }
            return list;
        }
    }
}

