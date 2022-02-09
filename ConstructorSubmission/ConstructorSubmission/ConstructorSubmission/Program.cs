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

            FullName fullName = new FullName();
            const string myFirstName = "Daniel"; //setting a constant string variable as my first name 
            var myLastName = "Alvarez"; //setting a constant string variable as my last  name 
            fullName = new FullName(myFirstName, myLastName); //creating a variable using var for passing these constants to the method
            Console.WriteLine(fullName.myFirstName); //displaying first name to console
            Console.WriteLine(fullName.myLastName); //displaying last name to console
             
            Console.ReadLine();
            
            
            
            
        }
    }
}
