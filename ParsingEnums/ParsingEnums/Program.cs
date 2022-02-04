using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter what day of the week it is today."); //instructions 
            string today = Console.ReadLine(); //storing uesr input 
            try //try block 
            {
                DaysOfTheWeek Day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), today); //convertnig the input to enum and storing value in Day
                Console.WriteLine(Day); //displaying Day
            }
            catch //catch block if there is an error 
            {
                Console.WriteLine("Invalid input"); //if there is an error, present this output.
            }
            Console.ReadLine();
        }
        public enum DaysOfTheWeek //creating an enum for days of the week 
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
