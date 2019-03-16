using System;


namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("Here are your options: \n\t" +
                              "1) Action \n\t" +
                              "2) Chill times \n\t" +
                              "3) Danger \n\t" +
                              "4) Good Food");
            int optionSelected = GetUserSelection(1, 4, "Please choose 1,2,3, or 4");
            int numberOfPeople = GetUserSelection(0, int.MaxValue, "How many people are you bringing with you?");
            Console.WriteLine(GetSuggestion(optionSelected, numberOfPeople));
            Console.WriteLine("Goodbye.");
            Console.ReadLine();
        }

        private static int GetUserSelection(int startValue, int endValue, string message)
        {
            int selection = int.MinValue;

            Console.WriteLine(message);

            while (selection < startValue || selection > endValue )
            {
                int.TryParse(Console.ReadLine(), out selection);

                if (selection >= startValue && selection <= endValue)
                    return selection;
                else
                {
                    Console.WriteLine("Invalid Selection please choose again");
                    continue;
                }

                
            }

            return selection;
        }

        private static string GetSuggestion(int optionSelected, int numberOfPeople)
        {
            string choice, activity, suggestion, modeOfTransportation;


            switch (optionSelected)
            {
                case 1:
                    choice = "Action";
                    activity = "Stock Car Racing";
                    break;
                case 2:
                    choice = "Chilling";
                    activity = "Hiking";
                    break;
                case 3:
                    choice = "Danger";
                    activity = "Skydiving";
                    break;
                case 4:
                    choice = "Good Food";
                    activity = "To Taco Bell";
                    break;
                default:
                    return "I am unable to make a suggestion at this time.";
            }

            if (numberOfPeople == 0)
                modeOfTransportation = "sneakers";
            else if (numberOfPeople >= 1 && numberOfPeople <= 4)
                modeOfTransportation = "a sedan";
            else if (numberOfPeople >= 5 && numberOfPeople <= 10)
                modeOfTransportation = "a Volkswagen bus";
            else if (numberOfPeople >= 11)
                modeOfTransportation = "an airplane";
            else
                modeOfTransportation = "spaceship";

            suggestion = "Okay if you’re in the mood for " +
                         choice +
                         ", then you should go to " +
                         activity +
                         " and travel in " +
                         modeOfTransportation + "!";

            


            return suggestion;
        }
    }
}
