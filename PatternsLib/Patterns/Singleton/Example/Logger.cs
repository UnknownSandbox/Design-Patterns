using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Singleton.Example
{
    public class Logger
    {
        private static Logger _instance = new Logger();
        private List<string> _logs = new List<string>();
        private Logger()
        {
            
        }
        public static Logger GetInstance()
        {
            return _instance;
        }
        public void AddLog(string log)
        {
            _logs.Add(log);
        }

        public List<String> GetLogs()
        {
            return _logs;
        }

    }
}
