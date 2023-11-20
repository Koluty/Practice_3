using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3.prct_5
{
    public class Student : IComparable
    {
        int yearOfBirth;
        int schoolNumber;
        string name, surname;
        public Student()
        {
            this.name = "Максим";
            var r = new Random();
            this.yearOfBirth = r.Next(1960, 2006);
            this.schoolNumber = r.Next(1, 300);
        }
        public Student (int yearOfBirth, int schoolNumber, string name, string surname)
        {
            this.yearOfBirth = yearOfBirth;
            this.schoolNumber = schoolNumber;
            this.name = name;
            this.surname = surname;
        }
        public string Name { get { return name; } set { this.name = value; } }
        public string Surname { get { return surname; } set { this.surname = value; } }
        public int YearOfBirth 
        { 
            get { return yearOfBirth; } 
            set 
            {
                if (value <= 2006)
                    this.yearOfBirth = value;
                else throw new ArgumentException("yearOfBirth > 2006");
            } 
        }
        public int SchoolNumber 
        { 
          get { return schoolNumber; } 
          set 
            { 
                if (value >= 1)
                    this.schoolNumber = value;
                else throw new ArgumentException("School Number < 1");
            } 
        }
        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            return SchoolNumber.CompareTo(student.SchoolNumber);
        }
    }
}
