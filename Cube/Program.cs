using System;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            int number;
            int result;

            //Ask the user for the number
            Console.WriteLine("Enter a number and the program will calculate the cube of the number:");

            //Assign the user input to an int variable
            number = Convert.ToInt32(Console.ReadLine());

            //Calculate the cube using the Math library
            result = Convert.ToInt32(Math.Pow(number, 3));

            //Display the result in a concatenated sentence
            Console.WriteLine("The cube of " + number.ToString() + " is " + result.ToString());

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
