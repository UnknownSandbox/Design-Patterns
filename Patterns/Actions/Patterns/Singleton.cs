using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.Singleton.Example;

namespace Patterns.Actions.Patterns
{
    class Singleton : PatternAction
    {
        public override void Execute()
        {
            var logger1 = Logger.GetInstance();
            var logger2 = Logger.GetInstance();

            logger1.AddLog(" Hello ");
            logger2.AddLog(" World ");


            var logs = logger1.GetLogs();
            for (var index = 0; index < logs.Count; index++)
            {
                var log = logs[index];
                Console.WriteLine("Log {0} : {1}",index,log);
            }

            _again();
        }
    }
}
