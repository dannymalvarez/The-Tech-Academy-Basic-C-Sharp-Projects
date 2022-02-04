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
            Employee employee1 = new Employee(); //instantiating employee object
            employee1.FirstName = "Stephanie"; //initializing object with first name of "Stephanie"
            employee1.LastName = "Alvarez"; //initializing object with last name of "Alvarez"
            employee1.Id = 1; //initializing object with id number of 1
            //employee1.SayName(); //calling say name method on employee object


            //IQuittable quit = new Employee(); //creating an object of type IQuittable 
            //quit.Quit(); //calling the Quit() method on new object

            Employee employee2 = new Employee(); //instantaiting new employee object
            employee2.FirstName = "Daniel"; //initializing object with first name of "Daniel"
            employee2.LastName = "Alvarez"; //initializing object with last name of "Alvarez"
            employee2.Id = 2; //initializing object with id number of 2
            if (employee1 == employee2) //if employee 1 matches employee 2 print this message below
            {
                Console.WriteLine("These two people have the same Id.");
            }
            else //if employee 1 does not match employee 2 print this message below
            {
                Console.WriteLine("These two people have different Ids.");
            }

            if (employee1 != employee2) //if employee 1 does not match employee 2 print this message below
            {
                Console.WriteLine("These two people have different Ids");
            }
            else //if employee 1 matches employee 2 print this message below
            {
                Console.WriteLine("These two people have the same Id.");
            }
            Console.ReadLine();
        }
    }
}
