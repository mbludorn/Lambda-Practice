using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Practice
{
    public class Car
    {
        //Step 1: Declare properties
        //Declare properties and variables
        //variables for the make property
        private string _make;
        //Declare the Make Property
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value.ToUpper();
            }
        }

        //shorthand versions of a property
        //code snippit: prop (tab)(tab)
        public string Model { get; set; }

        //Step 2:Declare Constructer

        public Car(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public Car()
        {
            this.Model = ("undifined");
            this.Make = ("undifined");
        }

        //Step 3: Methods and Functions
        public void Honk()
        {
            Console.WriteLine("Beep beep");
            Console.Beep();
            Console.Beep();
        }

        public string GetInfo()
        {
            //returns a string wih information about the car
            return this.Make + " " + this.Model;
        }
 
    }
}
