using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSub
{
    class MyMath
    {
        public void MyDivision(int input1)
        {
            int output1 = input1 / 2;
            Console.WriteLine(output1);
        }

        public void MyDivision(int input1, int input2)
        {
            int output3 = input1 / input2;
            Console.WriteLine(output3);
        }

        public void MyAddition(int input2, out int output2)
        {
            output2 = input2 + 15;
        }
    }
}
