using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_and_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 7 to guess what day it is today.");
            int weekDay = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = weekDay == 4;
            do
            {
                switch (weekDay)
                {
                    case 1:
                        Console.WriteLine("You guessed Monday, try again.");
                        Console.WriteLine("Please enter a number between 1 and 7 to guess what day it is today.");
                        weekDay = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed Tuesday, try again.");
                        Console.WriteLine("Please enter a number between 1 and 7 to guess what day it is today.");
                        weekDay = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed Wednesday, try again.");
                        Console.WriteLine("Please enter a number between 1 and 7 to guess what day it is today.");
                        weekDay = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Today is Thursday. You win!");
                        Console.ReadLine();
                        isGuessed = true;
                        break;
                    case 5:
                        Console.WriteLine("You guessed Friday, try again.");
                        Console.WriteLine("Please enter a number between 1 and 7 to guess what day it is today.");
                        weekDay = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed Saturday, try again.");
                        Console.WriteLine("Please enter a number between 1 and 7 to guess what day it is today.");
                        weekDay = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed Sunday, try again.");
                        Console.WriteLine("Please enter a number between 1 and 7 to guess what day it is today.");
                        weekDay = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);


            Console.WriteLine("Please enter a number between 1 and 10");
            int numberGuess = Convert.ToInt32(Console.ReadLine());
            bool guessed = false;
            
            while (!guessed)
            {
                switch (numberGuess)
                {
                    case 1:
                        Console.WriteLine("You guessed 1, that was not correct. Try again.");
                        Console.WriteLine("Please enter a number between 1 and 10.");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2, that was not correct. Try again.");
                        Console.WriteLine("Please enter a number between 1 and 10.");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3, that was not correct. Try again.");
                        Console.WriteLine("Please enter a number between 1 and 10.");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4, that was not correct. Try again.");
                        Console.WriteLine("Please enter a number between 1 and 10.");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5, that was not correct. Try again.");
                        Console.WriteLine("Please enter a number between 1 and 10.");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6, that was not correct. Try again.");
                        Console.WriteLine("Please enter a number between 1 and 10.");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7, you win!");
                        Console.ReadLine();
                        guessed = true;
                        break;

                }
            }

            
        }
    }
}
