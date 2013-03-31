namespace Patterns.Actions
{
    public class PatternStruct
    {
        public string Key;
        public string Name;
        public PatternAction Pattern;
        public PatternStruct(string key,string name,PatternAction pattern)
        {
            Key = key;
            Name = name;
            Pattern = pattern;
        }
    }
}