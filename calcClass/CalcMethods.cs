using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcClass
{
    public class CalcMethods
    {
        //Addition
        public decimal Add(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        //Subtraction 
        public decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        //Multiplication
        public decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        //Division
        public decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }

        //Remainder
        public decimal Modulus(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber % secondNumber;
        }

        //Power
        public decimal Power(decimal firstNumber, decimal secondNumber)
        {
            //pow only works on doubles
            //Convert decimals to doubles
            double firstDouble = decimal.ToDouble(firstNumber);
            double secondDouble = decimal.ToDouble(secondNumber);
            double solutionDouble =  Math.Pow(firstDouble, secondDouble);
            return Convert.ToDecimal(solutionDouble);


        }
    }
}
