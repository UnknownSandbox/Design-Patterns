namespace Patterns.Actions
{
    public class PatternActionItem
    {
        public string PatternName;
        public PatternAction Action;

        public PatternActionItem (PatternAction action, string patternName)
        {
            PatternName = patternName;
            Action = action;
        }
    }
}