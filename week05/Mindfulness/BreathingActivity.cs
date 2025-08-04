class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") {}

    public override void Run()
    {
        DisplayStartingMessage();

        int timeLeft = GetDuration();
        while (timeLeft > 0)
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            timeLeft -= 4;
            if (timeLeft <= 0) break;

            Console.Clear();
            Console.WriteLine("Breathe out...");
            ShowCountDown(6);
            timeLeft -= 6;
        }

        DisplayEndingMessage();
    }
}
