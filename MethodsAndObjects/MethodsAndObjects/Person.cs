using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person //creating class person 
    {
        public string FirstName { get; set; } //creating first name property
        public string LastName { get; set; } //creating last name property
        public void SayName() //creating void method with no parameters that writes out the first and last names 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
