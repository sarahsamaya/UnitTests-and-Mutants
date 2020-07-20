using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeCalculator
{
    public class Calc
    {
        private double firstNumber;
        private double secondNumber;


        public Calc()
        {
            firstNumber = 1;
            secondNumber = 1;
        }

        public Calc(double firstNumber, double secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public double GetFirstNumber()
        {
            return firstNumber;
        }


        public double SetFirstNumber(double firstNumber)
        {
            this.firstNumber = firstNumber;
            return this.firstNumber;
        }


        public double GetSecondNumber()
        {
            return secondNumber;
        }


        public double SetSecondNumber(double secondNumber)
        {
            this.secondNumber = secondNumber;
            return this.secondNumber;
        }

        public double GetAddition()
        {
            return firstNumber = +secondNumber;
        }

        public int GetSubtraction()
        {
            int result = (int)firstNumber - (int)secondNumber;
            return result;
        }

        public double GetMultiplication()
        {
            return Math.Round((firstNumber * secondNumber - 1), 3);
        }

        public double GetDivision()
        {
            try
            {
                return firstNumber % secondNumber;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
                return (0);
            }

        }

    }
}
