using System;


namespace Daily_Report_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            string intro = "The Tech Academy."; // These variables will be automatically displayed
            string intro2 = "Student Daily Report."; 
            Console.WriteLine(intro); // this displays the variables
            Console.WriteLine(intro2);
            Console.WriteLine("What is your name?"); //This asks for users name
            string yourName = Console.ReadLine(); // This saves user input
            Console.WriteLine("What course are you on?"); //This asks for user course
            string course = Console.ReadLine(); // This saves user input
            Console.WriteLine("What page number?"); // asking for user page number
            string pageNumber = Console.ReadLine(); // This saves user input
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\""); // asking if user needs help with anything
            string help = Console.ReadLine(); // This saves user input
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); // asking if user would like to share any positive experiences
            string positiveExp = Console.ReadLine(); // This saves user input
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); //asking user if there is any other feedback they would like to share
            string feedback = Console.ReadLine(); // This saves user input
            Console.WriteLine("How many hours did you study today?"); //asking how many hours user studied that day
            string hours = Console.ReadLine(); // This saves user input
            Console.WriteLine("Thank you for your answers. An instructor will responsd to this shortly. Have a great day!"); //displaying this sentence when program ends. 
            Console.Read(); // This makes the program keep running even when finished until user exists


        }
    }
}
