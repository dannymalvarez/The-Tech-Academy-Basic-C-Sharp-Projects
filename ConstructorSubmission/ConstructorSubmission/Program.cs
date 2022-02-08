using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Daniel"; //setting a constant string variable as my first name 
            var myLastName = "Alvarez"; //creating a variable using var for my last name 
            var fullName = myName + " " + myLastName; //combining the two constructors 
            Console.WriteLine(fullName); //displaying combined constructors to the console app
            Console.ReadLine();
        }
    }
}
