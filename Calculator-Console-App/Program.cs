using System;

/* 
   A calculator console application.  The application will take integers and decimal numbers
   input by the user, check if the entry was valid, and perform addition, subraction, multiplication,
   and division, based on the users input.
*/

namespace Calculator_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validFirstNumber = false;
            bool validSecondNumber = false;
            bool validOperation = false;

            // Main loop for the entire application.

            while (validFirstNumber == false && validSecondNumber == false && validOperation == false)
            {                
                int firstNumberInt = 0;
                decimal firstNumberDec = 0.0m;
                int secondNumberInt = 0;
                decimal secondNumberDec = 0.0m;                

                // Checks the validity of the first number input.

                Console.WriteLine("Please enter the first number: ");
                string firstNumberEntered = Console.ReadLine();
                bool isFirstNumberInt = int.TryParse(firstNumberEntered, out firstNumberInt);
             
                if (isFirstNumberInt == true)
                {
                    validFirstNumber = true;
                }
                else
                {
                    bool isFirstNumberDec = decimal.TryParse(firstNumberEntered, out firstNumberDec);
                    if (isFirstNumberDec == true)
                    {
                        validFirstNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                        break;
                    }
                }

                // Checks the validity of the second number input.

                Console.WriteLine("Please enter the second number: ");
                string secondNumberEntered = Console.ReadLine();
                bool isSecondNumberInt = int.TryParse(secondNumberEntered, out secondNumberInt);
                
                if (isSecondNumberInt == true)
                {
                    validSecondNumber = true;
                }
                else
                {
                    bool isSecondNumberDec = decimal.TryParse(secondNumberEntered, out secondNumberDec);
                    if (isSecondNumberDec == true)
                    {
                        validSecondNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                        break;
                    }
                }               

                // Checks if the user enters a valid arithmetic operator, and performs that function.

                Console.WriteLine("Please enter the operation you would like to perform (+, -, *, /): ");
                string operationEntered = Console.ReadLine();

                int resultInt = 0;
                decimal resultDec = 0.0m;

                switch (operationEntered)
                {
                    case "+":
                        if (isFirstNumberInt && isSecondNumberInt == true)
                        {
                            resultInt = firstNumberInt + secondNumberInt;
                            Console.WriteLine($"{firstNumberEntered} + {secondNumberEntered} = {resultInt}");
                        }
                        else
                        {
                            resultDec = (firstNumberDec + firstNumberInt) + (secondNumberDec + secondNumberInt);
                            Console.WriteLine($"{firstNumberEntered} + {secondNumberEntered} = {resultDec}");
                        }
                        break;
                    case "-":
                        if (isFirstNumberInt && isSecondNumberInt == true)
                        {
                            resultInt = firstNumberInt - secondNumberInt;
                            Console.WriteLine($"{firstNumberEntered} - {secondNumberEntered} = {resultInt}");
                        }
                        else
                        {
                            resultDec = (firstNumberDec + firstNumberInt) - (secondNumberDec + secondNumberInt);
                            Console.WriteLine($"{firstNumberEntered} - {secondNumberEntered} = {resultDec}");
                        }
                        break;
                    case "*":
                        if (isFirstNumberInt && isSecondNumberInt == true)
                        {
                            resultInt = firstNumberInt * secondNumberInt;
                            Console.WriteLine($"{firstNumberEntered} * {secondNumberEntered} = {resultInt}");
                        }
                        else
                        {
                            resultDec = (firstNumberDec + firstNumberInt) * (secondNumberDec + secondNumberInt);
                            Console.WriteLine($"{firstNumberEntered} * {secondNumberEntered} = {resultDec}");
                        }
                        break;
                    case "/":
                        resultDec = (firstNumberDec + firstNumberInt) / (secondNumberDec + secondNumberInt);
                        Console.WriteLine($"{firstNumberEntered} / {secondNumberEntered} = {resultDec}");
                        break;
                    default:
                        Console.WriteLine("Please enter +, -, * or /");
                        break;
                }
            }          
            
                        
        }
    }
}
