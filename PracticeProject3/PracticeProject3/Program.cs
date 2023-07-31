using System;
using System.Collections.Generic;
using System.IO;

namespace PracticeProject3
{
     class Student
     {
        public string Name { get; set; }
        public string StudentClass { get; set; }

        public Student(string name, string studentClass)
        {
            Name = name;
            StudentClass = studentClass;
        }
     }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path for student data:");
            string fileName = Console.ReadLine();
            List<Student> students = ReadStudentData(fileName);
            if (students.Count == 0)
            {
                Console.WriteLine("No student data found.");
                return;
            }

            Console.WriteLine("Student Data:");
            DisplayStudents(students);

            Console.WriteLine("\nStudent Data Sorted by Name:");
            students.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
            DisplayStudents(students);

            Console.WriteLine("\nEnter a student's name to search:");
            string searchName = Console.ReadLine();
            SearchAndDisplayStudent(students, searchName);
        }

        static List<Student> ReadStudentData(string filePath)
        {
            List<Student> students = new List<Student>();

            try
            {              
                string[] line = File.ReadAllLines(filePath);
                foreach (string s in line)
                {
                    string[] data = s.Split(',');
                    if (data.Length == 2)
                    {
                        string name = data[0].Trim();
                        string studentClass = data[1].Trim();
                        students.Add(new Student(name, studentClass));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading student data: " + ex.Message);
            }

            return students;
        }

        static void DisplayStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, {student.StudentClass}");
            }
        }

        static void SearchAndDisplayStudent(List<Student> students, string searchName)
        {
            bool found = false;

            foreach (var student in students)
            {
                if (student.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Student found: {student.Name}, {student.StudentClass}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Student not found.");
            }
        }
    }   
}
