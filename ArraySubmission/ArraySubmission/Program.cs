using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] stringArray = new string[] { "Good morning!", "Good afternoon!", "Good evening!", "Good night!" }; // array of options to display
            Console.WriteLine("Hello, please enter a number between 0 and 3 to display your greeting based on time of day."); // instructions
            int userChoice = Convert.ToInt32(Console.ReadLine()); // saving user input after converting from string to int

            while (userChoice > 3) // while loop in case user input is greater than 3
            {
                if (userChoice > 3)
                {
                    Console.WriteLine("The option you selected does not exist. Please select a number between 0 and 3."); //reiteration of instructions should they not be followed
                    userChoice = Convert.ToInt32(Console.ReadLine()); //saving user input after converting from string to int
                }
            }
            
            Console.WriteLine(stringArray[userChoice]); //displaying user choice from array


            int[] numArray = new int[] { 5, 50, 500, 5000 }; // array of options to display
            Console.WriteLine("Now please enter a number between 0 and 3."); // instructions
            int userSelect = Convert.ToInt32(Console.ReadLine()); //saving user input after converting from string to int
            
            while (userSelect > 3) // while loop in case user input is greater than 3
            {
                if (userSelect > 3)
                {
                    Console.WriteLine("The option you selected does not exist. Please select a number between 0 and 3."); //reiteration of instructions should they not be followed
                    userSelect = Convert.ToInt32(Console.ReadLine()); // saving user input after converting from string to int
                }
            }

            Console.WriteLine(numArray[userSelect]); // displaying user choice from array
            


            List<string> stringList = new List<string>() { "Daniel", "Jeremy", "Kevin", "Sally", "Stephanie" }; // options from list for user to pick from 

            Console.WriteLine("Now please enter a number between 0 and 4 to display a name."); //instructions
            int userOption = Convert.ToInt32(Console.ReadLine()); // saving user input as int after converting from string 

            while (userOption > 4) // while loop in case user input is greater than 4
            {
                if (userOption > 4)
                {
                    Console.WriteLine("The option you selected does not exist. Please select a number between 0 and 4."); // reiteration of instructions should they not be followed
                    userOption = Convert.ToInt32(Console.ReadLine()); // saving user input after converting from string to int
                }
            }
            Console.WriteLine(stringList[userOption]); // displaying user choice from list 
            Console.ReadLine();


        }
    }
}
