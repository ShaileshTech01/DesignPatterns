using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Show(int depth);

    }
}
