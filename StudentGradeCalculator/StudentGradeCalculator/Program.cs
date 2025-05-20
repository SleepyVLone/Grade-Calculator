using System;
using System.IO;
using System.Collections.Generic;
using StudentGradeCalculator;

namespace StudentGradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Student Grade Calculator");

            List<Student> studentList = new List<Student>();

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"\nEntering data for Student {i + 1}:");

                Console.Write("Enter student's name: ");
                string studentName = Console.ReadLine();

                Console.Write("Enter student's age: ");
                int studentAge = int.Parse(Console.ReadLine());

                Console.Write("Enter student's band: ");
                string studentBand = Console.ReadLine();

                Console.Write("Enter student's mark: ");
                int studentMark = int.Parse(Console.ReadLine());

                Student student = new Student(studentName, studentAge, studentBand, studentMark);
                studentList.Add(student);
            }

            Console.WriteLine("\nAll students have been added successfully! Details displayed below");
            Console.WriteLine("\n");

            foreach (var Student in studentList)
            {
                Student.DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}

