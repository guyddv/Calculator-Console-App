using System;

/* 
   A calculator console application.  The application will take integers and decimal numbers
   input by the user, check if the entry was valid, and perform addition, subtraction, multiplication,
   and division, based on the users input.
*/

namespace Calculator_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            bool validNumber = true;

            // Main loop for the entire application.

            while (runAgain)
            {                
                int firstNumberInt = 0;
                int secondNumberInt = 0;

                // Checks the validity of the first number input.

                do
                {
                    Console.WriteLine("Please enter the first number: ");
                    string firstNumberEntered = Console.ReadLine();
                    bool isFirstNumberInt = int.TryParse(firstNumberEntered, out firstNumberInt);
                    validNumber = true;

                    if (!isFirstNumberInt)
                    {
                        validNumber = false;
                        Console.WriteLine("Please enter a valid integer.");
                    }
                }
                while (!validNumber);

                // Checks the validity of the second number input.

                do
                {
                    Console.WriteLine("Please enter the second number: ");
                    string secondNumberEntered = Console.ReadLine();
                    bool isSecondNumberInt = int.TryParse(secondNumberEntered, out secondNumberInt);
                    validNumber = true;

                    if (!isSecondNumberInt)
                    {
                        validNumber = false;
                        Console.WriteLine("Please enter a valid integer.");
                    }
                }
                while (!validNumber);

                // Checks if the user enters a valid arithmetic operator, and performs that function.

                Console.WriteLine("Please enter the operation you would like to perform (+, -, *, /): ");
                string operationEntered = Console.ReadLine();

                int resultInt = 0;

                switch (operationEntered)
                {
                    case "+":
                        resultInt = firstNumberInt + secondNumberInt;
                        Console.WriteLine($"{firstNumberInt} + {secondNumberInt} = {resultInt}");
                        break;
                    case "-":
                        resultInt = firstNumberInt - secondNumberInt;
                        Console.WriteLine($"{firstNumberInt} - {secondNumberInt} = {resultInt}");
                        break;
                    case "*":
                        resultInt = firstNumberInt * secondNumberInt;
                        Console.WriteLine($"{firstNumberInt} * {secondNumberInt} = {resultInt}");
                        break;
                    case "/":
                        if (secondNumberInt == 0)
                        {
                            Console.WriteLine("Divide by zero error!");
                            break;
                        }
                        else
                        {
                            resultInt = firstNumberInt / secondNumberInt;
                            Console.WriteLine($"{firstNumberInt} / {secondNumberInt} = {resultInt}");
                            break;
                        }
                        resultInt = firstNumberInt / secondNumberInt;
                        Console.WriteLine($"{firstNumberInt} / {secondNumberInt} = {resultInt}");
                        break;
                    default:
                        Console.WriteLine("Please enter +, -, * or /");
                        break;
                }

                Console.WriteLine("Would you like to run the calculator again? (y/n)");
                string runAgainAnswer = Console.ReadLine();
                if (runAgainAnswer == "y")
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }
            }          
        }
    }
}
