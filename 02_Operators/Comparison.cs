﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        // Often in C# we will want to be able to compare different objects
        // We have another set of Operators we can use for this
        [TestMethod]
        public void ComparisonOperators()
        {
            // Let's start with some variables to use when comparing values
            int age = 25;
            string username = "Joshua";

            // Checking if something is equal to something else can be done with two equal signs (==) in C#
            bool equals = age == 41;
            bool userIsAdam = username == "Adam";
            Console.WriteLine("User is 41: " + equals);
            Console.WriteLine("User is Adam: " + userIsAdam);

            // Checking inequality in C# is done with the Bang operator (!) followed by an equal sign
            bool notEqual = age != 112; //-- Bang operator
            bool userIsNotJustin = (username != "Justin");
            Console.WriteLine($"User is not 112: {notEqual}");
            Console.WriteLine($"User is not Justin: {userIsNotJustin}");

            // A slightly harder concept to grasp is equality with reference types
            // In C#, because we're dealing with computers, we have to consider how the memory works
            // NOTE: Now would be a good time to discuss Stack vs Heap (value vs reference etc)
            // We can see a difference between value and reference types by creating and comparing a couple reference types
            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            // Now we have two lists that both contain the same string
            // It is best to breakpoint this and show the values
            // But even so, what happens if we compare the two?
            bool listsAreEqual = firstList == secondList;
            Console.WriteLine($"The lists are the same: {listsAreEqual}");
            // Because the references are different, they are not equal
            // They do not share the same memory reference (pointer)


            // Moving on to other comparisons we have:
            // Greater than
            bool greaterThan = age > 12;

            // Greater than or Equal to
            bool greaterThanOrEqual = age >= 24;

            // Less than
            bool lessThan = age < 66;

            // Less than or Equal to
            bool lessThanOrEqual = age <= 24;

            // We can start to add complexity to our comparisons by checking multiple comparisons with OR and AND
            // OR comparison
            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;
            Console.WriteLine($"True or True: {tOrT}");
            Console.WriteLine($"True or False: {tOrF}");
            Console.WriteLine($"False or True: {fOrT}");
            Console.WriteLine($"False or False: {fOrF}");

            // AND comparison
            bool andValue = greaterThan && orValue;

            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;
            Console.WriteLine($"True and True: {tAndT}");
            Console.WriteLine($"True and False: {tAndF}");
            Console.WriteLine($"False and True: {fAndT}");
            Console.WriteLine($"False and False: {fAndF}");
        }
    }
}
