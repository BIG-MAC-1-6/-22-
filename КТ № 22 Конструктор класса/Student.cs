using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ___22_Конструктор_класса
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public int StudentID;
        public string Major;


        // Конструктор
        public Student(string firstName, string lastName, int studentID, string major)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentID;
            Major = major;
        }

        // Деконструктор
        public void Deconstruct(out string firstName, out string lastName, out int studentID, out string major)
        {
            firstName = FirstName;
            lastName = LastName;
            studentID = StudentID;
            major = Major;
        }
    }
}