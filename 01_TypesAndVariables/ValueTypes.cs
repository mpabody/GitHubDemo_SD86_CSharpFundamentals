using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;

            isDeclared = true;

            bool isDeclaredAndInitialized = false;
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '4';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            short shortExample = 32767; // max value for short/Int16
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 15;
            int b = -10;

            byte age = 25;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            Console.WriteLine(1.2578907289045789789789789787897f);

            double doubleExample = 1.789053278907036d;
            Console.WriteLine(1.2578907289045789789789789787897d);

            decimal decimalExample = 1.2578907289045789789789789787897m;
            Console.WriteLine(1.2578907289045789789789789787897m);

            // Notice we can type as much as we want for our types with decimals
            // This does not mean it holds this value. Write it to the console to see what shows up
            // This gives the students a nice example of seeing the Test output as well
        }

        enum PastryType { Cake, Cupcake, Eclaire, Danish, Canoli}

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Canoli;
            PastryType anotherPastry = PastryType.Danish;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime birthday = new DateTime(1988, 04, 11);

            TimeSpan age = today - birthday;

            Console.WriteLine(age.Days / 365);
        }
    }
}