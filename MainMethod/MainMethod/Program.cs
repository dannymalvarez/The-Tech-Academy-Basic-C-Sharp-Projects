using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath This = new MyMath();
            Console.WriteLine("Please enter a whole number."); //instructions
            int userInputWhole = Convert.ToInt32(Console.ReadLine()); //converting user input to int and storing it
            int addResult = This.MyAddition(userInputWhole); //calling method and passing in parameter and saving it to a variable
            Console.WriteLine(addResult); //displaying result


            Console.WriteLine("Please enter a decimal number."); //instructions
            decimal userInputDec = Convert.ToDecimal(Console.ReadLine()); //converting user input to decimal and storing it
            int divideDecimal = This.MyAddition(userInputDec); //calling method and passing in parameter and saving it to a variable
            Console.WriteLine(divideDecimal); //displaying result


            Console.WriteLine("Please enter a whole number."); //instructions
            string userInput = Console.ReadLine(); //Storing user input as a string
            int multiplyResult = This.MyDecimalDivision(userInput);  //calling method and passing in parameter and saving it to a variable
            Console.WriteLine(multiplyResult); //displaying result
            Console.ReadLine();
        }
    }
}
