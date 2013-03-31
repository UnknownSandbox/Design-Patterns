using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Facade.Example
{
    namespace Library
    {
        /// <summary>
        /// Класс подсистемы
        /// </summary>
        /// <remarks>
        /// <li>
        /// <lu>реализует функциональность подсистемы;</lu>
        /// <lu>выполняет работу, порученную объектом <see cref="Facade"/>;</lu>
        /// <lu>ничего не "знает" о существовании фасада, то есть не хранит ссылок на него;</lu>
        /// </li>
        /// </remarks>
        internal class SubsystemA
        {
            internal string A1()
            {
                return "Subsystem A, Method A1\n";
            }
            internal string A2()
            {
                return "Subsystem A, Method A2\n";
            }
        }
        internal class SubsystemB
        {
            internal string B1()
            {
                return "Subsystem B, Method B1\n";
            }
        }
        internal class SubsystemC
        {
            internal string C1()
            {
                return "Subsystem C, Method C1\n";
            }
        }
    }
}
