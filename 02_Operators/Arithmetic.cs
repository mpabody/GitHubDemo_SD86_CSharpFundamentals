using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Start out with a few different variables, here we have two different integers
            // While we're keeping it simple, you may want to mention that names like a and b are not advisable
            int a = 22;
            int b = 15;

            // Addition: +
            // Earlier we talked about declaration and initialization. Another term to add is assignment
            // Any time we want to assign a value to a variable, we complete the statements on the right side first
            // We then assign the final value to the variable on the left side of the assignment operator (=)
            int sum = a + b;
            Console.WriteLine(sum);

            // Subtraction: -
            int difference = a - b;
            Console.WriteLine(difference);

            // Multiplication: *
            int product = a * b;
            Console.WriteLine(product);

            // Division: /
            int quotient = a / b; //-- With whole numbers it drops any remainder/decimal
            Console.WriteLine(quotient);

            // Remainder: %
            // This is also know as modulus
            int remainder = a % b; //-- Returns only the remainder of the operation
            Console.WriteLine(remainder);


            // Another example for using operators is with DateTimes
            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);

            // Here we can take two different DateTime instances and calculate a TimeSpan
            // Obviously you can'y just do this with any types in C#
            TimeSpan timeSpan = now - someDay; //-- Again we see the subtraction operator being used
            Console.WriteLine(timeSpan);
        }
    }
}
