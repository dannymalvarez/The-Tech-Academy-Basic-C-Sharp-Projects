using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee : Person //creating employee class and inheriting from person class 
    {
        public override void SayName() //implemting say name method 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // printing out a full name.
        }
    }
}
