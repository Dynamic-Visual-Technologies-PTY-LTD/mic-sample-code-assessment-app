namespace Mic.SampleCodeAssessmentApp.Library;

internal class InputHelper
{
    public static Enumerations.Operation GetOperationFromInput()
    {
        while (true)
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number) && Enum.IsDefined(typeof(Enumerations.Operation), number))
            {
                var operation = (Enumerations.Operation)number;
                Console.WriteLine($"You chose: {operation}");
                return operation;
            }

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    /// <summary>
    /// Reads and validates a numeric input from the user.
    /// </summary>
    public static double GetNumberInput(string message)
    {
        double number;
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out number))
            {
                return number;
            }

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    /// <summary>
    /// Validates if the operation input is within the accepted range.
    /// </summary>
    public static bool IsValidOperation(Enumerations.Operation operation)
    {
        return operation switch
        {
            Enumerations.Operation.Add or Enumerations.Operation.Subtract
            or Enumerations.Operation.Multiply or Enumerations.Operation.Divide
            or Enumerations.Operation.Power or Enumerations.Operation.SquareRoot
            or Enumerations.Operation.Exit => true,
            _ => false
        };
    }

    public static string GetOperationLabel(Enumerations.Operation operation)
    {
        return operation switch
        {
            Enumerations.Operation.Add => "1) Add",
            Enumerations.Operation.Subtract => "2) Subtract",
            Enumerations.Operation.Multiply => "3) Multiply",
            Enumerations.Operation.Divide => "4) Divide",
            Enumerations.Operation.Power => "5) Power",
            Enumerations.Operation.SquareRoot => "6) Square Root",
            Enumerations.Operation.Exit => "7) Exit",
            _ => throw new ArgumentException("Invalid operation.")
        };
    }
}
