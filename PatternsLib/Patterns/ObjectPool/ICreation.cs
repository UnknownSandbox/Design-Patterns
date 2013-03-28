namespace PatternsLib.Patterns.ObjectPool
{
    /// <summary>
    ///     Интерфейс для использования шаблона "Object Pool" <see cref="Object_Pool" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICreation<T>
    {
        /// <summary>
        ///     Возвращает вновь созданный объект
        /// </summary>
        /// <returns></returns>
        T Create();
    }
}