using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Employee<T> //setting employee class to take a generic type parameter
    {
        public List<T> Things { get; set; } //adding a property with data type to be a generic list matching type of class
    }
}
