using System;

namespace Deliverable1
{
    class Program
    {
        static void Main()
        {
            string vacationType;
            int groupSize;
            string destination = "";
            string travelSuggestion = "";
            bool invalidInput = false;
            string result;

            // Get the type of vacation
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical or adventurous?");
            vacationType = Console.ReadLine();

            // Get the group size
            Console.WriteLine("How many are in your group?");
            groupSize = int.Parse(Console.ReadLine());

            // Convert the input to lower case to account for any capitalization 
            vacationType = vacationType.ToLower();

            //Find destination for the input vacation
            if (vacationType == "musical")
                destination = "New Orleans";
            else if (vacationType == "tropical")
                destination = "Beach Vacation in Mexico";
            else if (vacationType == "adventurous")
                destination = "Whitewater Rafting the Grand Canyon";
            else invalidInput = true;

            //Find travel suggestion for the input group size
            if (groupSize >= 1 && groupSize <= 2)
                travelSuggestion = "First Class";
            else if (groupSize >= 3 && groupSize <= 5)
                travelSuggestion = "Helicopter";
            else if (groupSize >= 6)
                travelSuggestion = "Charter Flight";
            else invalidInput = true;

            //Display suggestions
            if (invalidInput)
                result = "Invalid Input";
            else 
                result = "Since you are a group of " + groupSize + " going on a " + vacationType + " vacation, you should take " + travelSuggestion + " to " + destination;
            Console.WriteLine(result); 


        }
    }
}
