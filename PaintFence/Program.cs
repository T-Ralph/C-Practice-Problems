using System;

namespace PaintFence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            double numberFence;
            decimal numberBucket;

            //Ask the user for the number of fence posts
            Console.WriteLine("Enter the number of Fence Posts:");

            //Assign the user input to a double variable
            numberFence = Convert.ToDouble(Console.ReadLine());

            //Calculate the number of buckets of paints using the ratio 1 bucket of paint to 4 fence posts
            numberBucket = Convert.ToDecimal(numberFence / 4);

            //Round up the result to maximum of 2 decimal places
            numberBucket = Math.Ceiling(numberBucket * 100) / 100;

            //Display the result in a concatenated sentence
            Console.WriteLine(numberBucket.ToString() + " bucket(s) of paint is needed to paint " + numberFence.ToString() + " fence posts");

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
