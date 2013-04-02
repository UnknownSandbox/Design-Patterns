namespace PatternsLib.Patterns.Chain.Example
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract string HandleRequest(int request);
    }
}