using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeCalculator
{
    public class Student
    {
        private string studentName;
        private int studentAge;
        private string studentBand;
        private int studentMark;
        private string studentGrade;

        public Student(string name, int age, string band, int mark)
        {
            studentName = name;
            studentAge = age;
            studentBand = band;
            studentMark = mark;
            studentGrade = "";
        }

    public void DisplayDetails()
        {
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Band: " + studentBand);
            Console.WriteLine("Mark: " + studentMark);
            Console.WriteLine("Grade: " + studentGrade);
        }


    }
}
