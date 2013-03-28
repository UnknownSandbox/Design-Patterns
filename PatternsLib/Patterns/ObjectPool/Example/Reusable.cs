using System;

namespace PatternsLib.Patterns.ObjectPool.Example
{
    public class Reusable
    {
        public Object[] Objs { get; protected set; }

        public Reusable(params Object[] objs)
        {
            this.Objs = objs;
        }
    }
}