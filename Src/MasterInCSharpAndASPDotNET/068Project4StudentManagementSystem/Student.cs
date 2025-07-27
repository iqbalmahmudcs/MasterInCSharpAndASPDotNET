using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _068Project4StudentManagementSystem
{
    public class Student
    {
        public string? Name { get; set; }
        public DateTime? DateOfBirth 
        {
            get;
            private set;
        }
        public int? Age => CalculateAge();  //public int? Age { get { return CalculateAge(); } }
        public string? RollNumber { get; private set; }

        public Student() { }

        public Student(string name, DateTime dateOfBirth, string rollNumber) 
        {
            ValidateInput(name, dateOfBirth, rollNumber);
            Name = name;
            DateOfBirth = dateOfBirth;
            RollNumber = rollNumber;
        }

        private static void ValidateInput(string name, DateTime dateOfBirth, string rollNumber)
        {
            if (dateOfBirth > DateTime.Now)
                throw new ArgumentException("Date of birth can't be in the future!");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name can't be null or empty!");
            if (string.IsNullOrWhiteSpace(rollNumber))
                throw new ArgumentException("Roll Number can't be null or empty!");
            if (dateOfBirth == default)
                throw new ArgumentException("Date of birth can't be null!");
        }

        private int CalculateAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Value.Year;

            return DateTime.Now < DateOfBirth.Value.AddYears(age) ? age-- : age;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"\nStudent Details");
            Console.WriteLine($"===============");
            Console.WriteLine($"Name:             {Name}");
            Console.WriteLine($"Date of Birth:    {DateOfBirth?.ToShortDateString() ?? "N/A"}");
            Console.WriteLine($"Age:              {Age}");
            Console.WriteLine($"Roll Number:      {RollNumber}");
        }



    }
}
