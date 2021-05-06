using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Greeter
    {
        // So far we've been seeing all these different Test Methods
        // We've only been using Test Methods so we can utilize the Microsoft's Testing Framework to run the code
        // Notice that all of our methods have been inside a class so far
        // This will be a constant, always make sure your methods you declare are inside classes

        // Let's start by declaring our first custom method
        // The method structure:
        // 1 Access Modifier => Using public for this example, will cover these more later
        // 2 Return Type => We've seen this void before, means we are not returning anything
        // 3 Method Signature which is made up of the method name and parameters
        // 4 Body of code that gets executed
        //1      2           3
        public void SayHello(string name)
        {
            //4
            Console.WriteLine($"Hello, {name}!");
        }

        public void SaySomething(string speech)
        {
            Console.WriteLine(speech);
        }

        public string GetRandomGreeting()
        {
            Random rand = new Random();
            string[] greetings = new string[] { "Hello", "Hi", "Sup", "Yo", "Hey" };
            int randomNumber = rand.Next(0, greetings.Length);
            string greeting = greetings[randomNumber];

            return greeting;
        }
    }
}
