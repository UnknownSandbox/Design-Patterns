namespace PatternsLib.Patterns.Prototype.Example_2
{
    public class ConcretePrototype1 : ExamplePrototype
    {
        // Constructor
        public ConcretePrototype1(string id)
            : base(id)
        {
        }

        public override ExamplePrototype Clone()
        {
            // Shallow copy
            return (ExamplePrototype)this.MemberwiseClone();
        }
    }
}