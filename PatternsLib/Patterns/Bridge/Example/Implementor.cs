namespace PatternsLib.Patterns.Bridge.Example
{
    /// <summary>
    /// Implementor - реализатор
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>определяет интерфейс для классов реализации. Он не обязан точно
    /// соотведствовать интерфейсу класса <see cref="Abstraction"/>. На самом деле оба
    /// интерфейса могут быть совершенно различны. Обычно интерфейс класса
    /// <see cref="Implementor"/> представляет только примитивные операции, а класс
    /// <see cref="Abstraction"/> определяет операции более высокого уровня, 
    /// базирующиеся на этих примитивах;</lu>
    /// </li>
    /// </remarks>
    public abstract class Implementor
    {
        public abstract void Operation();
    }
}