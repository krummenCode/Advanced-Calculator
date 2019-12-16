using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calcClass;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcMethods myCalculatorMethods = new CalcMethods();

            //Welcome
            Console.WriteLine("Welcome to my Calculator App refactored! We have added new features Modulus(%) and Power(^)!");


            //Ask for first number from user
            Console.WriteLine("Please enter your first number...");
            //Take firstNumber from the console. (Must convert readline from string to decimal)
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());


            //Pick your opperation 
            Console.WriteLine("Pick an operation ( + , - , * , / , % , ^ )");
            //Take opperation
            string Operation = Console.ReadLine();


            //Enter Second Number
            Console.WriteLine("Enter Second Number");
            //Take secondNumber from console. (Must convert readline from string to decimal)
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());


            //Call operation method switch case
            switch (Operation)
            {
                case "+":
                    Console.WriteLine(" = " + myCalculatorMethods.Add(firstNumber, secondNumber));
                    break;

                case "-":
                    Console.WriteLine(" = " + myCalculatorMethods.Subtract(firstNumber, secondNumber));
                    break;

                case "*":
                    Console.WriteLine(" = " + myCalculatorMethods.Multiply(firstNumber, secondNumber));
                    break;

                case "/":
                    Console.WriteLine(" = " + myCalculatorMethods.Divide(firstNumber, secondNumber));
                    break;

                case "%":
                    Console.WriteLine(" = " + myCalculatorMethods.Modulus(firstNumber, secondNumber));
                    break;

                case "^":
                    Console.WriteLine(" = " + myCalculatorMethods.Power(firstNumber, secondNumber));
                    break;

                default:
                    Console.WriteLine("You didn't enter a valid operation mehtod");
                    break;
            }


            //Exit Program
            Console.WriteLine("Press any key to exit program...");
            Console.ReadKey();
        }
    }
}
