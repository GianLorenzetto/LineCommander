namespace LineCommander
{
    public class Action
    {
        public bool IsPresent { get; set; }
        public string Name { get; }

        public Action(string name)
        {
            IsPresent = false;
            Name = name;
        }

        public static implicit operator bool(Action a)
        {
            return !ReferenceEquals(a, null) && a.IsPresent;
        }
    }
}
