using System;

namespace MonthCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            string monthShort;
            string monthFull;

            //Ask the user for the month code
            Console.WriteLine("Enter a 3 character month code:");

            //Assign the user input to a string variable
            monthShort = Convert.ToString(Console.ReadLine());

            //Convert string to lowercase to make program case insensitive
            monthShort = monthShort.ToLower();

            //Switch cases according to the month code
            switch (monthShort) {
                case "jan":
                    monthFull = Convert.ToString("January");
                    break;
                case "feb":
                    monthFull = Convert.ToString("February");
                    //Ask the user for the year
                    Console.WriteLine("Enter the year:");
                    break;
                case "mar":
                    monthFull = Convert.ToString("March");
                    break;
                case "apr":
                    monthFull = Convert.ToString("April");
                    break;
                case "may":
                    monthFull = Convert.ToString("May");
                    break;
                case "jun":
                    monthFull = Convert.ToString("June");
                    break;
                case "jul":
                    monthFull = Convert.ToString("July");
                    break;
                case "aug":
                    monthFull = Convert.ToString("August");
                    break;
                case "sept":
                    monthFull = Convert.ToString("September");
                    break;
                case "oct":
                    monthFull = Convert.ToString("October");
                    break;
                case "nov":
                    monthFull = Convert.ToString("November");
                    break;
                case "dec":
                    monthFull = Convert.ToString("December");
                    break;
                default:
                    monthFull = "Invalid month code";
                    break;
            }

            //Display the result
            Console.WriteLine("Full Month: " + monthFull);

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
