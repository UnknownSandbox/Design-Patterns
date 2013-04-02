using System;

namespace PatternsLib.Patterns.Chain.Example
{
    /// <summary>
    /// The 'ConcreteHandler2' class
    /// </summary>
    public class ConcreteHandler2 : Handler
    {
        public override string HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
                return this.GetType().Name + "handled request " + request;
            else if (successor != null)
            {
               return successor.HandleRequest(request);
            }
            return String.Empty;
        }
    }
}