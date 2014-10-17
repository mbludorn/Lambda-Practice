using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic");
            Car car2 = new Car();

            Console.WriteLine(myCar.GetInfo());
            Console.WriteLine(car2.GetInfo());

            myCar.Honk();

            //Create a Student
            Student Pat = new Student(10001, "Pat", "McClary");

            //Add a Course
            Pat.Courses.Add(new Course("Professional Development", "B"));
            Pat.Courses.Add(new Course("Hockey", "A"));
            Pat.Courses.Add(new Course("Intro to Programming", "D"));
            Pat.Courses.Add(new Course("English", "B"));
            Pat.Courses.Add(new Course("Math", "C"));

            //Call the function
            Pat.PrintInfo();


            //keep the console open
            Console.ReadKey();
        }
    }
}
