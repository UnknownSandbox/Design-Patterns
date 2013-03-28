namespace PatternsLib.Patterns.Prototype.Example_2
{
    public class ConcretePrototype2 : ExamplePrototype
    {
        // Constructor
        public ConcretePrototype2(string id)
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