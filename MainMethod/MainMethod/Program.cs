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
            Console.WriteLine("Please enter a whole number."); //instructions
            int userInputWhole = Convert.ToInt32(Console.ReadLine()); //converting user input to int and storing it
            int addResult = MyMath.MyAddition(userInputWhole); //instantiating methodand saving it to a variable
            Console.WriteLine(addResult); //displaying result
            Console.WriteLine("Please enter a decimal number."); //instructions
            double userInputDec = Convert.ToDouble(Console.ReadLine()); //converting user input to decimal and storing it
            double divideDecimal = MyMath.MyDecimalDivision(userInputDec); //instantiating methodand saving it to a variable
            Console.WriteLine(divideDecimal); //displaying result
            Console.WriteLine("Please enter a whole number."); //instructions
            int userInput = Convert.ToInt32(Console.ReadLine()); //converting user input to int and storing it
            int multiplyResult = MyMath.MyDecimalDivision(userInput);  //instantiating method and saving it to a variable
            Console.WriteLine(multiplyResult); //displaying result
            Console.ReadLine();
        }
    }
}
