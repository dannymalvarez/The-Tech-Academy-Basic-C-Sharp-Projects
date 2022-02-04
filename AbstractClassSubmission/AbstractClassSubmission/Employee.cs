using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee : Person, IQuittable //creating employee class and inheriting from person class and IQuittable interface
    {
        public override void SayName() //implementing say name method 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // printing out a full name.
        }
        public void Quit()
        {
            Console.WriteLine("This is your confirmation that you are quitting."); //displaying this message
            Console.ReadLine();
        }
        public int Id { get; set; } //Id property of data type int
        public static bool operator== (Employee employee1, Employee employee2) //overloading == operator which checks if two employee objects are equal by comparing their Id properties
        {
            return (employee1.Id == employee2.Id); //return a bool if two employee objects match Ids
        }

        public static bool operator!= (Employee employee1, Employee employee2) //overloading != operator which checks if two employee objects are not equal by comparing their Id properties
        {
            return (employee1.Id != employee2.Id); //return a bool if two employee objects do not match Ids
        }
    }
}

