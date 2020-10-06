using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Composite : Component
    {
        private List<Component> childComponent = new List<Component>();

        public Composite(string name) : base(name)
        { }

        public override void Add(Component component)
        {
            childComponent.Add(component);
        }

        public override void Remove(Component component)
        {
            childComponent.Remove(component);
        }

        public override void Show(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            //display child
            foreach (Component component in childComponent)
            {
                component.Show(depth + 2);
            }
        }
    }
}
