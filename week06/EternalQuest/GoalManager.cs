using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        // Added motivational quote generator inorder to show creativity and exceed requirements
        private MotivationalQuote _quoteGenerator = new MotivationalQuote();

        public void Start()
        {
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine($"Score: {_score}");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Quit");
                Console.Write("Choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoalDetails(); break;
                    case "3": RecordEvent(); break;
                    case "4": SaveGoals(); break;
                    case "5": LoadGoals(); break;
                }

            } while (choice != "6");
        }

        private void CreateGoal()
        {
            Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
            Console.Write("Type: ");
            string type = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string desc = Console.ReadLine();
            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            if (type == "1")
                _goals.Add(new SimpleGoal(name, desc, points));
            else if (type == "2")
                _goals.Add(new EternalGoal(name, desc, points));
            else if (type == "3")
            {
                Console.Write("Target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
            }
        }

        private void ListGoalDetails()
        {
            foreach (var goal in _goals)
                Console.WriteLine(goal.GetDetailsString());
            Console.ReadLine();
        }

        private void RecordEvent()
        {
            for (int i = 0; i < _goals.Count; i++)
                Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");

            Console.Write("Select goal: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                int pointsEarned = _goals[index].RecordEvent();
                _score += pointsEarned;

                Console.WriteLine($"You earned {pointsEarned} points! Total score: {_score}");

                // Show a motivational quote after recording an event
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(_quoteGenerator.GetRandomQuote());
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }

            Console.ReadLine();
        }

        private void SaveGoals()
        {
            using (StreamWriter sw = new StreamWriter("goals.txt"))
            {
                sw.WriteLine(_score);
                foreach (var g in _goals)
                    sw.WriteLine(g.GetStringRepresentation());
            }
        }

        private void LoadGoals()
        {
            if (!File.Exists("goals.txt")) return;

            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] p = lines[i].Split('|');
                if (p[0] == "SimpleGoal")
                    _goals.Add(new SimpleGoal(p[1], p[2], int.Parse(p[3]), bool.Parse(p[4])));
                else if (p[0] == "EternalGoal")
                    _goals.Add(new EternalGoal(p[1], p[2], int.Parse(p[3])));
                else if (p[0] == "ChecklistGoal")
                    _goals.Add(new ChecklistGoal(p[1], p[2], int.Parse(p[3]), int.Parse(p[4]), int.Parse(p[5]), int.Parse(p[6])));
            }
        }
    }
}
