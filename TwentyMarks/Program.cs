using System;

namespace TwentyMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            int i;
            int previousMark = 0;
            int currentMark;
            int highestMark = 0;
            int lowestMark = 0;
            double totalMark = 0;
            decimal averageMark;
            int abortNumber = 101;

            while (abortNumber > 100) {

                for (i = 0; i <= 20; i++) {

                    //Ask the user for marks
                    Console.WriteLine("Enter the mark:");

                    //Assign the user input to an int variable
                    currentMark = Convert.ToInt32(Console.ReadLine());

                    //Add up total marks
                    totalMark += Convert.ToDouble(currentMark);

                    //Check for highest and lowest marks
                    highestMark = Math.Max(highestMark, currentMark);
                    lowestMark = Math.Min(lowestMark, currentMark);
                    //Reset lowest mark for first loop
                    if (i == 0) {
                        lowestMark = currentMark;
                    }

                    //Assign the current mark to the previous mark for next loop comparison
                    previousMark = currentMark;
                }

                //Calculate average mark
                averageMark = Convert.ToDecimal(totalMark / 20);
                //Round up the result to maximum of 2 decimal places
                averageMark = Math.Ceiling(averageMark * 100) / 100;

                //Display the result in a concatenated sentence
                Console.WriteLine("The highest mark: " + highestMark.ToString());
                Console.WriteLine("The lowest mark: " + lowestMark.ToString());
                Console.WriteLine("The average mark: " + averageMark.ToString());

                //Ask the user for continuation
                Console.WriteLine("Do you want to continue? Enter any number above 100 to continue or any number less than 100 to exit.");

                //Assign the user input to an int variable
                abortNumber = Convert.ToInt32(Console.ReadLine());
                
            }

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
