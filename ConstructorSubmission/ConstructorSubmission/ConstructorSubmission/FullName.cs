using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class FullName
    {
        public string myFirstName;
        public string myLastName;
        
       
        public FullName()
        {

        }
        public FullName(string myFirstName)
        {

        }
        public FullName(string myFirstName, string myLastName)
        {
            this.myFirstName = myFirstName;
            this.myLastName = myLastName;
        }
    }
}
