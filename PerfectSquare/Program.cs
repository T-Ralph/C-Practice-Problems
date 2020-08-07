using System;

namespace PerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            double number;
            decimal squareRoot;
            string result;

            //Ask the user for the number
            Console.WriteLine("Enter a number and the program will check if it is perfect square of a whole number or not:");

            //Assign the user input to an int variable
            number = Convert.ToDouble(Console.ReadLine());

            //Check if the number's square root is a perfect square
            //Find the square root of the number
            squareRoot = Convert.ToDecimal(Math.Sqrt(number));
            //Check if it is divisible by 1
            if (squareRoot % 1 == 0) {
                result = "Perfect Square";
            }
            else {
                result = "Not a Perfect Square";
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
