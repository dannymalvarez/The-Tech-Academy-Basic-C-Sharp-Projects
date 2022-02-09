using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try block for this block of code 
            {
                Console.WriteLine("Please enter your age."); //instructions
                int age = Convert.ToInt32(Console.ReadLine()); //storing user input after converting to int
                if (age <= 0) //checks if age is less than or equal to 0, aka invalid input 
                {
                    throw new InvalidInput(); //throw invalid input exception 
                }
               
                int currentYear = 2022; //storing current year as int 
                int yearBorn = currentYear - age; //storing approximate year born for user based on input subtracted from current yer
                Console.WriteLine("You were born in " + yearBorn); //displaying a simple sentence with their year born 
                Console.ReadLine();
            }
            catch (InvalidInput) //catch for invalid input error 
            {
                Console.WriteLine("Please do not enter 0 or negative numbers.");
                Console.ReadLine();
                return;
            }
            catch (Exception) //catch for any other errors/exceptions 
            {
                Console.WriteLine("An error occurred, please contact your System Administrator.");
                Console.ReadLine();
                return;
            }
        }
    }
}
