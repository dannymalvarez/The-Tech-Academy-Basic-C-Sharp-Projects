using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How many numbers would you like to enter? One or Two?"); //instructions
            //string amount = Console.ReadLine(); //storing user input as a string

            //if (amount == "Two" || amount == "two" || amount == "2") // a way to handle multiple inputs of 2
            //{
            //    Console.WriteLine("Please enter your first number."); //instructions
            //    int input1 = Convert.ToInt32(Console.ReadLine()); // converting user input from a string to an int
            //    Console.WriteLine("Please enter your second number."); //instructions
            //    int input2 = Convert.ToInt32(Console.ReadLine()); // converting user input from a string to an int
            //    int addResult = MyMath.MyAddition(input1, input2); //instantiating method and providing the inputs  
            //    Console.WriteLine(addResult); //displaying results 
            //}
            //if (amount == "One" || amount == "one" || amount == "1") // a way to handle multiple inputs of 1
            //{
            //    Console.WriteLine("Please enter your number."); //instructions
            //    int input1 = Convert.ToInt32(Console.ReadLine()); // converting user input from a string to an int
            //    int input2 = 5; //variable name is a bit misleading but for inputs to be the same and for the same method to be used, I kept the variable name 
            //    int addResult = MyMath.MyAddition(input1, input2);//instatiating method and providing the inputs 
            //    Console.WriteLine(addResult); //displaying results
            //}


            Console.WriteLine("You may enter up to 2 numbers."); //instructions
            int input1 = Convert.ToInt32(Console.ReadLine()); // converting user input to an int
            string input2 = Console.ReadLine(); // storing user input as a string 
  
            if (input2 != "") //if string is not empty
            {
                MyMath.MyAddition(input1, Convert.ToInt32(input2)); //instantiating method 
                //converting input2 to int and pass input1 and input2 into method
            }
           
            if (input2 == "") // if string is empty
            {
                MyMath.MyAddition(input1); //instantiating method and passing in only one parameter.
            } 
            Console.ReadLine();
        }
    }
}
