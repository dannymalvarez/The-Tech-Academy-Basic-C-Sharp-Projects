using System;


namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below."); //This message will be displayed to the user
            Console.WriteLine("Please enter the package weight:"); //This message asks the user for input on package weight 
            int pkgWeight = Convert.ToInt32(Console.ReadLine()); //converting user input to a int from a string and storing that value
            if (pkgWeight > 50) //if statement for if weight is less than 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); //if weight is greater than 50 this is displayed and program ends 
                Console.ReadLine();
            }
            else if (pkgWeight <= 50) //if weight is less than 50 this will execute
            {
                Console.WriteLine("Please enter the package width:"); //asking user for width
                int pkgWidth = Convert.ToInt32(Console.ReadLine());//converting user input to a int from a string and storing that value
                Console.WriteLine("Please enter the package height:");//asking user for height
                int pkgHeight = Convert.ToInt32(Console.ReadLine());//converting user input to a int from a string and storing that value
                Console.WriteLine("Please enter the package length:");//asking user for length
                int pkgLength = Convert.ToInt32(Console.ReadLine());//converting user input to a int from a string and storing that value
                int total = pkgWidth + pkgHeight + pkgLength; // storing total value of dimensions
                if (total > 50) // if total dimensions are greater than 50 this will execute
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day."); //displaying this message if dimensions are greater than 50
                    Console.ReadLine();
                }
                else if (total <= 50) // if total is less than or equal to 50 execute this if statement
                {
                    decimal pricing = ((decimal)pkgWidth * (decimal)pkgHeight * (decimal)pkgLength * (decimal)pkgWeight) / (decimal)100; // storing pricing formula as a decimal
                    Console.WriteLine("Your estimated total for shipping this package is: $" + pricing); //displaying estimated total 
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }          
        }
    }
}
