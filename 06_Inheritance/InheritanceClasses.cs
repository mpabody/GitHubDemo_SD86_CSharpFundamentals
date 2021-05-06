using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string PhoneNumber { get; set; }
        public int MyProperty { get; set; }
        public string Email { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine("I am a person");
        }
    }

    public class Customer : Person
    {
        public bool IsPremium { get; set; }
        public Customer() { }
        public Customer(bool isPremium, string firstName, string lastName, string phoneNumber, string email)
            : base(firstName, lastName, phoneNumber, email)
        {
            IsPremium = isPremium;
        }

        public override void WhoAmI()
        {
            base.WhoAmI();
            Console.WriteLine("I am an Employee");
        }
    }
    public class Employee : Person
    {
        public int EmployeeNumber { get; }
        public DateTime HireDate { get; set; }

        public int YearsWithCompany
        {
            get
            {
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalTime));
            }
        }

        public Employee(int employeeNumber)
        {
            EmployeeNumber = employeeNumber;
        }
    }

    public class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }

        public HourlyEmployee(int EmployeeNumber) : base(EmployeeNumber) { }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public SalaryEmployee(int number, decimal salary) : base(number)
        {
            Salary = salary;
        }
    }

    public interface IAmAnInterface
    {
        int ID { get; set; }
        string IMove();
    }

    public abstract class AmAnInterface
    {
        public int ID { get; set; }
        public abstract string Move();
    }

    //public class ChildClass : AmAnInterface, IAmAnInterface
    //{
    //     public string IMove()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
