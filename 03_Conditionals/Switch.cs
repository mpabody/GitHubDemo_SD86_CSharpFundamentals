using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        enum WeekDay { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        // If statements are great for boolean statements
        // My age is greater than 18. I am of the type Human. These are both booleans.
        // My age is either greater than 18 or it is not. I am either an instance of the Human type or I am not.
        // It gets a little wordy if we're wanting to check a lot of different instances though. For that we can use a switch case
        [TestMethod]
        public void SwitchCases()
        {
            // The structure is as follows:
            //  The switch keyword.
            //  The value being evaluated (Located in the parentheses)
            //  The cases { Located in the curly braces }
            //    Each case has the keyword "case" followed by the value expected.
            //    If we're evaluating (age), I might have a "case 18:"
            //      After the case comes the code that will execute if this case is met.
            //      Each case also has to have some sort of escape.
            //      Often this will be done with a "break;" at the end.

            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will execute if no other case is evaluates as true. Defaults are not required.");
                    break;
            }

            // Day of the week
            WeekDay today = WeekDay.Tuesday;

            switch (today)
            {
                case WeekDay.Monday:
                case WeekDay.Tuesday:
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                case WeekDay.Friday:
                    Console.WriteLine("Hope you're ready to work!");
                    break;
                case WeekDay.Saturday:
                case WeekDay.Sunday:
                    Console.WriteLine("Sorry we're closed.");
                    break;
            }

            // We can also stack cases if we know they'll execute the same code
            int age = 37;

            switch (age)
            {
                case 18:
                    // Code for 18 year olds
                    break;
                case 19:
                    // Code for 19 year olds
                    break;
                case 20:
                    // Code for 20 year olds
                    break;
                case 21: //-- Here we see we can stack cases together over one chunk of code
                case 22:
                case 23:
                    // Code for ages from 21-23
                    break;
                default:
                    // If no specific case is met then you can use a default set of code
                    break;
            }
        }
    }
}
