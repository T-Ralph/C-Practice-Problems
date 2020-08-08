using System;

namespace LoopHello
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            string text = "";

            //do-while loop
            do {

                //Say hello
                Console.WriteLine("Hello");

                //Assign the user input to a string variable
                text = Convert.ToString(Console.ReadLine());
                text = text.ToLower();

            } while (text != "stop");

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
