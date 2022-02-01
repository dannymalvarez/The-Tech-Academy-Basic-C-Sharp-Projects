using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> integers = new List<int>() { 50, 10, 25, 20 }; // list of integers
                Console.WriteLine("Please choose a number"); // instructions for user 
                int input1 = Convert.ToInt32(Console.ReadLine()); // converting user input to an integer
                for (int i = 0; i < integers.Count; i++) //for loop that loops through integers list
                {
                    int answer = integers[i] / input1; // division of numbers in list by the user input integer
                    Console.WriteLine(integers[i] + " divided by " + input1 + " is equal to " + answer + "."); // displaying a sentence with the results and context

                }
            }
            catch (DivideByZeroException ex) //error handling of dividing by zero
            {
                Console.WriteLine(ex.Message); //displaying the error that comes up in the system as context to the user 
            }
            catch (FormatException ex) //error handling of using the incorrect format
            {
                Console.WriteLine(ex.Message); //displaying the error that comes up in the system as context to the user 
            }
            Console.WriteLine("You are now outside the try/catch block."); //displaying a message that you are now outside the try/catch block
            Console.ReadLine();
        }
    }
}
