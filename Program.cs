
/*
 * Name: Anthony Seldon
 * Date: October 11, 2026
 * Assignment: SDC220 Week 1 GP - Calculator
 *
 * This program performs integer addition and
 * floating-point subtraction.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Display project information
        Console.WriteLine("SDC220 - Week 1");
        Console.WriteLine("Calculator Project");
        Console.WriteLine("Created by Anthony Seldon");
        Console.WriteLine();

        // Display welcome message and instructions
        Console.WriteLine("Welcome to the calculator!");
        Console.WriteLine("This program adds two integers");
        Console.WriteLine("and subtracts two decimal numbers.");
        Console.WriteLine();

        // Integer addition
        Console.WriteLine("INTEGER ADDITION");
        Console.Write("Enter the first integer: ");
        int firstInteger = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int secondInteger = Convert.ToInt32(Console.ReadLine());

        int sum = firstInteger + secondInteger;

        Console.WriteLine(
            $"{firstInteger} + {secondInteger} = {sum}");
        Console.WriteLine();

        // Floating-point subtraction
        Console.WriteLine("DECIMAL SUBTRACTION");
        Console.Write("Enter the first decimal number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second decimal number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double difference = secondNumber - firstNumber;

        Console.WriteLine(
            $"{secondNumber} - {firstNumber} = {difference:F2}");
        Console.WriteLine();

        // Closing message
        Console.WriteLine("Thank you for using the calculator!");
    }
}
