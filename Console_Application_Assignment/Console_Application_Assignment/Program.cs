using System;


namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?"); //Asking for user input
            string userNum = Console.ReadLine(); //Storing user input as a string
            int userInput = Convert.ToInt32(userNum); //Converting the user input from a string to an int
            int display = userInput * 50; //storing user input after multiplying it by 50
            Console.WriteLine("Your favorite number times 50 is: " + display);

            Console.WriteLine("Give us a second number.");//Asking for user input
            string userNum2 = Console.ReadLine();//Storing user input as a string
            int userInput2 = Convert.ToInt32(userNum2); //Converting the user input from a string to an int
            int display2 = userInput2 + 25; //storing user input with the addition of 25
            Console.WriteLine("Your second number plus 25 is: " + display2);

            Console.WriteLine("Give us a third number.");//Asking for user input
            string userNum3 = Console.ReadLine();//Storing user input as a string
            int userInput3 = Convert.ToInt32(userNum3); //Converting the user input from a string to an int
            float display3 = (float)userInput3 / 3; // storing user input divided by 3
            Console.WriteLine("Your third number divided by 3 is: " + display3);

            Console.WriteLine("Give us a fourth number.");//Asking for user input
            string userNum4 = Console.ReadLine();//Storing user input as a string
            int userInput4 = Convert.ToInt32(userNum4); //Converting the user input from a string to an int
            bool greatherThan = userInput4 > 50; //storing result of user input boolean if greater than 50
            Console.WriteLine("Is your fourth number greater than 50? " + greatherThan);

            Console.WriteLine("Give us a fifth number.");//Asking for user input
            string userNum5 = Console.ReadLine();//Storing user input as a string
            int userInput5 = Convert.ToInt32(userNum5); //Converting the user input from a string to an int
            int remainder = userInput5 % 7; //storing result of user input modulus 7
            Console.WriteLine("The remainder for your number if divded by 7 is: " + remainder); //This prints the modulus of either 0 or 1. although it is also printing 2 for certain inputs like 51. Unsure why at the moment. 
            Console.Read();


        }
    }
}
