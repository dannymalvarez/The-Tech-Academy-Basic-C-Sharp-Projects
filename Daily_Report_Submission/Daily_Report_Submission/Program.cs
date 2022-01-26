using System;


namespace Daily_Report_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            string intro = "The Tech Academy.";
            string intro2 = "Student Daily Report.";
            Console.WriteLine(intro);
            Console.WriteLine(intro2);
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string help = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An instructor will responsd to this shortly. Have a great day!");
            Console.Read();


        }
    }
}
