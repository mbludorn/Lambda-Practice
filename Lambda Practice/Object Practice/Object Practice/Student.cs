using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Practice
{
    class Student
    {
        //Step 1: Declare properties
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }

        //Step 2 Constructor
        public Student(int studentID, string firstName, string lastName)
    {
        this.StudentID = studentID;
        this.FirstName = firstName;
        this.LastName = lastName;
        //make sure to initialize the course list
        this.Courses = new List<Course>();
    } 

    //Stp 3: Methods and Functions
    public void PrintInfo()
    {
        Console.WriteLine("StudentID: " + this.StudentID);
        //write out each course and grade
        Console.WriteLine(string.Join("\n", this.Courses.Select(x => x.GetCourseInfo())));


        //OR DO A FOR LOOP
    //    foreach (var item in this.Courses)
    //{
    //     Console.WriteLine(item.GetCourseInfo());
    //}

        //write out total GPA
        Console.WriteLine("GradePoint:" + this.Courses.Average(x => x.GradePoints));
    }
    }
}
