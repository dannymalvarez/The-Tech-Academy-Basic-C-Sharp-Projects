using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class InvalidInput : Exception //created a new class for invalid input exception handling
    {
        public InvalidInput()
            : base() { }
        public InvalidInput(string message)
            : base(message) { }
    }
}
