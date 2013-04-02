using System;

namespace PatternsLib.Patterns.Chain.Example
{
    /// <summary>
    /// The 'ConcreteHandler1' class
    /// </summary>
    public class ConcreteHandler1 : Handler
    {
        public override string HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
                return this.GetType().Name + "handled request " + request;
            else if (successor != null)
            {
                return successor.HandleRequest(request); 
            }
            return String.Empty;
        }
    }
}