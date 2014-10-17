using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digital_code
{
   class Program
    {
        static void Main(string[] args)
        {
            //Call Digital Root with number 31337
            DigitalRoot("31337");
            //45734
            DigitalRoot("45734");
            //12345678910
            DigitalRoot("12345678910");
            //Keep console open
            Console.ReadKey();
        }
        //create a function DigitalRoot
        //with parameter rootThis
        static void DigitalRoot(string rootThis)
        {
            string input = rootThis;
            //set output to 0
            int output = 0;
            //create a while loop to loop through the function and return a single integer
            while (rootThis.Length > 1)
            {
                output = 0;
                for (int i = 0; i < rootThis.Length; i++)
                {
                    output += int.Parse(rootThis[i].ToString());
                }
                rootThis = output.ToString();

            }
            //print out Input: 
            Console.WriteLine("Input: " + input);
            //print out Output:
            Console.WriteLine("Output: " + rootThis);
        }
    }
