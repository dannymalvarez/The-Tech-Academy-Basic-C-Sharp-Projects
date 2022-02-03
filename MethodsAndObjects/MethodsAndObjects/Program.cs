using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiating employee object
            employee.FirstName = "Sample"; //initializing object with first name of "Sample"
            employee.LastName = "Student"; //initializing object with last name of "Student"
            employee.SayName(); //calling super class method SayName() on employee object
            Console.ReadLine();
        }
    }
}
