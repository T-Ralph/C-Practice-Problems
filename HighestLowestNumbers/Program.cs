using System;

namespace HighestLowestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            int number1;
            int number2;
            int number3;
            int highestNumber;
            int lowestNumber;

            //Ask the user for the first number
            Console.WriteLine("Enter the first number:");

            //Assign the user input to an int variable
            number1 = Convert.ToInt32(Console.ReadLine());

            //Ask the user for the second number
            Console.WriteLine("Enter the second number:");

            //Assign the user input to an int variable
            number2 = Convert.ToInt32(Console.ReadLine());

            //Ask the user for the third number
            Console.WriteLine("Enter the third number:");

            //Assign the user input to an int variable
            number3 = Convert.ToInt32(Console.ReadLine());

            //Calculate the cube using the Math library
            //Using Math.Max and Math.Min, you can get the highest and lowest numbers between two numbers
            //Combining the comparison this way will compare between three numbers
            //Source: https://stackoverflow.com/a/4390801/6842789
            highestNumber = Math.Max(number1, Math.Max(number2, number3));
            lowestNumber = Math.Min(number1, Math.Min(number2, number3));

            //Display the result in a concatenated sentence
            Console.WriteLine("The highest number is " + highestNumber.ToString());
            Console.WriteLine("The lowest number is " + lowestNumber.ToString());

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
