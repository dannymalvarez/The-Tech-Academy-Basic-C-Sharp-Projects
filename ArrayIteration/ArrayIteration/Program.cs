using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] greetings = { "What's up? ", "Howdy! ", "Hi! ", "Hey! ", "Hello! "}; //greetings to add user input after
            Console.WriteLine("What is your name? We will add it to the end of some greetings!"); //instructions and context
            string userName = Console.ReadLine(); //storing user input as a string
            for (int i = 0; i < greetings.Length; i++) //for loop that loops through greetings array
            {
                greetings[i] = greetings[i] + "My name is " + userName + "."; //concatenating array elements with user input 
            }
            for (int j = 0; j < greetings.Length; j++) //another loop that displays every new array element
            {
                Console.WriteLine(greetings[j]);
            }
            Console.ReadLine();

            int counter = 0;
            for (int a = 0; a < 11; a++) //This is the infinite loop after it has been fixed
            //before it was "for (int a = 1; a > 0; a++)"
            {
                Console.WriteLine(counter);
                counter++;

            }
            Console.ReadLine();


            for (int a = 0; a < 2; a++) //small loop 
            {
                Console.WriteLine("This loops twice.");
            }
            Console.ReadLine();

            for (int a = 0; a <= 4; a++) //loop with 5 iterations 
            {
                Console.WriteLine("This loop goes up to 5 iterations");
            }
            Console.ReadLine();

            List<string> fruits = new List<string>() { "Apple", "Banana", "Pineapple"}; // list of fruits
            Console.WriteLine("Guess a fruit."); //instructions 
            string choice = Console.ReadLine(); //saving user input as a string 
            bool optionExists = false; //this bool is for the error if statement should an input not exist in the list
            for (int a = 0; a < fruits.Count; a++) //for loop that loops through fruits list 
            {
                if (choice == fruits[a]) //checking if user input matches fruits at a certain index determined by the for loop
                {
                    Console.WriteLine(a);
                    optionExists = true; //setting bool for error if statement to true since in order to make it this far it must be true that a correct input was typed in
                }
            }
            if (optionExists == false) //if the input does not exist in the list this will display
            {
                Console.WriteLine("That fruit is not on the list, try again.");
            }
            Console.ReadLine();


            List<string> cars = new List<string>() { "Ford", "Ford", "Nissan", "Toyota" }; // list of car brands
            Console.WriteLine("Guess a car brand."); //instructions 
            string userInput = Console.ReadLine(); //storing user input as a string
            bool exists = false; //this bool is for the error if statement should an input not exist in the list
            for (int a = 0; a < cars.Count; a++) //for loop that loops through list of cars
            {
                if (userInput == cars[a]) //checks if user input matches an element in the list 
                {
                    Console.WriteLine(a);
                    exists = true; //setting bool for error if statement to true since in order to make it this far it must be true that a correct input was typed in
                }

            }
            if (exists == false) //if the input does not exist in the list this will display
            {
                Console.WriteLine("That option is not on the list."); 
            }
            Console.ReadLine();


            List<string> stateList = new List<string>() { "Tennessee", "California", "Oregon", "Oregon" }; //list of states
            foreach (string state in stateList) //loops through list of states
            {
                Console.WriteLine(state);
                for (int i = 0; i < stateList.Count; i++)
                {
                    if (state == stateList[i] && stateList.IndexOf(state) != i)
                    {
                        Console.WriteLine(state + " has already appeared in the list."); //displays a message including the state that has multiple instances
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
