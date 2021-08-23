using System;

namespace Calculator_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;

            Console.WriteLine("Please enter the first number: ");
            string firstNumberEntered = Console.ReadLine();
            if (Convert.ToInt32(firstNumberEntered) is int)
            {
                firstNumber = Convert.ToInt32(firstNumberEntered);
            }
            else
            { 
                Console.WriteLine("Please enter a valid integer number.");
            }

            Console.WriteLine("Please enter the second number: ");
            string secondNumberEntered = Console.ReadLine();
            if (Convert.ToInt32(secondNumberEntered) is int)
            {
                secondNumber = Convert.ToInt32(secondNumberEntered);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer number.");
            }
            
            Console.WriteLine("Please enter the operation you would like to perform (+, -, *, /): ");
            string operationEntered = Console.ReadLine();

            switch (operationEntered) {
                case "+":
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumberEntered} + {secondNumberEntered} = {result}");
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                    break;
                default:
                    Console.WriteLine("Please enter +, -, * or /");
                    break;
            }
        }
    }
}
