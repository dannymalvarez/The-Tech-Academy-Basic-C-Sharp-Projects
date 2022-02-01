using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number."); //instructions
            int userInput = Convert.ToInt32(Console.ReadLine()); //storing user input as an int
            Math mathOne = new Math(); //creating math object by assigning it to variable mathOne
            mathOne.Addition = userInput + 5; // assigning the addition of userinput by 5 to the property addition of the mathOne object
            Math mathTwo = new Math(); //creating math object by assigning it to variable mathTwo
            mathTwo.Subtraction = (userInput - 5); // assigning the subtraction of userinput by 5 to the property subtraction of the mathTwo object
            Math mathThree = new Math(); //creating math object by assigning it to variable mathThree
            mathThree.Multiplication = userInput * 5; // assigning the multiplication of userinput by 5 to the property multiplication of the mathThree object

            Console.WriteLine("Your input of " + userInput + " plus 5 equals " + mathOne.Addition + "."); //displaying output with some additional info
            Console.WriteLine("Your input of " + userInput + " minus 5 equals " + mathTwo.Subtraction + "."); //displaying output with some additional info
            Console.WriteLine("Your input of " + userInput + " multiplied by 5 equals " + mathThree.Multiplication + "."); //displaying output with some additional info
            Console.ReadLine();
           
        }
    }
}
