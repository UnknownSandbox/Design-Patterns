using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Facade.Example
{
    

    /// <summary>
    /// Facade - фасад
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>"знает", каким классами подсистемы адресовать запрос;</lu>
    /// <lu>делегирует запросы клиентов подходящим объектам внутри подсистемы;</lu>
    /// </li>
    /// </remarks>
    public static class Facade
    {
        static Library.SubsystemA a = new Library.SubsystemA();
        static Library.SubsystemB b = new Library.SubsystemB();
        static Library.SubsystemC c = new Library.SubsystemC();

        public static string Operation1()
        {
            return "Operation 1\n" +
            a.A1() +
            a.A2() +
            b.B1();
        }
        public static string Operation2()
        {
            return"Operation 2\n" +
            b.B1() +
            c.C1();
        }
    }

   
}
