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
            const string firstName = "Stephanie"; //setting a constant string variable as my first name 
            var lastName = "Hong"; //setting a constant string variable as my last  name 
            string completeName = fullName.FName + " " + fullName.LName; //creating a variable for displaying fullname with nothing passed in 
            fullName.FName = firstName; //passing in first name variable
            fullName.LName = lastName; //passing in last name variable
            Console.WriteLine(fullName.FName + " " + fullName.LName); //displaying what FName and LName haev been set to/have had passed in
            Console.WriteLine(completeName); //displaying completename variable which has notyhing passed in. 
            Console.ReadLine();
        }
    }
}
