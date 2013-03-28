using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.LazyLoad
{
    public class LazyInit<T> where T : class, new()
    {
        protected LazyInit(){}

        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    //ASync access fix
                    lock (typeof (T))
                    {
                        if (_instance == null)
                        {
                            _instance = new T();
                        }
                    }
                }
                return _instance;
            }
        } 

        public static void Reload()
        {
            _instance = null;
        }
    }

}
