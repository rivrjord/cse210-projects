class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself through this experience?",
        "What made this time different than others?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    private List<string> _usedQuestions = new List<string>();

    public ReflectingActivity()
        : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    public override void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        if (_usedQuestions.Count >= _questions.Count)
        {
            _usedQuestions.Clear();
        }

        Random rnd = new Random();
        string question;

        do
        {
            question = _questions[rnd.Next(_questions.Count)];
        }
        while (_usedQuestions.Contains(question));

        _usedQuestions.Add(question);
        return question;
    }

    private void DisplayPrompt()
    {
        Console.Clear();
        Console.WriteLine("Reflection Activity\n");
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(5);
    }

    private void DisplayQuestions()
    {
        int timeLeft = GetDuration();
        while (timeLeft > 0)
        {
            Console.Clear();
            Console.WriteLine("Reflection Activity\n");
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
            timeLeft -= 5;
        }
    }
}
