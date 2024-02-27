// See https://aka.ms/new-console-template for more information
using System;

// Create a class named MathOperations
public class MathOperations
{
    // Create a void method that takes two integers as parameters
    public void PerformMathOperation(int firstNumber, int secondNumber)
    {
        // Do a math operation on the first integer (for example, add 10)
        int result = firstNumber + 10;

        // Display the result (second integer) to the screen
        Console.WriteLine($"Result of math operation on {firstNumber}: {result}, Displayed Number: {secondNumber}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathOperations = new MathOperations();

        // Call the method in the class, passing in two numbers
        mathOperations.PerformMathOperation(5, 20);

        // Call the method in the class, specifying the parameters by name
        mathOperations.PerformMathOperation(firstNumber: 8, secondNumber: 30);

        // Wait for user input to close the console window
        Console.ReadLine();
    }
}
