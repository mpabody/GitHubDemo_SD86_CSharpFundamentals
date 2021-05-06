using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double AddTwoNumbers(int numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        // Challenge???


        public int SubtractTwoNumbers(int numOne, int numTwo)
        {
            int difference = numOne - numTwo;
            return difference;
        }

        public int MultiplyTwoNumbers(int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;
        }

        public double DivideTwoNumbers(double numOne, double numTwo)
        {
            double quotient = numOne / numTwo;
            return quotient;
        }

        public int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            // Here we can show off how we can use multiple methods to interact with each other
            // If the students need you can break this into different executing statements
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}