using System;

namespace BirthYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            int age;
            int years;
            DateTime yearBirth;

            //Ask the user for their age
            Console.WriteLine("Enter your age and the program will calculate your birth year:");

            //Assign the user input to an int variable
            age = Convert.ToInt32(Console.ReadLine());

            //Calculate the birth year by converting age to negative years and using DateTime
            years = age * -1;
            yearBirth = DateTime.Now.AddYears(years);

            //Display the result in a concatenated sentence
            Console.WriteLine("Your birth year is " + yearBirth.ToString("yyyy"));

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
