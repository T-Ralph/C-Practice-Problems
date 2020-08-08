using System;

namespace LoopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            int number = 11;

            //while loop
            while (number >= 10) {

                //Ask the user for a number
                Console.WriteLine("Enter a number. As long as the number is not 1 - 10, I will continue to ask you for a number.");

                //Assign the user input to an int variable
                number = Convert.ToInt32(Console.ReadLine());

            }

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
