namespace EternalQuest
{
    abstract class Goal
    {
        private string _shortName;
        private string _description;
        private int _points;

        protected Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public string ShortName => _shortName;
        public string Description => _description;
        public int Points => _points;

        public abstract int RecordEvent();
        public abstract bool IsComplete();

        public virtual string GetDetailsString()
        {
            string check = IsComplete() ? "[X]" : "[ ]";
            return $"{check} {ShortName} ({Description})";
        }

        public abstract string GetStringRepresentation();
    }
}
