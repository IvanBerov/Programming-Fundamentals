using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] commArgs = Console.ReadLine().Split();
                string firstName = commArgs[0];
                string lastName = commArgs[1];
                double grede = double.Parse(commArgs[2]);

                Student student = new Student(firstName, lastName, grede);

                students.Add(student);
            }
            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Student currStudent in students)
            {
                Console.WriteLine(currStudent);
            }
        }
    }
    class Student
    {
        public Student (string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
