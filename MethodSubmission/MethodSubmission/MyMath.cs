using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    public class MyMath //created class
    {
        public static void MyAddition(int input1, int input2=15) // creating method with 2 parameters, one of which is optional
        {
            int finalOutput = input1 + input2; //storing output/sum of inputs 1 and 2 into variable
            Console.WriteLine(finalOutput); //printing out variable containing final output
        }

    }   
    
}
