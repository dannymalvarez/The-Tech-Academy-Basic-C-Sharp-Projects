using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class MyMath //creating a class
    {
        public static int MyAddition(int userInputWhole) //creating a method to add
        {
            return userInputWhole + 15; //user input with 15 added to it
        }
        public static double MyDecimalDivision(double userInputDec) //creating a method to divide a decimal
        {
            return userInputDec / 3; //user input divided by 3
        }
        public static int MyDecimalDivision(int userInput) //creating a method to multiply but it has the same name as the previous method
        {
            return userInput * 3; //userinput times 3
        }
    }
}
