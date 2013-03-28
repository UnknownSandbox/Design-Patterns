namespace PatternsLib.Patterns.ObjectPool.Example
{
    public class ReusablePool : ObjectPool<Reusable>
    {
        public ReusablePool()
            : base(new Creator(), 2)
        {

        }
    }
}