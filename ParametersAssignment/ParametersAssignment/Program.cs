using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeString = new Employee<string>(); //instantiating employee object with type string
            employeeString.Things = new List<string>() { "Apple", "Car", "House", "Computer" }; //assigning list of strings as property value of things 

            Employee<int> employeeInt = new Employee<int>(); //instantiating employee object with type string
            employeeInt.Things = new List<int>() { 1, 5, 9, }; //assigning list of integers as property value of things 

            foreach (string thing in employeeString.Things) //loop that loops through list of strings and displays them 
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employeeInt.Things) //loop that loops through list of integers and displays them 
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
