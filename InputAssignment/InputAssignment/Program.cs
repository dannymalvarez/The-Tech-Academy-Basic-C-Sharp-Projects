using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");//instructions 
            string input = Console.ReadLine(); //storing user input as a string 
            File.WriteAllText(@"C:\Users\danny\TTABootCampFiles\Logs\userInput.txt", input); //writing user input to a text file to log it 

            string output = File.ReadAllText(@"C:\Users\danny\TTABootCampFiles\Logs\userInput.txt"); //storing user input from text file to a string variable after reading the file 
            Console.WriteLine(output); //displaying the output variable to console. 
            Console.ReadLine();

        }
    }
}
