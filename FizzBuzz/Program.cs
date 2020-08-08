using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            int number1;
            string word1;
            int number2;
            string word2;
            int number3;
            string word3;
            int startCount;
            int endCount;
            int i;
            string displayedValue;

            //Ask the user for the first number
            Console.WriteLine("Enter the first number:");

            //Assign the user input to an int variable
            number1 = Convert.ToInt32(Console.ReadLine());

            //Ask the user for the first word
            Console.WriteLine("Enter the first word:");

            //Assign the user input to a string variable
            word1 = Convert.ToString(Console.ReadLine());

            //Ask the user for the second number
            Console.WriteLine("Enter the second number:");

            //Assign the user input to an int variable
            number2 = Convert.ToInt32(Console.ReadLine());

            //Ask the user for the second word
            Console.WriteLine("Enter the second word:");

            //Assign the user input to a string variable
            word2 = Convert.ToString(Console.ReadLine());

            //Ask the user for the third number
            Console.WriteLine("Enter the third number:");

            //Assign the user input to an int variable
            number3 = Convert.ToInt32(Console.ReadLine());

            //Ask the user for the third word
            Console.WriteLine("Enter the third word:");

            //Assign the user input to a string variable
            word3 = Convert.ToString(Console.ReadLine());

            //Ask the user for the starting point
            Console.WriteLine("Enter the Starting Point:");

            //Assign the user input to an int variable
            startCount = Convert.ToInt32(Console.ReadLine());

            //Ask the user for the ending point
            Console.WriteLine("Enter the Ending Point:");

            //Assign the user input to an int variable
            endCount = Convert.ToInt32(Console.ReadLine());

            //Add exception handling to check if numbers are lesser than 2
            try {
                if (number1 < 2 || number2 < 2 || number3 < 2) {
                    throw new Exception();
                }
            }
            catch {
                Console.WriteLine("Numbers can not be less than 2.");
            }

            //Add exception handling to check for empty words
            try {
                if (String.IsNullOrEmpty(word1) || String.IsNullOrEmpty(word2) || String.IsNullOrEmpty(word3)) {
                    throw new Exception();
                }
            }
            catch {
                Console.WriteLine("Words can not be empty.");
            }

            //Add exception handling to check for valid start and end poitns
            try {
                if (endCount < startCount || startCount <= 0 || endCount <= 0 || (endCount - startCount > 100)) {
                    throw new Exception();
                }
            }
            catch {
                Console.WriteLine("Invalid start and/or end points.");
            }

            //for loop
            for (i = startCount; i <= endCount; i++) {

                //set displayedValue
                displayedValue = Convert.ToString(i);

                //conditions for i
                if (i % number1 == 0) {
                    displayedValue = word1;
                }
                if (i % number2 == 0) {
                    displayedValue = word2;
                }
                if (i % number3 == 0) {
                    displayedValue = word3;
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
