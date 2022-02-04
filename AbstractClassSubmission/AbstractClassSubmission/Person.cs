using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public abstract class Person //creating abstract class
    {
        public string FirstName { get; set; } //creating first name property
        public string LastName { get; set; } //creating last name property
        public abstract void SayName(); //say name method 
    }
}
 