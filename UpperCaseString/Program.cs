using System;

namespace UpperCaseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            string text;
            string result;

            //Ask the user for the text
            Console.WriteLine("Enter your text and the program will convert it to uppercase:");

            //Assign the user input to a string variable
            text = Convert.ToString(Console.ReadLine());

            //Convert string to uppercase
            result = text.ToUpper();

            //Display the result
            Console.WriteLine(result);

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
