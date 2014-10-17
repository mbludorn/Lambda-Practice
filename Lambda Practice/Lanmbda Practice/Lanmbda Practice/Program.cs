using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        public void Greet();
    //call the Function Greet();
   

        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            //declare a variable kayakProduces and set it equal to all products that contain the word "Kayak"
            List<string> kayakProduces = products.Where(x => x.Contains("Kayak")).ToList();                                           
           
                  
            //print the kayakProducts to the console using a foreach loop.
            foreach (var kayak in kayakProduces)
	        {
            Console.WriteLine(kayak);
		    }
            
           
            
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();
           
            
            //print the shoeProducts to the console using a foreach loop or string.Join().
            foreach (var item in shoeProducts )
	        {
		    Console.WriteLine(item);
	        }

            ||
            Console.WriteLine(string.Join(" ,", shoeProducts));
           
            
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.ToLower().Contains("balls")).ToList();
            
            
            //print the ballProducts to the console using a foreach loop or string.Join().
            foreach (var ball in ballProducts)
	        {
		    Console.WriteLine
	        }

            ||
            Console.WriteLine(string.Join(" ,", ballProducts)); 
            
           

            //sort ballProducts alphabetically and print them to the console.
            Console.WriteLine(string.Join(" ,", ballProducts.OrderBy(x => xx));
            List<string> newballProducts = products.OrderBy(x => x.Length).ThenBy(x => x).ToList();
           
            
            //add six more items to the products list using .add();
            products.Add("tennis ball");
            products.Add("Hockey Puck");

             

            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine(products.OrderByDescending(x =>x.Length.First));
            //order the list by length, and print them out to the console.
            string
            //order by sorts by length, then sort by alphabetically 
            List<string> newProduct = newProducts++0rderBydescending(x => x.Length).ThenBy(x => x).ToList();
            {          
                Console.WriteLine(20);
            }
       
            
            //print the product with the shortest name to the console using OrderByDesceding() and the .First() extension.
             List<string> sorted = newProduct.OrderByDesending(x => x.Length).ThenBy(x => x).ToList().First();
            
           
            //Print the 3 product with the 4th shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            List<string> sorted  = newProduct.OrderByDesending(x => x.LengthThenBy(x => x).ToList();
            List<string> (x => x.Length).ToList();
            Console.WriteLine(sorted.Skip(3).Take(1).First());


            List<string> sorted = list.OrderBy(x => x.Length).ToList();
            //skip two items print the third (skip the first two take the next one and print the first one of the list
             Console.WriteLine(sorted.Skip(2).Take(1).First());

            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Line<string> longest = List.OrderedBy(x =>x.Length).ThenBy(x=>x).ToList();
            Console.WriteLine(longest.Skip(1).Take(1).First());
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).

            //print out the reversedProducts to the console using a foreach loop.

            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //Note: you will not use a variable to store your list

            Console.ReadKey();
         }
      
    
