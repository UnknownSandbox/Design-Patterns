namespace PatternsLib.Patterns.Prototype.Example_2
{
    public abstract class ExamplePrototype 
    {
        private string id;

        // Constructor
        protected ExamplePrototype(string id)
        {
            this.id = id;
        }

        // Property
        public string Id
        {
            get { return id; }
        }

        public abstract ExamplePrototype Clone();
    } 
    
}
