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
                //number = Convert.ToInt32(Console.ReadLine());

                //Add exception handling to check if input is int
                try {
                    if (!int.TryParse(Console.ReadLine(), out number)) {
                        throw new Exception();
                    }
                }
                catch {
                    Console.WriteLine("Expected a number.");
                    number = 11;
                }

                //Add exception handling to check if number is less than 10
                try {
                    if (number > 10) {
                        throw new Exception();
                    }
                }
                catch {
                    Console.WriteLine("Expected a value between 1 and 10.");
                }

            }

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
