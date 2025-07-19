using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureList = new List<Scripture>
        {
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Alma", 37, 6), "And now, ye may suppose that this is foolishness in me; but behold, I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise."),
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness."),
            new Scripture(new Reference("1 Nephi", 1, 3), "And I know that the record which I make is true; and I make it with mine own hand; and I make it according to my knowledge.")
        };

        Random rand = new Random();
        bool keepGoing = true;

        while (keepGoing)
        {
            // ✅ Pick a random scripture every time the loop starts
            Scripture scripture = scriptureList[rand.Next(scriptureList.Count)];

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                scripture.HideRandomWords(3);
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden or you quit memorizing.");

            Console.WriteLine("\nWould you like to memorize another scripture? (yes/no)");
            string response = Console.ReadLine().ToLower();

            if (response != "yes" && response != "y")
            {
                keepGoing = false;
            }
        }

        Console.WriteLine("\nThank you for using Scripture Memorizer. See you some other time!");
    }
}
// To exceed expectations, I added a loop that keeps generating new scriptures from a list of a few 
// that I created, unless the user chooses to the end the program.
