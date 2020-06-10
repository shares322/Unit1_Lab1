using System;

namespace Deliverable1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string destination;
            string travelSuggestion;
                       
            // Ask what type of vacation they would like
            
            Console.Write("What type of vacation do you want to go on (musical, tropical, or adventurous)?: ");
            string vacationType = Console.ReadLine();

            // Assign the vacation type they respond to
            if (vacationType == "musical") {
                destination = "New Orleans";
            } else if (vacationType == "tropical") {
                destination = "a Beach Vacation in Mexico";
            } else {
                destination = "Whitewater Rafting the Grand Canyon";
            }

            // Ask what the group size is

            Console.Write("What is your group size?: ");
            string inputSize = Console.ReadLine();
            
            // change string to number for group size
            int groupSize = int.Parse(inputSize);

            // Assign the group size to a travelSuggestion

            if (groupSize <= 2) {
                travelSuggestion = "First Class";
            } else if (groupSize >= 3 && groupSize <= 5) {
                    travelSuggestion = "a Helicopter";
            } else {
                    travelSuggestion = "a Charter Flight";
            }
            string result = ("Since you are a group of " + groupSize + " going on a(n) " + vacationType + " vacation, you should take " + travelSuggestion + " to " + destination + ". ");
            Console.WriteLine(result);
        }
    }
}
