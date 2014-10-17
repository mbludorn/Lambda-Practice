using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Practice
{
    class Course
    {
        //Step1: Declare a properties
        public string Name { get; set; }
        public int GradePoints { get; set; }

        //Declare a custom propety for letter grade
        private string _letterGrade;

        public string LetterGrade
        {
            get { return _letterGrade; }
            set
            {
                _letterGrade = value.ToUpper();
                //letter grade was set
                //update the grade point
                if (_letterGrade == "A")
                {
                    this.GradePoints = 4;
                }
                else if (_letterGrade == "B")
                {
                    this.GradePoints = 3;
                }
                else if (_letterGrade == "C")
                {
                    this.GradePoints = 2;
                }
                else if (_letterGrade == "D")
                {
                    this.GradePoints = 1;
                }
                else
                {
                    //assume fail
                    this.GradePoints = 0;
                }
            }



        }

        //Step 2: Constructors
        public Course(string name, string letterGrade)
        {
            //set the name of the course
            this.Name = name;
            //set the lettergrade
            this.LetterGrade = letterGrade;
            //the setter for letterGrade, will automatically set the GradePoints
        }
         

        //Step 3: Methods and/or Functions
        public string GetCourseInfo()
        {
            return this.Name + " " + this.GradePoints + " " + this.LetterGrade;
        }
    }  
}
