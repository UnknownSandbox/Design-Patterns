namespace PatternsLib.Patterns.Bridge.Example
{
    /// <summary>
    /// RefinedAbstraction - уточненная абстракция
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>расширяет интерфейс, определенный абстракцией <see cref="Abstraction"/></lu>
    /// </li>
    /// </remarks>
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}