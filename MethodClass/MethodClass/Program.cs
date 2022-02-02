using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath This = new MyMath(); //instantiating class
            Console.WriteLine("Please enter 2 numbers."); //instructions
            int input1 = Convert.ToInt32(Console.ReadLine()); //storing user input as int
            int input2 = Convert.ToInt32(Console.ReadLine());//storing user input as int
            This.MyAddition(input1, input2);//Calling method and passing in two parameters
            Console.ReadLine();
        }
    }
}
