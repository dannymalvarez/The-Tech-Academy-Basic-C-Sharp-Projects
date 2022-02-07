using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
         
            List<Employee> employees = new List<Employee>(); //creating a list that can store strings and int for employee data 
            

            Employee employee1 = new Employee(); //creating new instance of employee object
            employee1.FirstName = "Joe"; 
            employee1.LastName = "Smith";
            employee1.Id = 1;
            employees.Add(employee1); //adding employee data that was input above

            Employee employee2 = new Employee(); //creating new instance of employee object
            employee2.FirstName = "Joe";
            employee2.LastName = "Johnson";
            employee2.Id = 2;
            employees.Add(employee2); //adding employee data that was input above

            Employee employee3 = new Employee(); //creating new instance of employee object
            employee3.FirstName = "Jonathan";
            employee3.LastName = "Sandoval";
            employee3.Id = 3;
            employees.Add(employee3); //adding employee data that was input above

            Employee employee4 = new Employee();//creating new instance of employee object
            employee4.FirstName = "James";
            employee4.LastName = "Alvarez";
            employee4.Id = 4;
            employees.Add(employee4); //adding employee data that was input above

            Employee employee5 = new Employee(); //creating new instance of employee object
            employee5.FirstName = "Cindy";
            employee5.LastName = "Clawford";
            employee5.Id = 5;
            employees.Add(employee5); //adding employee data that was input above

            Employee employee6 = new Employee(); //creating new instance of employee object
            employee6.FirstName = "Helen";
            employee6.LastName = "Shand";
            employee6.Id = 6; 
            employees.Add(employee6); //adding employee data that was input above

            Employee employee7 = new Employee(); //creating new instance of employee object
            employee7.FirstName = "Derek";
            employee7.LastName = "King";
            employee7.Id = 7;
            employees.Add(employee7); //adding employee data that was input above

            Employee employee8 = new Employee(); //creating new instance of employee object
            employee8.FirstName = "Larry";
            employee8.LastName = "Othman";
            employee8.Id = 8;
            employees.Add(employee8); //adding employee data that was input above

            Employee employee9 = new Employee(); //creating new instance of employee object
            employee9.FirstName = "Michael";
            employee9.LastName = "Covington";
            employee9.Id = 9;
            employees.Add(employee9); //adding employee data that was input above

            Employee employee10 = new Employee(); //creating new instance of employee object
            employee10.FirstName = "Miranda";
            employee10.LastName = "Cosbro";
            employee10.Id = 10;
            employees.Add(employee10); //adding employee data that was input above


            List<Employee> JoeEmp = new List<Employee>(); //creating new list for employees named joe
            foreach (var firstName in employees) //loops through employee list to find first names
            {
                if (firstName.FirstName == "Joe") //checking if first name matches joe
                {
                    JoeEmp.Add(firstName); //if it matches, add it to the new list for employees named joe 
                }
                
            }
            
            foreach (var joe in JoeEmp) //loops through list of joes
            {
                Console.WriteLine(joe.FirstName); //displays the first names of those in the joe list
            }
            var joes = JoeEmp.Where(x => x.FirstName == "Joe").ToList(); //creating a list for employees named joe using a lambda expression 
            
            foreach (var person in joes) //loops through the list of joes 
            {
                Console.WriteLine(person.FirstName); //displays those individuals' first names to console.
            }

            var people = employees.Where(x => x.Id > 5).ToList(); //creating a list using lambda expression where Id is greater than 5
            foreach (var individual in people) //loops through list of people with id greater than 5
            {
                Console.WriteLine(individual.FirstName); //displaying the first name of those with an id greather than 5
            }

            Console.ReadLine();
        }
    }
}
