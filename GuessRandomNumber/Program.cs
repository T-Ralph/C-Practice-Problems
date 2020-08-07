using System;

namespace GuessRandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            Random rand;
            int randomNumber;
            int guess1;
            int guess2;
            int difference1;
            int difference2;
            string result;

            //Generate random number
            rand = new Random();
            randomNumber = rand.Next(1, 10);

            //Notify users that random number has been generated
            Console.WriteLine("This program has generated a random number");

            //Ask user1 to guess
            Console.WriteLine("User 1, guess the number:");

            //Assign the user1 input to an int variable
            guess1 = Convert.ToInt32(Console.ReadLine());

            //Ask user2 to guess
            Console.WriteLine("User 2, guess the number:");

            //Assign the user2 input to an int variable
            guess2 = Convert.ToInt32(Console.ReadLine());

            //Calculate for the difference between guessed number and random number
            difference1 = randomNumber - guess1;
            difference2 = randomNumber - guess2;

            //Check for the closest guess
            if (difference1 == difference2) {
                result = "It is a Draw";
            }
            else if (difference1 < difference2) {
                result = "User 1 is the Winner";
            }
            else if (difference1 > difference2) {
                result = "User 2 is the Winner";
            }
            else {
                result = "";
            }

            //Display the result
            Console.WriteLine("Random Number: " + randomNumber.ToString());
            Console.WriteLine(result);

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
