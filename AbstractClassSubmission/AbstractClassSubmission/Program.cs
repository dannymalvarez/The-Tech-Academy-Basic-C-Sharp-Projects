using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiating employee object
            employee.FirstName = "Sample"; //initializing object with first name of "Sample"
            employee.LastName = "Student"; //initializing object with last name of "Student"
            employee.SayName(); //calling say name method on employee object
            IQuittable quit = new Employee(); //creating an object of type IQuittable 
            quit.Quit(); //calling the Quit() method on new object
            Console.ReadLine();
        }
    }
}
