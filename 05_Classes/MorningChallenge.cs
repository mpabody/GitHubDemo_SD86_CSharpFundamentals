using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum CourseType { Cyber, SoftwareDev, WebDev}
    public enum BadgeType { Gold, Blue, Red}
    public class Student
    {
        public Student() { }
        public Student(string firstName, string lastName, DateTime dateOfBirth, CourseType typeOfCourse, decimal balanceOwed, BadgeType typeOfBadge, bool hasGraduated)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TypeOfCourse = typeOfCourse;
            BalanceOwed = balanceOwed;
            TypeOfBadge = typeOfBadge;
            HasGraduated = hasGraduated;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CourseType TypeOfCourse { get; set; }
        public decimal BalanceOwed { get; set; }
        public BadgeType TypeOfBadge { get; set; }
        public bool HasGraduated { get; set; }
    }
    public class Instructor
    {
        public Instructor(int employeeNumber)
        {
            EmployeeNumber = employeeNumber;
            Console.WriteLine("Hello new employee");
        }

        public Instructor(string firstName, string lastName, DateTime dateOfBirth, CourseType typeOfCourse, int employeeNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TypeOfCourse = typeOfCourse;
            EmployeeNumber = employeeNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CourseType TypeOfCourse { get; set; }
        public int EmployeeNumber { get; }

    }
}
