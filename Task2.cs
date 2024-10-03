// Task2.cs
using System;

public class Task2
{
    public static void RunTask()
    {
        Console.WriteLine("Grading Program");

        // Input score
        Console.Write("Enter the score (0-100): ");
        int score = Convert.ToInt32(Console.ReadLine());

        // Determine grade
        string grade;

        if (score >= 85 && score <= 100)
        {
            grade = "High Distinction";
        }
        else if (score >= 75 && score <= 84)
        {
            grade = "Distinction";
        }
        else if (score >= 65 && score <= 74)
        {
            grade = "Credit";
        }
        else if (score >= 55 && score <= 64)
        {
            grade = "Pass";
        }
        else if (score >= 0 && score <= 54)
        {
            grade = "Fail";
        }
        else
        {
            grade = "Invalid Score";
        }

        // Output grade
        Console.WriteLine($"The grade for score {score} is: {grade}");
    }
}
