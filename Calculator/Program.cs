using System;

namespace CalculatorDetailed
{
    class Program
    {
        public double Calculate(string operation, params double[] numbers)
        {
            double result = numbers[0];
            switch (operation)
            {
                case "+":
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        result += numbers[i];
                    }
                    break;
                case "-":
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        result -= numbers[i];
                    }
                    break;
                case "*":
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        result *= numbers[i];
                    }
                    break;
                case "/":
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed");
                            return 0;
                        }
                        result /= numbers[i];
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return 0;
            }
            Console.WriteLine("Result of the operation: " + result);
            return result;
        }

        public static void Main(string[] args)
        {
            string operation;
            int count;
            Console.Write("Enter the number of values for the operation: ");
            count = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[count];
            Console.Write("\nAvailable operations:  / , * , - , + \n");
            Console.Write("\nEnter the operation you want to perform: ");
            operation = Console.ReadLine();
            while (!(operation == "+" || operation == "-" || operation == "*" || operation == "/"))
            {
                Console.WriteLine("Invalid operation. Please try again.");
                operation = Console.ReadLine();
            }
            Console.WriteLine("Enter the numbers for the operation: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            Program calculator = new Program();

            Console.WriteLine(" ");
            calculator.Calculate(operation, numbers);
        }
    }
}
