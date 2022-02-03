using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSub
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath instance = new MyMath(); //instantiating method 
            Console.WriteLine("Please enter a number."); //instructions
            int input1 = Convert.ToInt32(Console.ReadLine()); //converting user input to an int and storing it
            Console.WriteLine("Please enter a second number.");//instructions
            int input3 = Convert.ToInt32(Console.ReadLine()); //converting user input to an int and storing it
            Console.WriteLine("Please enter a third number.");//instructions
            int input2 = Convert.ToInt32(Console.ReadLine());//converting user input to an int and storing it
            instance.MyDivision(input1); //calling method and passign in input1
            instance.MyAddition(input2, out int output2); //calling method and passing in input2 and output2
            instance.MyDivision(input1, input3); //calling method and passing in input1 and input3

            Console.WriteLine("Please enter a fourth number."); //instructions
            int input4 = Convert.ToInt32(Console.ReadLine()); //converting user input to an int and storing it
            int result = MyStatMath.Mymult(input4); //calling method, passing input4 to method, and storing result
            Console.WriteLine(result); //displaying result 
            Console.ReadLine();
        }
    }
}
