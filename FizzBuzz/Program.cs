using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            int i;
            string displayedValue;

            //for loop
            for (i = 0; i <= 100; i++) {

                //set displayedValue
                displayedValue = Convert.ToString(i);

                //conditions for i
                if (i % 3 == 0) {
                    displayedValue = "Fizz";
                }
                if (i % 5 == 0) {
                    displayedValue = "Buzz";
                }
                if (i % 15 == 0) {
                    displayedValue = "FizzBuzz";
                }

                //print displayedValue
                Console.WriteLine(displayedValue);

            }

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
