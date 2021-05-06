using _06_Inheritance.Animal_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _06_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonExamples()
        {
            Person newPerson = new Person();
            newPerson.FirstName = "Larry";
            newPerson.LastName = "Bird";
            Console.WriteLine(newPerson.FullName);


            //show that employee has inherited props from Employee AND Person
            Employee newEmployee = new Employee(31);
            newEmployee.FirstName = "Reggie";
            newEmployee.LastName = "Miller";
            Console.WriteLine(newEmployee.FullName);
            Console.WriteLine(newEmployee.EmployeeNumber);

            newEmployee.WhoAmI();

            
            SalaryEmployee newSalaryEmployee = new SalaryEmployee(33, 4000000);
            newSalaryEmployee.FirstName = "Myles";
            newSalaryEmployee.LastName = "Turner";
            Console.WriteLine(newSalaryEmployee.FullName);
            Console.WriteLine(newSalaryEmployee.EmployeeNumber);
            Console.WriteLine($"${newSalaryEmployee.Salary}");

            //----------------------------------------------------------
            List<Person> people = new List<Person>();
            people.Add(newPerson);
            people.Add(newEmployee);
            people.Add(newSalaryEmployee);
            
            foreach (var person in people)
            {
                Console.WriteLine(person.FullName); // only props availabe in Person are accessible
                //Console.WriteLine(person.EmployeeNumber); // can't access Employee props
            }
        }

        [TestMethod]
        public void MyTestMethod()
        {
            Person newPerson = new Person();
            Employee newEmployee = new Employee(31);
            SalaryEmployee newSalaryEmployee = new SalaryEmployee(33, 4000000);
            List<Person> people = new List<Person>();
            people.Add(newPerson);
            people.Add(newEmployee);
            people.Add(newSalaryEmployee);

            foreach (var person in people)
            {
                Console.WriteLine(person.FullName); // only props availabe in Person are accessible
                //Console.WriteLine(person.EmployeeNumber); // can't access Employee props
            }
        }
    }
}
