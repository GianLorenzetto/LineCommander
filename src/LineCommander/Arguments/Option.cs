namespace LineCommander
{
    public class Option
    {
        public bool IsPresent { get; set; }
        public string Name { get; }
        public ValueType ValueType { get; set; }
        public string Description { get; set; }
        public string Example { get; set; }

        public Option(string name, ValueType valueType)
        {
            IsPresent = false;
            Name = name;
            ValueType = valueType;
        }
        public Option(string name, ValueType valueType, string description) : this(name, valueType)
        {
            Name = name;
            ValueType = valueType;
            Description = description;
        }
        public Option(string name, ValueType valueType, string description, string example) : this(name, valueType)
        {
            Name = name;
            ValueType = valueType;
            Description = description;
            Example = example;
        }
    }
}
