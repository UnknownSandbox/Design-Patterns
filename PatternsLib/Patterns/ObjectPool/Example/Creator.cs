using System;

namespace PatternsLib.Patterns.ObjectPool.Example
{
    public class Creator : ICreation<Reusable>
    {
        private static Int32 iD = 0;

        public Reusable Create()
        {
            ++iD;
            return new Reusable(iD);
        }
    }
}