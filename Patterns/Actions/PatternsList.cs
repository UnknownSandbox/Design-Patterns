using System;
using System.Linq;
using Patterns.Actions.Patterns;

namespace Patterns.Actions
{
    internal class PatternsList
    {
        private readonly PatternsActniosContainer _patternsList;
        private readonly string _quitKey = "q";


        public PatternsList()
        {
            _patternsList = _createPatternList();
        }

        private PatternsActniosContainer _createPatternList()
        {
            return new PatternsActniosContainer
                {
                    new PatternStruct("0", "Factory", new Prototype()),
                    new PatternStruct("1", "Abstract Factory", new AbstractFactory()),
                    new PatternStruct("2", "Factory Method", new FactoryMethod()),
                    new PatternStruct("3", "Lazy Load", new LazyLoad()),
                    new PatternStruct("4", "Object Pool", new ObjectPool()),
                    new PatternStruct("5", "Prototype", new Prototype()),
                    new PatternStruct("6", "Singleton", new Singleton()),
                    new PatternStruct("7", "Adapter", new Adapter()),
                    new PatternStruct("8", "Bridge", new Bridge()),
                    new PatternStruct("9", "Builder", new Builder()),
                    new PatternStruct("10", "Composite", new Composite())
                };
             
        }

        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("\n=============Pattern List:================== \n");

            foreach (var item in _patternsList.List)
            {
                Console.WriteLine("Key - {0}  | Pattern - {1}", item.Key, item.Name);
            }

            Console.Write("Press key ( {0} for quit ): ", _quitKey);
            var userKey = Console.ReadLine();

            _selectPattern(userKey);
        }

        private void _selectPattern(string index)
        {
            Console.WriteLine(" ");
            try
            {
                if (index == _quitKey)
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
                Console.WriteLine("\n Pattern executing failed. Message: {0} \n\n", e.Message);
            }
            Console.Write("Press any key");
            Console.ReadKey();
            Console.Clear();
            Execute();
        }

        private void _executeAction(PatternStruct actionItem)
        {
            Console.Clear();
            Console.WriteLine("\n============={0} Pattern:================== \n", actionItem.Name);
            actionItem.Pattern.Execute();
            Console.WriteLine("\n============={0} Pattern End:================== \n", actionItem.Name);
        }

        private PatternStruct _getPatternActionItemByKey(string index)
        {
            return _patternsList.List.FirstOrDefault(pattern => pattern.Key == index);
        }
    }
}