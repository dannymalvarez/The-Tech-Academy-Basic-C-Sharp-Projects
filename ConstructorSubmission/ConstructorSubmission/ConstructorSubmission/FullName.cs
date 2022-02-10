using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class FullName
    {
       
        public FullName() : this("Daniel", "Alvarez") //chaining constructors
        {

        }
       
        public FullName(string firstName, string lastName)
        {
            FName = firstName;
            LName = lastName;
        }
        public string FName { get; set; }
        public string LName { get; set; }
    }
}
