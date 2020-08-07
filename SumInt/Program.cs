using System;

namespace SumInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            int number;
            int sum;

            //Ask the user for the number
            Console.WriteLine("Enter a number and the program will sum all the digits:");

            //Assign the user input to an int variable
            number = Convert.ToInt32(Console.ReadLine());

            //Calculate the sum of the digits
            //Source: https://stackoverflow.com/questions/478968/sum-of-digits-in-c-sharp
            sum = 0;
            //Create a while loop as long as the number is not 0
            while (number != 0) {
                //Divide the number by 10 and add the remainder to the result variable
                sum += number % 10;
                //Assign the new number to be equal to the last number in the loop divided by 10
                number /= 10;
            }

            //Display the result
            Console.WriteLine(sum);

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
