namespace PatternsLib.Patterns.Factory
{
    public abstract class Factory<TType, TInstance>
    {
        public abstract TInstance GetInstance(TType type);
    }
}