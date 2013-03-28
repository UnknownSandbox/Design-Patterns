using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PatternsLib.Patterns.ObjectPool;
using PatternsLib.Patterns.ObjectPool.Example;

namespace Patterns.Actions.Patterns
{
    public class ObjectPool : PatternAction 
    {
        public override void Execute()
        {
            Console.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod().Name);
            var reusablePool = new ReusablePool();

            var thrd1 = new Thread(Run);
            var thrd2 = new Thread(Run);
            var thisObject1 = reusablePool.GetObject();
            var thisObject2 = reusablePool.GetObject();
            thrd1.Start(reusablePool);
            thrd2.Start(reusablePool);
            ViewObject(thisObject1);
            ViewObject(thisObject2);
            Thread.Sleep(2000);
            reusablePool.Release(thisObject1);
            Thread.Sleep(2000);
            reusablePool.Release(thisObject2);
             
            _again();
        }
    
 

        private static void Run(Object obj)
        {
            Console.WriteLine("\t" + System.Reflection.MethodInfo.GetCurrentMethod().Name);
            var reusablePool = (ReusablePool)obj;
            Console.WriteLine("\tstart wait");
            var thisObject1 = reusablePool.WaitForObject();
            ViewObject(thisObject1);
            Console.WriteLine("\tend wait");
            reusablePool.Release(thisObject1);
        }

        private static void ViewObject(Reusable thisObject)
        {
            foreach (var obj in thisObject.Objs)
            {
                Console.Write(obj.ToString() + @" ");
            }
            Console.WriteLine();
        }
    }
}
