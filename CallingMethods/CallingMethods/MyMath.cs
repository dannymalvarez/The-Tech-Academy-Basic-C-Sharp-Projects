using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class MyMath //created class
    {
        public static int MyAddition(int userInput)
        {
            return userInput + 5; // assigning result of user input plus 5 to output for display
        }
        public static int MySubtraction(int userInput)
        {
            return userInput - 5; // assigning result of user input minus 5 to output for display
        }
        public static int MyMultiplication(int userInput)
        {
            return userInput * 5; // assigning result of user input times 5 to output for display
        }

    }
}
