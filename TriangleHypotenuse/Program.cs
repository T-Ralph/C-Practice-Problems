using System;

namespace TriangleHypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            double height;
            double basee;
            decimal hypotenuse;

            //Ask the user for the triangle's height
            Console.WriteLine("Enter the triangle's height:");

            //Assign the user input to a double variable
            height = Convert.ToDouble(Console.ReadLine());

            //Ask the user for the triangle's base
            Console.WriteLine("Enter the triangle's base:");

            //Assign the user input to a double variable
            basee = Convert.ToDouble(Console.ReadLine());

            //Calculate the hypotenuse using the formula h = sqrt(h2 + b2)
            hypotenuse = Convert.ToDecimal(Math.Sqrt(Math.Pow(height, 2) + Math.Pow(basee, 2)));

            //Round up the result to maximum of 2 decimal places
            hypotenuse = Math.Ceiling(hypotenuse * 100) / 100;

            //Display the result in a concatenated sentence
            Console.WriteLine("The triangle's hypotenuse is " + hypotenuse.ToString());

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
