using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number(); //creating an object of data type number
            num1.Amount = 15.05M; //assigning amount to object num1
            Console.WriteLine(num1.Amount); //displaying amount 
            Console.ReadLine();
        }
    }
}
