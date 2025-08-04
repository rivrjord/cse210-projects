using System;

class Program
{
    static void Main(string[] args)
    {
        StreakTracker tracker = new StreakTracker();
        bool hasShownStreak = false;

        while (true)
        {
            Console.Clear();
            
            if (!hasShownStreak)
            {
                tracker.DisplayUsageMessage();
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                hasShownStreak = true;
                Console.Clear();
            }

            Console.WriteLine("Mindfulness App");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectingActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (choice == "4" || activity == null)
            {
                Console.WriteLine("Thank you for taking a while to Cool it down.\nSee you next time. Goodbye!");
                break;
            }

            activity.Run();
        }
    }
}
