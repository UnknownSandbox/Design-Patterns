using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.Composite.Example;
using CompositePattern = PatternsLib.Patterns.Composite.Example.Composite;

namespace Patterns.Actions.Patterns
{
    class Composite : PatternAction
    {
        public override void Execute()
        {
            // Create a tree structure
            Component root = new CompositePattern("root");

            _addToComponent(ref root,new Leaf("Leaf A"));
            _addToComponent(ref root,new Leaf("Leaf B"));
            

            Component comp = new CompositePattern("Composite X");

            _addToComponent(ref comp, new Leaf("Leaf XA"));
            _addToComponent(ref comp, new Leaf("Leaf XB"));

            _addToComponent(ref root,comp);
            _addToComponent(ref root, new Leaf("Leaf C")); 
      
            // Add and remove a leaf
            Component leaf = new Leaf("Leaf D"); 

            _addToComponent(ref root, leaf); 

            //Error (!)
            _addToComponent(ref leaf, new Leaf("Wow"));

            _removeFromComponent(ref root,leaf);
            Console.WriteLine("\n\n");
            // Recursively display tree
            Console.Write(root.Display(1));

            _again();
        }

        private void _addToComponent(ref Component parent,Component child)
        {
            try
            {
                parent.Add(child);
            }
            catch (Exception e)
            {
               Console.Write(e.Message);
            }
        }

        private void _removeFromComponent(ref Component parent, Component child)
        {
            try
            {
                parent.Remove(child);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
