using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
        }
    }
    class Program
    {
        static void Main()
        {
            Student Alice = new Student("Alice", 20);
            Student Bod = new Student("Bod", 22);
            Student Charlie = new Student("Charlie", 21);
            List<Student> studentList = new List<Student>();
            studentList.Add(Alice);
            studentList.Add(Bod);
            studentList.Add(Charlie);
            foreach (var student in studentList)
            {
                student.DisplayInfo();
            }
            Console.ReadLine();
        }
    }
}
