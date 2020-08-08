using System;

namespace Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the DataTypes
            double number1;
            double number2;
            string operate;
            decimal result;

            //Ask the user for the first number
            Console.WriteLine("Enter the first number:");

            //Assign the user input to a double variable
            number1 = Convert.ToDouble(Console.ReadLine());

            //Ask the user for the operator
            Console.WriteLine("Input your operator (+ - / *):");

            //Assign the user input to a double variable
            operate = Convert.ToString(Console.ReadLine());

            //Ask the user for the second number
            Console.WriteLine("Enter the second number:");

            //Assign the user input to a double variable
            number2 = Convert.ToDouble(Console.ReadLine());

            //Switch cases according to the operation
            switch (operate) {
                case "+":
                    result = Convert.ToDecimal(number1 + number2);
                    break;
                case "-":
                    result = Convert.ToDecimal(number1 - number2);
                    break;
                case "/":
                    //Add exception handling to check if number2 divisor is 0
                    try {
                        if (number2 == 0) {
                            throw new Exception();
                        }
                    }
                    catch {
                        Console.WriteLine("Not divisible by 0.");
                        //Ask the user for the second number
                        Console.WriteLine("Enter the second number:");
                        //Assign the user input to a double variable
                        number2 = Convert.ToDouble(Console.ReadLine());
                    }
                    result = Convert.ToDecimal(number1 / number2);
                    break;
                case "*":
                    result = Convert.ToDecimal(number1 * number2);
                    break;
                default:
                    result = 0;
                    break;
            }

            //Display the result
            Console.WriteLine("Result: " + result.ToString());

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();
        }
    }
}
