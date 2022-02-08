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

            const string myFirstName = "Daniel"; //setting a constant string variable as my first name 
            const string myLastName = "Alvarez"; //creating a variable using var for my last name
            var fullName = new FullName(myFirstName, myLastName);
            Console.WriteLine(fullName.myFirstName);
            Console.WriteLine(fullName.myLastName);
             
            Console.ReadLine();
            
            
            
            
        }
    }
}
