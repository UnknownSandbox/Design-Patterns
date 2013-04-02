using System;

namespace PatternsLib.Patterns.Chain.Example
{
    /// <summary>
    ///     The 'ConcreteHandler3' class
    /// </summary>
    public class ConcreteHandler3 : Handler
    {
        public override string HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
                return GetType().Name + "handled request " + request;
            else if (successor != null)
            {
                return  successor.HandleRequest(request);
            }
            return String.Empty;
        }
    }
}