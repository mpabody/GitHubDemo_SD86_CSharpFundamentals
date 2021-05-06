using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Ternary
    {
        // When we know we want to assign a value based on a certain condition, we can use a Ternary
        // Ternaries are a conditional operator that evaluate a boolean and then returns/outputs the predefined correct value.
        // In C#, ternaries are only good for value assignment. This means we can't have a ternary only execute code.
        [TestMethod]
        public void Ternaries()
        {
            int age = 31;

            // Here's oure Ternary structure
            // (Condition/Boolean) ? trueResult : falseResult;
            bool isAdult = (age > 17) ? true : false;
            Console.WriteLine("Age is over 17: " + isAdult);

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo);

            // Here we can see we're not just assigning a variable some value
            // Instead, the output is being passed into the WriteLine method
            Console.WriteLine((numTwo == 30) ? "True" : "False");
        }
    }
}
