class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Write("Enter the first number :");
            int firstNumber;
            while (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.Write("Invalid input. Please enter a whole number :");
            }
            Console.Write("Enter the second number :");
            int secondNumber;
            while (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.Write("Invalid input. Please enter a whole number :");
            }
            string operation;
            while (true)
            {
                Console.Write("Choose an operator (+, -, *, /, %, =): ");
                operation = Console.ReadLine();
                
                if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%" || operation == "=")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect operation used, please try again.");
                }
            }
            
            if (operation == "=")
            {
                Console.WriteLine("Exiting calculator. bye bye!");
                break;
            }
            
            double? result = Calculator.Calculate(firstNumber, secondNumber, operation);
            
            if (result.HasValue)
            {
                Console.WriteLine($"Result: {result.Value}");
            }
            
            Console.WriteLine();
        }
    }
}﻿//write your console display in here
