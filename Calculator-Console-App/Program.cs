using System;

namespace Calculator_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validFirstNumber = false;
            bool validSecondNumber = false;
            bool validOperation = false;

            while (validFirstNumber == false && validSecondNumber == false && validOperation == false)
            {                
                int firstNumberInt = 0;
                decimal firstNumberDec = 0.0m;
                int secondNumberInt = 0;
                decimal secondNumberDec = 0.0m;                

                Console.WriteLine("Please enter the first number: ");
                string firstNumberEntered = Console.ReadLine();
                bool isFirstNumberInt = int.TryParse(firstNumberEntered, out firstNumberInt);
                bool isFirstNumberDec = decimal.TryParse(firstNumberEntered, out firstNumberDec);
                //if (Convert.ToInt32(firstNumberEntered) is int || Convert.ToDecimal(firstNumberEntered) is decimal)
                if (isFirstNumberInt == true)
                {
                    validFirstNumber = true;
                }
                else if (isFirstNumberDec == true)
                {
                    validFirstNumber = true;
                }
                else 
                { 
                    Console.WriteLine("Please enter a valid number.");
                    break;
                }

                Console.WriteLine("Please enter the second number: ");
                string secondNumberEntered = Console.ReadLine();
                bool isSecondNumberInt = int.TryParse(secondNumberEntered, out secondNumberInt);
                bool isSecondNumberDec = decimal.TryParse(secondNumberEntered, out secondNumberDec);

                if (isSecondNumberInt == true)
                {
                    validSecondNumber = true;
                }
                else if (isSecondNumberDec == true)
                {
                    validSecondNumber = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                    break;
                }

                Console.WriteLine("Please enter the operation you would like to perform (+, -, *, /): ");
                string operationEntered = Console.ReadLine();

                int resultInt = 0;
                decimal resultDec = 0.0m;

                switch (operationEntered)
                {
                    case "+":
                        if (firstNumberInt != 0 && secondNumberInt != 0)
                        {
                            resultInt = firstNumberInt + secondNumberInt;
                            Console.WriteLine($"{firstNumberEntered} + {secondNumberEntered} = {resultInt}");
                        }
                        else
                        {
                            resultDec = firstNumberInt + firstNumberDec + secondNumberInt + secondNumberDec;
                            Console.WriteLine($"{firstNumberEntered} + {secondNumberEntered} = {resultDec}");
                        }
                        break;
                    case "-":
                        if (firstNumberInt != 0)
                        {
                            resultInt = firstNumberInt - secondNumberInt;
                            Console.WriteLine($"{firstNumberEntered} - {secondNumberEntered} = {resultInt}");
                        }
                        else
                        {
                            resultDec = firstNumberDec - secondNumberDec;
                            Console.WriteLine($"{firstNumberEntered} + {secondNumberEntered} = {resultDec}");
                        }
                        break;
                    case "*":
                        if (firstNumberInt != 0)
                        {
                            resultInt = firstNumberInt * secondNumberInt;
                            Console.WriteLine($"{firstNumberEntered} * {secondNumberEntered} = {resultInt}");
                        }
                        else
                        {
                            resultDec = firstNumberDec * secondNumberDec;
                            Console.WriteLine($"{firstNumberEntered} + {secondNumberEntered} = {resultDec}");
                        }
                        break;
                    case "/":
                        if (firstNumberInt != 0)
                        {
                            resultInt = firstNumberInt / secondNumberInt;
                            Console.WriteLine($"{firstNumberEntered} / {secondNumberEntered} = {resultInt}");
                        }
                        else
                        {
                            resultDec = firstNumberDec / secondNumberDec;
                            Console.WriteLine($"{firstNumberEntered} + {secondNumberEntered} = {resultDec}");
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter +, -, * or /");
                        break;
                }
            }          
            
                        
        }
    }
}
