using System;
using System.Globalization;

namespace ArrayWords
{
    class Program
    {

        //Declare the DataType property string array for class and Set the default array
        static string[] albertaLocations { get; set; } = new string[] { "Edmonton", "Calgary", "Red Deer", "Lethbridge", "Medicine Hat", "St. Albert", "Airdrie" };

        static void Main()
        {
            //Declare the DataTypes
            int option;
            int updateOption;
            string oldLocation;
            string newLocation;
            int deleteOption;
            string deleteLocationText;
            int deleteLocationIndex;

            //Title Case
            TextInfo myTI = new CultureInfo("en-US",false).TextInfo;

            //Let the user know the current array and call the ListLocation method
            ListLocations();

            //Display the options
            Console.WriteLine("\nTo Add, Enter 1:\nTo Update, Enter 2:\nTo Delete, Enter 3:");

            //Assign the user input to an int variable
            option = Convert.ToInt32(Console.ReadLine());

            //Switch cases according to the month code
            switch (option) {
                case 1:
                    //Ask the user for new input
                    Console.WriteLine("Input the new location:");

                    //Assign the user input to an int variable
                    newLocation = Convert.ToString(Console.ReadLine());

                    //Assign next array index to new value
                    albertaLocations[albertaLocations.Length - 1] = myTI.ToTitleCase(newLocation);

                    //Let the user know the current array and call the ListLocation method
                    ListLocations();
                    break;
                case 2:
                    //Display the options
                    Console.WriteLine("\nTo Update by Index, Enter 1:\nTo Update by Name, Enter 2:");

                    //Assign the user input to an int variable
                    updateOption = Convert.ToInt32(Console.ReadLine());

                    switch (updateOption) {
                        case 1:
                            //Ask the user for new input
                            Console.WriteLine("Input the new location:");

                            //Assign the user input to an int variable
                            newLocation = Convert.ToString(Console.ReadLine());

                            //Assign next array index to new value
                            albertaLocations[updateOption - 1] = newLocation;

                            //Let the user know the current array and call the ListLocation method
                            ListLocations();
                            break;
                        case 2:
                            //Ask the user for new input
                            Console.WriteLine("Input the location to update (case sensitive):");

                            //Assign the user input to an int variable
                            oldLocation = Convert.ToString(Console.ReadLine());

                            //Ask the user for new input
                            Console.WriteLine("Input the new location:");

                            //Assign the user input to an int variable
                            newLocation = Convert.ToString(Console.ReadLine());

                            //Update index to new value
                            albertaLocations[Array.IndexOf(albertaLocations, oldLocation)] = newLocation;

                            //Let the user know the current array and call the ListLocation method
                            ListLocations();
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    //Display the options
                    Console.WriteLine("\nTo Delete by Index, Enter 1:\nTo Delete by Name, Enter 2:");

                    //Assign the user input to an int variable
                    deleteOption = Convert.ToInt32(Console.ReadLine());

                    switch (deleteOption) {
                        case 1:
                            //Ask the user for new input
                            Console.WriteLine("Input the location index to delete:");

                            //Assign the user input to an int variable
                            deleteLocationIndex = Convert.ToInt32(Console.ReadLine());

                            //Delete text from locations
                             albertaLocations = DeleteArrayByIndex(albertaLocations, deleteLocationIndex - 1);

                            //Let the user know the current array and call the ListLocation method
                            ListLocations();
                            break;
                        case 2:
                            //Ask the user for new input
                            Console.WriteLine("Input the location name to delete (case sensitive):");

                            //Assign the user input to an int variable
                            deleteLocationText = Convert.ToString(Console.ReadLine());

                            //Delete index from locations
                            albertaLocations = DeleteArrayByName(albertaLocations, deleteLocationText);
                           
                            //Let the user know the current array and call the ListLocation method
                            ListLocations();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            //Let the user know how to exit the program
            Console.WriteLine("Press the enter key to close the program...");
            
            //Pause for input before continuing
            Console.ReadLine();

        }

        static void ListLocations()
        {
            //Declare the DataTypes
            int j;

            //Let the user know the current array
            Console.WriteLine("Welcome to Alberta Locations:");
            for (int i = 0; i < albertaLocations.Length; i++) {
                j = i + 1;
                Console.WriteLine(j.ToString() + ". " + albertaLocations[i]);
            }

        }

        static string[] DeleteArrayByName(string[] array, string name)
        {
            //Declare the DataType and set the string array size
            string[] returnArray = new string[array.Length - 1];
            //Initialize the index for new array
            int j = 0;
            for (int i = 0; i < array.Length; i++) {
                //if name does not match the indexed record, add to new array
                if (array[i] != name) {
                    returnArray[j] = array[i];
                    j++;
                }
            }
            //return new array
            return returnArray;
        }

        static string[] DeleteArrayByIndex(string[] array, int index)
        {
            //Declare the DataType and set the string array size
            string[] returnArray = new string[array.Length - 1];
            //Initialize the index for new array
            int j = 0;
            for (int i = 0; i < array.Length; i++) {
                //if name does not match the indexed record, add to new array
                if (i != index) {
                    returnArray[j] = array[i];
                    j++;
                }
            }
            //return new array
            return returnArray;
        }

    }
}
