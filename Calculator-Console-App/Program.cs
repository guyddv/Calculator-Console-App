using System;

namespace Calculator_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumberEntered = "";
            string secondNumberEntered = "";
            string operationEntered;
            int result;

            Console.WriteLine("Please enter the first number: ");
            firstNumberEntered = Console.ReadLine();
            Console.WriteLine("Please enter the second number: ");
            secondNumberEntered = Console.ReadLine();
            Console.WriteLine("Please enter the operation you would like to perform (+, -, *, /): ");
            operationEntered = Console.ReadLine();

            switch (operationEntered) {
                case "+":
                    int firstNumber = Convert.ToInt32(firstNumberEntered);
                    int secondNumber = Convert.ToInt32(secondNumberEntered);
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumberEntered} + {secondNumberEntered} = {result}");
                    break;

                default:
                    Console.WriteLine("Please enter +, -, * or /");
                    break;
            }
        }
    }
}
