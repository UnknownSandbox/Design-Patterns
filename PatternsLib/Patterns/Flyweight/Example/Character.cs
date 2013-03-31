namespace PatternsLib.Patterns.Flyweight.Example
{
    public abstract class Character
    {
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        protected int pointSize;

        public abstract string Display(int pointSize);
    }
}