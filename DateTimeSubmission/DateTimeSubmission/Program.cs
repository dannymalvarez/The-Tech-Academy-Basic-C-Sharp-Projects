using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime TimeNow = DateTime.Now; //storing current time to TimeNow variable
            Console.WriteLine(TimeNow); //displaying current time to the console
            Console.WriteLine("Please enter a number between 1 and 24"); //instructions to user 
            int userInput = Convert.ToInt32(Console.ReadLine()); //storing user input as an int
            Console.WriteLine("In " + userInput + " hours it will be " + TimeNow.AddHours(userInput) + "."); //displaying the time it will be in however many hours the user input which were added to current time. 
            Console.ReadLine();
        }
    }
}
