// Task1.cs
using System;

public class Task1
{
    public static void RunTask()
    {
        Console.WriteLine("Simple Calculator");

        // Input first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Input second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform operations
        Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");

        // Check if the second number is 0 for division
        if (num2 != 0)
        {
            Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Division: Division by zero is not allowed.");
        }
    }
}
