using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Daniel"; //Creating a string variable to save my first name
            Console.WriteLine("First name is: " + firstName); // displaying a simple sentence stating what my first name is
            string middleName = "Moises"; //creating a string variable to save my middle name 
            Console.WriteLine("Middle name is: " + middleName); // displaying a simple sentence stating what my middle name is
            string lastName = "Alvarez"; //creating a string variable to save my last name 
            Console.WriteLine("Last name is: " + lastName); // displaying a simple sentence stating what my last name is
            string fullName = firstName + " " + middleName + " " + lastName; //creating a string variable that concatenates my first, middle, and last name to create a full name variable
            Console.WriteLine("Full name is: " + fullName); // displaying a simple sentence stating what my full name is 
            string nameUpper = fullName.ToUpper(); //this take my full name and uppercases the entire string variable
            Console.WriteLine("Upper case full name is: " + nameUpper); // this displays a simple sentence that shows what my full name looks like if uppercase

            StringBuilder sb = new StringBuilder(); // this builds a string using the sentences below as well as organizing them some with new lines inserted
            sb.Append("\nHi, my name is " + fullName + ".");
            sb.Append("\nI am on track to becoming a software developer in the near future!");
            sb.Append("\nI initially thought I wouldn't love C# but it has actually really enjoyable so far.");
            sb.Append("\nI think what has done it for me is that I already have a good understanding \nof how to learn the basics of a new programming language.");
            Console.WriteLine(sb);

            Console.ReadLine();
            
        }
    }
}
