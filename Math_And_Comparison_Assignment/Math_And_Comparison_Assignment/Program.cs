using System;


namespace Math_And_Comparison_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person1");
            Console.WriteLine("Person 1: What is your hourly rate?");
            string P1R = Console.ReadLine();
            int P1Rate = Convert.ToInt32(P1R);
            Console.WriteLine("Person 1: How many hours do you work per week?");
            string P1H = Console.ReadLine();
            int P1Hours = Convert.ToInt32(P1H);
            int Weekly = P1Rate * P1Hours;
            int Salary = Weekly * 52;

            Console.WriteLine("Person2");
            Console.WriteLine("Person 2: What is your hourly rate?");
            string P2R = Console.ReadLine();
            int P2Rate = Convert.ToInt32(P2R);
            Console.WriteLine("Person 2: How many hours do you work per week?");
            string P2H = Console.ReadLine();
            int P2Hours = Convert.ToInt32(P2H);
            int Weekly2 = P2Rate * P2Hours;
            int Salary2 = Weekly2 * 52;

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(Salary);

            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(Salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool Person1More = Salary > Salary2;
            Console.WriteLine(Person1More);


            Console.ReadLine();

        }
    }
}
