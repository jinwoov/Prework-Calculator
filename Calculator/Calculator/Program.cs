using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                // Signature
                Console.WriteLine(@" 
                #============================#
                #       Calculator 1.0       #
                #      made by YoursTruly    #
                #============================#");
                // Taking in the User's Name
                Console.WriteLine("Please Enter thou's name");
                string userName = Console.ReadLine();

                // Running my mainmenu
                bool startApp = false;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hell low {userName}");
                    Console.ResetColor();
                    MainMenu(userName);
                    Console.WriteLine("Do you want to try again? ((Y/y)es, (N/n)o)");
                    string userAnswer = Console.ReadLine();
                    if (userAnswer == "Y" || userAnswer == "yes" || userAnswer == "y" || userAnswer == "Yes")
                    {
                        startApp = false;
                    }
                    else
                    {
                        startApp = true;
                        Console.WriteLine("Thanks for Playing {0}", userName);
                        Environment.Exit(0);
                    }
                } while (!startApp);
            }
            catch (Exception)
            {

                Console.WriteLine("You have put invalid input, please restart!");
            }  
        }

        public static void MainMenu(string name)
        {
            int firstValue;
            int secondValue;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please choose operator for Awesome calculator (+, -, * , /)");
            Console.ResetColor();
            string userChoice = Console.ReadLine();
            bool userBool = false;
            while (!userBool)
            {
                if (userChoice == "+" || userChoice == "-" || userChoice == "*" || userChoice == "/")
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter correct operator");
                Console.ResetColor();
                userChoice = Console.ReadLine();
            }
            Console.WriteLine("Enter first value ! ");
            bool firstBool = Int32.TryParse(Console.ReadLine(), out firstValue);
            while (!firstBool)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Put a numerical value -_-;");
                Console.ResetColor();
                firstBool = Int32.TryParse(Console.ReadLine(), out firstValue);
            }
            Console.WriteLine("Enter second value ~ ");
            bool secondBool = Int32.TryParse(Console.ReadLine(), out secondValue);
            while (!secondBool)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Put a numerical value -_-;");
                Console.ResetColor();
                secondBool = Int32.TryParse(Console.ReadLine(), out secondValue);
            }

            if (userChoice == "+") 
            {
                Add(firstValue, secondValue);
                
            } 
            else if (userChoice == "-")
            {
                Subtract(firstValue, secondValue);
            }
            else if (userChoice == "*")
            {
                Multiply(firstValue, secondValue);
            }
            else if (userChoice == "/")
            {
                Divide(firstValue, secondValue);
            }
        }

        static void Add(int x, int y)
        {
            int totalSum = x + y;
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The answer for {x} + {y} is {totalSum}");
            Console.ResetColor();
        }

        static void Subtract(int x, int y)
        {
            int totalSub = x - y;
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The answer for {x} - {y} is {totalSub}");
            Console.ResetColor();
        }
        static void Multiply(int x, int y)
        {
            int totalProduct = x * y;
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The answer for {x} * {y} is {totalProduct}");
            Console.ResetColor();
        }
        static void Divide(int x, int y)
        {
            int totalDivision = x / y;
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The answer for {x} / {y} is {totalDivision}");
            Console.ResetColor();
        }
    }
}
