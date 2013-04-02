namespace PatternsLib.Patterns.Proxy.Example
{
    /// <summary>
    /// Subject - субъект
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>определяет общий для <see cref="Math"/> и <see cref="Proxy"/> интерфейс, так что класс
    /// <see cref="Proxy"/> можно использовать везде, где ожидается <see cref="Math"/></lu>
    /// </li>
    /// </remarks>
    public interface IMath
    {
        string GetState();
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }
}