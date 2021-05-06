using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void VehiclePropertiesTests()
        {
            // We need to start by newing up an instance of our Vehicle class
            Vehicle firstVehicle = new Vehicle();


            firstVehicle.Make = "Honda";
            // Now that the Make property is set, we can read from it
            Console.WriteLine(firstVehicle.Make);

            // Let's now set the other values as well
            firstVehicle.Model = "Civic";
            firstVehicle.Mileage = 30000;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            // Now we should have a Vehicle object with all properties assigned
            // Go ahead and break point this if you have not already
            // We can see that we can pull from this object now as well
            string carDetails = $"{firstVehicle.Make} {firstVehicle.Model}";
            Console.WriteLine(carDetails);
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            // Let's declare a new Vehicle instance so we can start utilizing the methods we just made
            Vehicle transport = new Vehicle();
            transport.IndicateLeft();

            // Let's also just write out so we know what happened
            Console.WriteLine("Indicating left");

            // Let's now write out to show which indicator is blinking
            Console.WriteLine($"Right Indicator: {transport.RightIndicator}");
            Console.WriteLine($"Left Indicator: {transport.LeftIndicator}");

            // If we want to use that code again, we might as well throw it into a method

            transport.IndicateRight();
            Console.WriteLine("Indicating right");

            transport.TurnOnHazards();
            Console.WriteLine("Turning on Hazards");
        }

        [TestMethod]
        public void VehicleConstructors()
        {
            // Now that we have a class that we can create objects from, we can start to see how reusable it can be
            // Let's go ahead and make another vehicle
            Vehicle car = new Vehicle();
            car.Make = "Toyota";
            car.Model = "Corolla";
            car.Mileage = 213000;
            car.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(car.Make + " " + car.Model);

            // We should be starting to see something with our vehicles
            // Every time we make a new Vehicle we have to use up 5 lines of code
            // We can slim this down by introducing a Constructor back in the Vehicle code

            // Now that we've made our Constructors, let's create a new Vehicle

            ////Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 300000, VehicleType.Spaceship);
            //Console.WriteLine(rocket.Make);
            //Console.WriteLine(rocket.TypeOfVehicle);
        }

        [TestMethod]
        public void GreeterMethodsTests()
        {
            Greeter greeterInstance = new Greeter();

            greeterInstance.SayHello("Amanda");

            string greeting = greeterInstance.GetRandomGreeting();

            greeterInstance.SaySomething(greeting);

            greeterInstance.SaySomething(greeterInstance.GetRandomGreeting());
        }

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calculator = new Calculator();

            int sum = calculator.AddTwoNumbers(7, 5);
            Console.WriteLine(sum);

            double doubleSum = calculator.AddTwoNumbers(15, 135);
            Console.WriteLine(doubleSum);

            int age = calculator.CalculateAge(new DateTime(1988, 04, 11));
            Console.WriteLine(age);
        }

        [TestMethod]
        public void StudentTests()
        {
            Student james = new Student();
            james.FirstName = "James";

            Instructor jacob = new Instructor(1);
            Console.WriteLine(jacob.EmployeeNumber);
            jacob.FirstName = "Michael";
            jacob.LastName = "Torr";
        }
    }
}
