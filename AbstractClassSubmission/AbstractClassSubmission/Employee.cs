using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee : Person, IQuittable //creating employee class and inheriting from person class and IQuittable interface
    {
        public override void SayName() //implemting say name method 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // printing out a full name.
        }
        public void Quit()
        {
            Console.WriteLine("This is your confirmation that you are quitting."); //displaying this message
            Console.ReadLine();
        }
    }
}
