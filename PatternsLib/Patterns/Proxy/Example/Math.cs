using System;
using System.Threading;

namespace PatternsLib.Patterns.Proxy.Example
{
    /// <summary>
    /// RealSubject - реальный объект
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>определяет реальный объект, представленный заместителем</lu>
    /// </li>
    /// </remarks>
    partial class Math : IMath
    {
        private string _state = "Not created";
        public Math()
        {
            
            Thread.Sleep(3000);
            _state = "Real Object";
        }

        public string GetState()
        {
            return _state;
        }

        public double Add(double x, double y) { return x + y; }
        public double Sub(double x, double y) { return x - y; }
        public double Mul(double x, double y) { return x * y; }
        public double Div(double x, double y) { return x / y; }
    }
}