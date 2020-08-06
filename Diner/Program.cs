using System;

namespace Diner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            double totalBill;
            int numberDiner;
            decimal result;

            //Ask the user for the total bill
            Console.WriteLine("Enter the total bill: $");

            //Assign the user input to a double variable
            totalBill = Convert.ToDouble(Console.ReadLine());

            //Ask the user for the number of diners
            Console.WriteLine("Enter the number of diners:");

            //Assign the user input to an int variable
            numberDiner = Convert.ToInt32(Console.ReadLine());

            //Calculate the bill for each diner by splitting the total bill equally
            result = Convert.ToDecimal(totalBill / numberDiner);

            //Round up the result to maximum of 2 decimal places
            result = Math.Ceiling(result * 100) / 100;

            //Display the result in a concatenated sentence
            Console.WriteLine("Each diner will pay $" + result.ToString());

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
