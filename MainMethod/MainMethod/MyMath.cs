using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class MyMath //creating a class
    {
        public int MyAddition(int userInputWhole) //creating a method to add
        {
            return userInputWhole + 15; //user input with 15 added to it
        }
        public int MyAddition(decimal userInputDec) //creating a method to divide a decimal
        {
            int finalInt = Convert.ToInt32(userInputDec/3); //converting decimal input to int after dividing by 3
            return finalInt; //user input divided by 3
        }
        public int MyDecimalDivision(string userInput) //creating a method to multiply but it has the same name as the previous method
            // this method also takes in a string and returns an int
        {
            int stringToInt = Convert.ToInt32(userInput); //converting user input to int
            int mult = stringToInt * 4; //user input times 4
            return (mult); //displaying final result
        }
    }
}
