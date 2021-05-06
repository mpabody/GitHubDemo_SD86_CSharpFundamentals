using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        // Now that we're aware of how to compare values in C#, what do we do with this knowledge?
        // Typically we'll set up chunks of code to execute only if a condition, like the ones we've explored before, is met

        // To show this off we'll introduce the most basic of conditionals, an if statement
        // Most people don't think about it, but we run our lives off of boolean logic
        // If hungry, eat. If tired, sleep. If bad, get good. We can show this here
        [TestMethod]
        public void IfStatements()
        {
            // We'll start with a simple boolean value. We can change this to show different outcomes
            bool userIsHungry = true;
            if (userIsHungry)
            {
                // Put code that should fire off if the userIsHungry condition is true inside these braces
                Console.WriteLine("Eat something!");
            }

            // Again we'll create a simple bit of default data with this variable
            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying?");
            }
        }

        // Now that we have the ability to do something if our defined condition is met, we can add another step
        // If our condition is met, do A. For anything else, do B.
        [TestMethod]
        public void IfElseStatements()
        {
            // Here we have a boolean. We can change it to see the different routes
            bool choresAreDone = false;
            if (choresAreDone) //-- This is the condition for both the if and else
            {
                // If the condition evaluates as true, we'll run the first section
                Console.WriteLine("Have fun at the movies!");
            }
            else //-- Just the else keyword without another condition
            {
                // If the condtion does not evaluate as true, we run this chunk of code
                Console.WriteLine("You must stay home and finish your chores!");
            }

            // Obviously we cannot have an else without an if first

            // Here we're introducing the concept of simulating user input
            // If the user is submitting a string we can't compare it so we need to convert it
            string input = "7";
            int totalHours = int.Parse(input);

            if (totalHours >= 8) //-- first if
            {
                Console.WriteLine("You should be well rested.");
            }
            else //-- first else, just like what we saw before
            {
                Console.WriteLine("You might be tired today.");

                // Here you can see another if statement embedded inside our first if's else
                if (totalHours < 4) //-- second if
                {
                    Console.WriteLine("You should get more sleep!");
                }
            }

            // Sometimes we'll know that we're going to need to check multiple conditions
            // You might see a stack of if else statements, so let's make one

            int age = 7;
            // Here we have chained if else statements.
            if (age > 17)
            {
                Console.WriteLine("You're an adult.");
            }
            else
            {
                if (age > 6) //-- Notice there's nothing inside the first else statement before the if
                {
                    Console.WriteLine("You're a kid.");
                }
                else if (age > 0) //-- This time we just put the if right after the else so it reads easier
                {
                    Console.WriteLine("You're far too young to be on a computer");
                }
                else
                {
                    Console.WriteLine("You're not born yet.");
                }
            }

            // Here we can show off the AND, OR, EQUAL, and NOT EQUAL operators again
            if (age < 65 && age > 18)
            {
                // And comparison
                Console.WriteLine("Age is between 18 and 65.");
            }

            if (age > 65 || age < 18)
            {
                // Or comparison
                Console.WriteLine("Age is either greater than 65 or less than 18.");
            }

            if (age == 21)
            {
                // Is equal to
                Console.WriteLine("Age is equal to 21.");
            }

            if (age != 36)
            {
                // Not equals to
                // Bang operator
                Console.WriteLine("Age is not equal to 36.");
            }
        }
    }
}
