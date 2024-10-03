// Task3.cs
using System;
using System.Text.RegularExpressions;

public class Task3
{
    public static void RunTask()
    {
        const string correctPassword = "Pass123!"; // Example of a correct password
        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Validate that password is alphanumeric with at least one letter, one digit, and one special character
            if (!IsAlphanumeric(password))
            {
                Console.WriteLine("Password must contain letters, digits, and at least one special character.");
                continue;
            }

            // Check if the password matches
            if (password == correctPassword)
            {
                Console.WriteLine("Welcome, user!");
                break;
            }
            else
            {
                attempts--;
                Console.WriteLine($"Incorrect password. You have {attempts} attempt(s) left.");
            }

            if (attempts == 0)
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }

    // Function to check if the password is alphanumeric with at least one letter, one digit, and one special character
    private static bool IsAlphanumeric(string input)
    {
        bool hasLetter = Regex.IsMatch(input, @"[a-zA-Z]");
        bool hasDigit = Regex.IsMatch(input, @"\d");
        bool hasSpecialChar = Regex.IsMatch(input, @"[!@#$%^&*(),.?""\\:{}|<>]");

        return hasLetter && hasDigit && hasSpecialChar;
    }
}
