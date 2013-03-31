namespace PatternsLib.Patterns.Bridge.Example
{
    /// <summary>
    /// Abstraction - абстракция
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>определяем интерфейс абстракции;</lu>
    /// <lu>хранит ссылку на объект <see cref="Implementor"/></lu>
    /// </li>
    /// </remarks>
    public class Abstraction
    {
        protected Implementor implementor;

        // Property
        public Implementor Implementor
        {
            get { return implementor; }
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}