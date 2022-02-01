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
            int addResult = MyMath.MyAddition(userInput); //instatiating method with user input and storing result in variable
            Console.WriteLine(addResult); //displaying result
            int subtractResult = MyMath.MySubtraction(userInput); //instatiating method with user input and storing result in variable
            Console.WriteLine(subtractResult);//displaying result
            int multiplyResult = MyMath.MyMultiplication(userInput); //instatiating method with user input and storing result in variable
            Console.WriteLine(multiplyResult);//displaying result
            Console.ReadLine();
        }
    }
}
