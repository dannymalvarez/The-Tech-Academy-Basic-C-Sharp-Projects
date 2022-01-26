using System;


namespace ApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            int age = Convert.ToInt32(ageString);
            Console.WriteLine("Have you ever had a DUI?");
            string DUIString = Console.ReadLine();
            bool DUI = Convert.ToBoolean(DUIString);
            Console.WriteLine("How many speeding tickets do you have?");
            string speeding = Console.ReadLine();
            int tickets = Convert.ToInt32(speeding);

            bool Approved = (age > 15 && DUI == false && tickets < 4);

            Console.WriteLine("Qualified?");
            Console.WriteLine(Approved);
            Console.ReadLine();


            


        }
    }
}
