using System;

namespace RandomUppercaseChars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            string randomPassword;
            Random rand;
            char randChar;

            //Ask the user for the text
            Console.WriteLine("This program generates random password that is 5 characters long, consisting of uppercase letters:");

            //Generate random letter 5 times
            rand = new Random();
            randChar = (char) rand.Next('A', 'Z');
            randomPassword = randChar.ToString();
            randChar = (char) rand.Next('A', 'Z');
            randomPassword += randChar.ToString();
            randChar = (char) rand.Next('A', 'Z');
            randomPassword += randChar.ToString();
            randChar = (char) rand.Next('A', 'Z');
            randomPassword += randChar.ToString();
            randChar = (char) rand.Next('A', 'Z');
            randomPassword += randChar.ToString();

            //Display the result
            Console.WriteLine(randomPassword);

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
