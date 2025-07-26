using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _068Project4StudentManagementSystem
{
    public class Student
    {
        private string? _name;
        private DateTime? _dateOfBirth;
        private string? _rollNumber;

        public string? Name { get { return _name; } set { _name = value; } }
        public DateTime? DateOfBirth 
        { 
            get { return _dateOfBirth; } 
            set 
            { 
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Date of birth can't be in the future.");
                }
                _dateOfBirth = value; 
            } 
        }
        public int? Age { get { return CalculateAge(); } }
        public string? RollNumber { get { return _rollNumber; } set{ _rollNumber = value;} }

        public Student() { }

        public Student(string name, DateTime dateofBirth, string rollNumber) 
        {
            Name = name;
            DateOfBirth = dateofBirth;
            RollNumber = rollNumber;
        }

        private int CalculateAge()
        {
            if (_rollNumber == null)
                return 0;

            int age = DateTime.Now.Year - DateOfBirth.Value.Year;
            return age;
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
