using System;

class Program
{
    static void Main(string[] args)
    {
        // I exceeded requirements and showed creativity in the journal project by
        // adding two additional entries "Mood" and "location"
        // This entries prompts the users to enter how the feel as relates to the prompts they are replying to
        // it also asks for their current location and these enteries are saved alongside the other enteries in the ".txt file"

        //This block creates a new journal and prompt generator
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        bool running = true;

        while (running)
        {
            //This block displays menu options to the user
            Console.WriteLine("\n--- JOURNAL MENU ---");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");

            // This block ensures that all the conditions above are executed by using ifs statemets
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.Write("Mood: ");
                string mood = Console.ReadLine();

                Console.Write("Location: ");
                string location = Console.ReadLine();
            
                Entry newEntry = new Entry(prompt, response, mood, location);
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry recorded.\n");
            }

            else if (choice == "2")
            {
                Console.WriteLine("\n--- JOURNAL ENTRIES ---\n");
                myJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter a filename to save to (e.g., journal.txt): ");
                string saveFile = Console.ReadLine();
                myJournal.SaveToFile(saveFile);
                Console.WriteLine("Journal saved.");
            }    

            else if (choice == "4")
            {
                Console.Write("Enter the filename to load from (e.g., journal.txt): ");
                string loadFile = Console.ReadLine();
                myJournal.LoadFromFile(loadFile);
                Console.WriteLine("Journal loaded.");
            }

            else if (choice == "5")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                running = false;
            }

            else
            {
                Console.WriteLine("Invalid input. Please choose a number between 1 and 5.");
            }
        }
    }
}