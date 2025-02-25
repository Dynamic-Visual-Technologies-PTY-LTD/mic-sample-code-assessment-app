using Mic.SampleCodeAssessmentApp.Library;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Welcome to Mr. Calculator!");

var services = new ServiceCollection();
services.AddSingleton<ICalculator, Calculator>();
var serviceProvider = services.BuildServiceProvider();

var calculator = serviceProvider.GetRequiredService<ICalculator>();

while (true)
{
    Console.WriteLine("\nSelect an operation:");
    Console.WriteLine(InputHelper.GetOperationLabel(Enumerations.Operation.Add));
    Console.WriteLine(InputHelper.GetOperationLabel(Enumerations.Operation.Subtract));
    Console.WriteLine(InputHelper.GetOperationLabel(Enumerations.Operation.Multiply));
    Console.WriteLine(InputHelper.GetOperationLabel(Enumerations.Operation.Divide));
    Console.WriteLine(InputHelper.GetOperationLabel(Enumerations.Operation.Power));
    Console.WriteLine(InputHelper.GetOperationLabel(Enumerations.Operation.SquareRoot));
    Console.WriteLine(InputHelper.GetOperationLabel(Enumerations.Operation.Exit));
    Console.WriteLine();

    var operation = InputHelper.GetOperationFromInput();

    if (operation == Enumerations.Operation.Exit)
    {
        Console.WriteLine("Exiting calculator. Goodbye!");
        break;
    }

    if (!InputHelper.IsValidOperation(operation))
    {
        Console.WriteLine("Invalid operation. Please select a number between 1 and 7.");
        continue;
    }

    double a = InputHelper.GetNumberInput("Enter the first number: ");

    if (operation == Enumerations.Operation.SquareRoot) // Square root requires only one input
    {
        try
        {
            Console.WriteLine($"Result: {calculator.SquareRoot(a)}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        continue;
    }

    double b = InputHelper.GetNumberInput("Enter the second number: ");
    try
    {
        double result = operation switch
        {
            Enumerations.Operation.Add => calculator.Add(a, b),
            Enumerations.Operation.Subtract => calculator.Subtract(a, b),
            Enumerations.Operation.Multiply => calculator.Multiply(a, b),
            Enumerations.Operation.Divide => calculator.Divide(a, b),
            Enumerations.Operation.Power => calculator.Power(a, b),
            _ => throw new InvalidOperationException("Unexpected operation.")
        };

        Console.WriteLine($"Result: {result}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

