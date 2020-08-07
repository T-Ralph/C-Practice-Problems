using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            int number;
            string result;

            //Ask the user for the number
            Console.WriteLine("Enter a number and the program will check if it is odd or even:");

            //Assign the user input to an int variable
            number = Convert.ToInt32(Console.ReadLine());

            //Check if it is divisible by 2
            if (number % 2 == 0) {
                result = "Even";
            }
            else {
                result = "Odd";
            }

            //Display the result
            Console.WriteLine(result);

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
