using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Actions
{
    public abstract class PatternAction
    {
        public abstract void Execute(); 

        protected void _again()
        {
                  Console.Write("\nAgain ? (y/n)");

            var key = Console.ReadLine();

            if (key == "y")
            {
                Console.WriteLine("\nReloading...\nDone!\n");
                Execute();
            }
            else
            {
                return;
            } 
        }
    }
}
