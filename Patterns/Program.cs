using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Actions;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainAction = new PatternsList();
            mainAction.Execute();
            Console.Read();
        }
    }
}
