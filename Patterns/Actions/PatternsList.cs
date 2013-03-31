using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Actions.Patterns;

namespace Patterns.Actions
{
    class PatternsList
    {
        private List<string> _patternsList;

        public PatternsList()
        {
            _patternsList = new List<string>
                {
                    "Factory",
                    "Abstract Factory",
                    "Builder",
                    "Factory Method",
                    "Lazy Load",
                    "Object Pool",
                    "Prototype",
                    "Singleton",
                    "Adapter",
                    "Bridge"
                };
        }

        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("\n=============Pattern List:================== \n");  
            for (int index = 0; index < _patternsList.Count; index++)
            {
                var item = _patternsList[index];
                Console.WriteLine("Key - {0}  | Pattern - {1}", index, item); 
            }
            string userKey;
            Console.Write("Press key: ");
            userKey =  Console.ReadLine();

            _selectPattern(userKey);

        }

        private void _selectPattern(string index)
        {
            Console.WriteLine(" ");
            try
            {
                if (index == "q")
                {
                    return;
                }
              
                var actionItem = _getPatternActionItemByKey(index);

                if (actionItem == null)
                {
                    Console.WriteLine("Unknown action.Try Again.");
                    
                }
                else
                {
                    _executeAction(actionItem);   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Pattern executing failed. Message: {0} \n\n",e.Message);
            }
            Console.Write("Press any key");
            Console.ReadKey();
            Console.Clear();
            Execute(); 
        }

        private void _executeAction(PatternActionItem actionItem)
        {
            Console.Clear();
            Console.WriteLine("\n============={0} Pattern:================== \n", actionItem.PatternName);
            actionItem.Action.Execute();
            Console.WriteLine("\n============={0} Pattern End:================== \n", actionItem.PatternName);
        }

        private PatternActionItem _getPatternActionItemByKey(string index)
        {
            switch (index)
            {
                case "0":
                    return new PatternActionItem(new Prototype(), "Factory");
                case "1":
                    return new PatternActionItem(new AbstractFactory(), "Abstract Factory");
                case "2":
                    return new PatternActionItem(new Builder(), "Builder");
                case "3":
                    return new PatternActionItem(new FactoryMethod(), "Factory Method");
                case "4":
                    return new PatternActionItem(new LazyLoad(), "Lazy Load");
                case "5":
                    return new PatternActionItem(new ObjectPool(), "Object Pool");
                case "6":
                    return new PatternActionItem(new Prototype(), "Prototype");
                case "7":
                    return new PatternActionItem(new Singleton(), "Singleton");
                case "8":
                    return new PatternActionItem(new Adapter(), "Adapter");
                case "9":
                     return new PatternActionItem(new Bridge(), "Bridge");
                default:
                    return null;
            }
        }
    }
}
