using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Michael";
            string lastName = "Pabody";

            //string concatenation
            string concatenatedFullName = firstName + ' ' + lastName;

            Console.WriteLine(concatenatedFullName);

            //composite formatting
            string compositeFullName = string.Format("{0} {1} {2}", firstName, lastName, "is the best ever! duh...");
            Console.WriteLine(compositeFullName);

            string interpolatedFullName = $"{firstName} {lastName}";
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void Collections()
        {
            //-- Arrays
            // We'll start by declaring a string so that we can use it in our array, our first type of collection
            string stringExample = "Hello World!";

            // Here we're declaring our array, using the square brackets []
            // Notice the type that the array holds is given before the brackets, in this case it's string[]. This means this array only holds strings
            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample, "?" };

            // We can use these square brackets to read or write to a specific index
            // Here we're reading from the index with the value of 2, or the third item (0, 1, 2...)
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            // Here we're instead writing to the index with the value of 0, or the first item
            stringArray[0] = "Hey there";
            // We can now see the change by reading from that index and writing it to the console.
            Console.WriteLine(stringArray[0]);


            //-- Lists
            // You'll need to bring in the using namespace for collections here
            // This is a good time to mention the using statements at the top of the file
            // Using statements allow us to "use" code that is written somewhere else
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();

            listOfStrings.Add("First string for our list");
            listOfIntegers.Add(461012);

            // We can also reference items in Lists with their index
            Console.WriteLine(listOfIntegers[0]);


            //-- Queues
            // Here we new up a new Queue that holds strings
            Queue<string> firstInFirstOut = new Queue<string>();

            // Unlike Lists, we have the Enqueue method instead of an Add method to add items to the Queue
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next!");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);


            //-- Dictionaries
            // Here we're declaring a new Dictionary that has int as its key type and string as its value type
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            // With our dictionary now declared, we can add something to it with the Add method
            // Notice we need to give it both the Key's value and the Value's value
            keyAndValue.Add(7, "Agent");

            string valueSeven = keyAndValue[7];
            Console.WriteLine(valueSeven);

            //-- Other Collection Examples
            // Here are a few other collection types we won't be diving into right now but we want to show off
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }

    }
}
