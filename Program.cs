using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Adder - enter two numbers to add them.");

        Console.Write("Enter first number: ");
        double a = ReadDoubleFromConsole();

        Console.Write("Enter second number: ");
        double b = ReadDoubleFromConsole();

        double sum = a + b;
        Console.WriteLine($"\nResult: {a} + {b} = {sum}");
    }

    static double ReadDoubleFromConsole()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Input was empty. Please enter a number: ");
                continue;
            }

            if (double.TryParse(input, out double value))
                return value;

            Console.Write("Invalid number, please enter again: ");
        }
    }
}
