using System;
using System.Collections;

namespace PatternsLib.Patterns.Composite.Example
{
    /// <summary>
    /// Component - компонент
    /// </summary>
    /// <li>
    /// <lu>объявляет интерфейс для компонуемых объектов;</lu>
    /// <lu>предоставляет подходящую реализацию операций по умолчанию,
    /// общую для всех классов;</lu>
    /// <lu>объявляет интерфейс для доступа к потомкам и управлению ими;</lu>
    /// <lu>определяет интерфейс доступа к родителю компонента в рекурсивной структуре
    /// и при необходимости реализует его. Описанная возможность необязательна;</lu>
    /// </li>
    public abstract class Component
    {
        protected string name;
        protected ArrayList Children = new ArrayList();

        // Constructor
        protected Component(string name)
        {
            this.name = name;
        }


        public  void Add(Component component)
        {
            if (ItsComposite())
            {
                Children.Add(component);
            }
            else
            {
                throw new Exception("Cannot add to a leaf");
            }
        }

        public  void Remove(Component component)
        {
            if (ItsComposite())
            {
                Children.Remove(component);
            }
            else
            {
                throw new Exception("Cannot remove from a leaf");
            }

            
        }

        public abstract string Display(int depth);
         
        public abstract bool ItsComposite();
    }
}